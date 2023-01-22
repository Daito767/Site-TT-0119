using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using DBLibrary;

namespace BlazorServer.Data
{
	public class LiveSchedule
	{
		// Orarul cu toate disciplinile din toate zilele.
		public List<LessonFromSchedule> AllLessons { get; private set; }

		// Disciplinele din zua curenta.
		public List<LessonFromSchedule> TodayLessons { get; private set; }

		// Orarul sunetelor.
		public List<LessonDuration> LessonDurations { get; private set; }

		// Orarul interactiv al disciplinelor de azi.
		public List<LessonOfLiveSchedule> LiveLessons { get; private set; } = new List<LessonOfLiveSchedule>(0);

		public DateTime dtNow { get; private set; }

		public string ErrorMsg { get; private set; }
		
		public bool InvertParity { get; private set; }

		public bool DBUpdateError { get; private set; } = false;
		
		public int Day { get; private set; }

		// Pastreaza lectia ce ruleaza sau lectia ce va rula daca acum este pauza. Daca CurrentLesson == 0 inseamna ca nici o lectie nu e activa.
		public int CurrentLesson { get; private set; }
		
		public int SleepDelay { get; set; } = 1000;

		private int parity { get; set; }
		
		private int timeNowInMinutes { get; set; }
		
		private DateTime lastDBUpdate { get; set; }

		private DateTime initialCustomTime { get; } = new DateTime(2022, 6, 23, 12, 0, 0);

		private TimeSpan deltaForCustomTime { get; }

		private DataBaseAcces dbAcces = new DataBaseAcces();
		
		private string[] weekDayNames = new string[] { "Luni", "Marți", "Miercuri", "Joi", "Vineri", "Sambătă", "Duminică" };

		public LiveSchedule()
		{
			dtNow = GetDTNow(); // Pentru a furniza de la inceput ora in RM pentru toate paginile ce utilizeaza ora.
			deltaForCustomTime = initialCustomTime - dtNow;
			runAsync();
		}

		private async void runAsync()
		{
			await Task.Run(() => run());
		}

		private void run()
		{
			UpdateFromDB(); 
			lastDBUpdate = DateTime.Now;

			while (true)
			{
				if ((DateTime.Now - lastDBUpdate).TotalMinutes > 1 || DBUpdateError)
				{
					UpdateFromDB();
					lastDBUpdate = DateTime.Now;
				}

				dtNow = GetDTNow();
				dtNow = AddDeltaTimeForDebug(dtNow, deltaForCustomTime); // WARNING: Delete for relese.

				parity = GetParityOfWeek(dtNow);
				Day = GetDayOfWeek(dtNow);
				timeNowInMinutes = dtNow.Minute + dtNow.Hour * 60;

				SleepDelay = 1000;


				if (Day == 5 || Day == 6)
				{
					ErrorMsg = "Azi este zi de weekend";
					SleepDelay = 1000 * 60 * 60;
					TodayLessons?.Clear();
					LiveLessons?.Clear();
				}
				else
				{
					if (!DBUpdateError)
					{
						TodayLessons = GetLessons();
						SleepDelay = AdjustsSleepDelay();
						UpdateLiveSchedule();
					}
					else
					{
						SleepDelay = 1000;
					}
				}
				Thread.Sleep(SleepDelay);
			}
		}

		private void UpdateLiveSchedule()
		{
			LiveLessons?.Clear();
			CurrentLesson = 0;
			LessonOfLiveSchedule lesson = new LessonOfLiveSchedule();

			for (int i = 0; i < TodayLessons.Count; i++)
			{
				lesson.LessonName = TodayLessons[i].LessonName;
				lesson.LessonNumber = TodayLessons[i].LessonNumber;
				int lessonNumber = lesson.LessonNumber - 1;

				if (IsLessonRuns(lessonNumber))
				{
					lesson.State = $"Pauza in {LessonDurations[lessonNumber].End - timeNowInMinutes - 1}:{TimeLengthFormat(60 - dtNow.Second)}";
					CurrentLesson = lesson.LessonNumber;
				}
				// Daca CurrentLesson == 0 inseamna ca nici o lectie nu e activa.
				else if (CurrentLesson == 0 && IsBreak(lessonNumber) && !isLessonsOver())
				{
					lesson.State = $"Lectie in {LessonDurations[lessonNumber + 1].Start - timeNowInMinutes}:{TimeLengthFormat(60 - dtNow.Second)}";
					CurrentLesson = lesson.LessonNumber;
				}
				else
				{
					// Inca nu s-a inceput ora.
					lesson.State = $"{TimeFormat(LessonDurations[lessonNumber].Start)} - {TimeFormat(LessonDurations[lessonNumber].End)}";
				}

				LiveLessons.Add(lesson);
			}
		}

