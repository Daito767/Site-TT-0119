using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer.Data
{
	public struct BrowserDimension
	{
		public int Width { get; set; }
		public int Height { get; set; }
	}

	public struct UserLoginData
	{
		public int Id { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public string UserType { get; set; }
		public string IdDiscord { get; set; }
		public int CleanNum { get; set; }
	}

	public struct UserNamesAndCleanNum
	{
		public int Id { get; set; }
		public string UserName { get; set; }
		public int CleanCount { get; set; }
	}

	public struct CleanLog
	{
		public int Id { get; set; }
		public string Participants { get; set; }
		public DateTime DateTime { get; set; }
		public string Comment { get; set; }
	}

	public struct LessonFromSchedule
	{
		public int Id { get; set; }
		public string Day { get; set; }
		public int LessonNumber { get; set; }
		public string LessonName { get; set; }
		public int Parity { get; set; }
	}

	public struct LessonDuration
	{
		public int Id { get; set; }
		public int LessonNumber { get; set; }
		public int Start { get; set; }
		public int End { get; set; }
		public int Shift { get; set; }
	}

	public struct LessonOfLiveSchedule
	{
		public int LessonNumber { get; set; }
		public string LessonName { get; set; }
		public string State { get; set; }
	}

	public enum NormalDayOfWeek
	{
		Monday = 0,
		Tuesday = 1,
		Wednesday = 2,
		Thursday = 3,
		Friday = 4,
		Saturday = 5,
		Sunday = 6,
	}
}