		private async void UpdateFromDB()
		{
			try
			{
				string sql_command;

				sql_command = $"SELECT * FROM `DurationOfLessons`";
				LessonDurations = await dbAcces.LoadData<LessonDuration, dynamic>(sql_command, new { });

				sql_command = $"SELECT * FROM `ScheduleOfLessons`";
				AllLessons = await dbAcces.LoadData<LessonFromSchedule, dynamic>(sql_command, new { });

				sql_command = $"SELECT * FROM `Parameters` WHERE `Name`=\"InvertParity\"";

				//List<DBParameter> dbParameters = await dbAcces.LoadData<DBParameter, dynamic>(sql_command, new { });
				//InvertParity = dbParameters[0].Value == "true";
				InvertParity = true;

				DBUpdateError = false;
			}
			catch (Exception e)
			{
				DBUpdateError = true;
			}
		}

		private bool IsLessonRuns(int currentLessonCount)
		{
			return LessonDurations[currentLessonCount].Start <= timeNowInMinutes && timeNowInMinutes < LessonDurations[currentLessonCount].End;
		}

		private bool IsBreak(int currentLessonCount)
		{
			return LessonDurations[currentLessonCount].Start < timeNowInMinutes && timeNowInMinutes < LessonDurations[currentLessonCount + 1].Start;
		}

		private bool isLessonsOver()
		{
			return LessonDurations[TodayLessons[TodayLessons.Count - 1].LessonNumber - 1].End <= timeNowInMinutes;
		}

		private List<LessonFromSchedule> GetLessons()
		{
			List<LessonFromSchedule> _lessons = new List<LessonFromSchedule>();
			foreach (var item in AllLessons)
			{
				if (item.Day == weekDayNames[Day] && (parity == item.Parity || item.Parity == -5))
				{
					_lessons.Add(item);
				}
			}

			return _lessons;
		}
		 
		private int GetParityOfWeek(DateTime dt)
		{
			int weekParity = ISOWeek.GetWeekOfYear(dt) % 2;
			if (InvertParity)
			{
				weekParity = weekParity == 0 ? 1 : 0;
			}
			return weekParity;
		}

		private int GetDayOfWeek(DateTime dt)
		{
			int day = (int)dt.DayOfWeek;
			return day > 0 ? day - 1 : 6;
		}

		private int AdjustsSleepDelay()
		{
			int numOfFirstLesson = TodayLessons[0].LessonNumber - 1;
			if (timeNowInMinutes < LessonDurations[numOfFirstLesson].Start)
			{
				ErrorMsg = "Lectiile inca nu s-au inceput.";

				if (LessonDurations[numOfFirstLesson].Start - timeNowInMinutes <= 2)
				{
					return 1000;
				}
				
				if (LessonDurations[numOfFirstLesson].Start - timeNowInMinutes <= 20)
				{
					return 1000 * 60;
				}
				
				if (LessonDurations[numOfFirstLesson].Start - timeNowInMinutes <= 60)
				{
					return 1000 * 60 * 10;
				}
			}
			else if (isLessonsOver())
			{
				ErrorMsg = "Lectiile s-au finisat.";
				return 1000 * 60 * 10;
			}

			return 1000;
		}

		private string TimeFormat(int minutes)
		{
			return $"{TimeLengthFormat(minutes / 60)}:{TimeLengthFormat(minutes % 60)}";
		}

		private string TimeLengthFormat(int num)
		{
			string str_num = num.ToString();
			if (str_num.Length == 1)
			{
				return "0" + str_num;
			}
			return str_num;
		}

		private DateTime GetDTNow()
		{
			TimeZoneInfo cstZone = TimeZoneInfo.FindSystemTimeZoneById("GTB Standard Time");
			return TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, cstZone);
		}

		private DateTime AddDeltaTimeForDebug(DateTime dt, TimeSpan tspan)
		{

			DateTime newDT = dt.AddDays(tspan.Days);
			newDT = newDT.AddHours(tspan.Hours);
			newDT = newDT.AddMinutes(tspan.Minutes);
			newDT = newDT.AddSeconds(tspan.Seconds);

			return newDT;
		}
	}
}
