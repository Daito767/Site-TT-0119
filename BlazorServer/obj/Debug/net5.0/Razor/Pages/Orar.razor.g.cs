#pragma checksum "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc7d016570cd0d05857b7472af93b59c36abe6fe"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorServer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\_Imports.razor"
using BlazorServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\_Imports.razor"
using BlazorServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
using BlazorServer.Shared.LessonSchedule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/orar/{tab?}")]
    public partial class Orar : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "ul");
            __builder.AddAttribute(1, "class", "nav nav-tabs");
            __builder.OpenElement(2, "li");
            __builder.AddAttribute(3, "class", "nav-item");
            __builder.OpenElement(4, "a");
            __builder.AddAttribute(5, "class", "nav-link" + " " + (
#nullable restore
#line 13 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
                            CheckNavLinkState("principal")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "href", "/orar/principal");
            __builder.AddContent(7, "Principal");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n\t");
            __builder.OpenElement(9, "li");
            __builder.AddAttribute(10, "class", "nav-item");
            __builder.OpenElement(11, "a");
            __builder.AddAttribute(12, "class", "nav-link" + " " + (
#nullable restore
#line 16 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
                            CheckNavLinkState("5days")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "href", "orar/5days");
            __builder.AddContent(14, "5 zile inainte");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 18 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
     if (UData.IsLoged)
	{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(15, "<li class=\"nav-item\"><a class=\"nav-link\" href=\"/orar-edit/\">Editeaza orarul</a></li>");
#nullable restore
#line 23 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
	}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "d-flex justify-content-around flex-wrap text-center align-self-start");
#nullable restore
#line 27 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
     if (tab == "principal")
	{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "p-2");
            __builder.AddMarkupContent(21, "<h5>Orarul de ieri</h5>");
#nullable restore
#line 31 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
              
				temDateTime = GetYesterdayDay();
				dayOfWeek = GetDayOfWeek(temDateTime);
				parity = GetParityOfWeek(temDateTime);
			

#line default
#line hidden
#nullable disable
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "d-flex");
            __builder.AddAttribute(24, "style", "margin-bottom: -1px;");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "p-1 pl-2 pr-2 bg-dark text-white");
            __builder.OpenElement(27, "span");
            __builder.AddAttribute(28, "class", "text-warning");
#nullable restore
#line 38 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
__builder.AddContent(29, weekDayNames[dayOfWeek]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddContent(30, " ");
#nullable restore
#line 38 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
__builder.AddContent(31, temDateTime.Day);

#line default
#line hidden
#nullable disable
            __builder.AddContent(32, " ");
#nullable restore
#line 38 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
__builder.AddContent(33, monthNames[temDateTime.Month - 1]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n\r\n\t\t\t\t");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "ml-1 align-self-end");
            __builder.AddMarkupContent(37, "\r\n\t\t\t\t\tIn săptămână ");
            __builder.OpenElement(38, "span");
            __builder.AddAttribute(39, "class", "text-primary");
#nullable restore
#line 42 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
__builder.AddContent(40, parityNames[parity]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n\t\t\t");
            __builder.OpenComponent<global::BlazorServer.Shared.LessonSchedule.LessonScheduleTable>(42);
            __builder.AddAttribute(43, "invertParity", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 45 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
                                               invertParity

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "weekParity", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 45 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
                                                                        parity

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "lessons", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.List<BlazorServer.Data.LessonFromSchedule>>(
#nullable restore
#line 45 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
                                                                                        lessons

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "dayOfWeek", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 45 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
                                                                                                           dayOfWeek

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 48 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
         if (LiveSchedule.Day < 5)
		{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "p-2");
            __builder.AddMarkupContent(49, "<h5>Orarul de azi</h5>\r\n\t\t\t\t");
            __builder.OpenElement(50, "table");
            __builder.AddAttribute(51, "class", "table");
            __builder.AddMarkupContent(52, "<thead class=\"thead-dark\"><tr><th scope=\"col\">Perechea</th>\r\n\t\t\t\t\t\t\t<th scope=\"col\">Disciplina</th>\r\n\t\t\t\t\t\t\t<th scope=\"col\">Durata</th></tr></thead>\r\n\t\t\t\t\t");
            __builder.OpenElement(53, "tbody");
#nullable restore
#line 61 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
                         foreach (var item in LiveSchedule.LiveLessons)
						{
							if (item.LessonNumber == LiveSchedule.CurrentLesson)
							{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(54, "tr");
            __builder.AddAttribute(55, "class", "table-primary");
            __builder.OpenElement(56, "th");
            __builder.AddAttribute(57, "scope", "row");
#nullable restore
#line 66 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
__builder.AddContent(58, item.LessonNumber);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n\t\t\t\t\t\t\t\t\t");
            __builder.OpenElement(60, "td");
#nullable restore
#line 67 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
__builder.AddContent(61, item.LessonName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n\t\t\t\t\t\t\t\t\t");
            __builder.OpenElement(63, "th");
#nullable restore
#line 68 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
__builder.AddContent(64, item.State);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 70 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
							}
							else
							{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(65, "tr");
            __builder.OpenElement(66, "th");
            __builder.AddAttribute(67, "scope", "row");
#nullable restore
#line 74 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
__builder.AddContent(68, item.LessonNumber);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n\t\t\t\t\t\t\t\t\t");
            __builder.OpenElement(70, "td");
#nullable restore
#line 75 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
__builder.AddContent(71, item.LessonName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n\t\t\t\t\t\t\t\t\t");
            __builder.OpenElement(73, "td");
#nullable restore
#line 76 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
__builder.AddContent(74, item.State);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 78 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
							}
						}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 83 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
                 if (LiveSchedule.LiveLessons is null)
				{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(75, "<h4>Tabelul se încarcă</h4>");
#nullable restore
#line 86 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
				}
				else if (LiveSchedule.LiveLessons.Count == 0)
				{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(76, "<h4>Tabelul este gol</h4>");
#nullable restore
#line 90 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
				}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 92 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
__builder.AddContent(77, ReloadRenderPage(LiveSchedule.SleepDelay));

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
                                                      
		}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(78, "div");
            __builder.AddAttribute(79, "class", "p-2");
            __builder.AddMarkupContent(80, "<h5>Orarul de maine</h5>");
#nullable restore
#line 96 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
              
				temDateTime = GetTomorrowDay();
				dayOfWeek = GetDayOfWeek(temDateTime);
				parity = GetParityOfWeek(temDateTime);
			

#line default
#line hidden
#nullable disable
            __builder.OpenElement(81, "div");
            __builder.AddAttribute(82, "class", "d-flex");
            __builder.AddAttribute(83, "style", "margin-bottom: -1px;");
            __builder.OpenElement(84, "div");
            __builder.AddAttribute(85, "class", "p-1 pl-2 pr-2 bg-dark text-white");
            __builder.OpenElement(86, "span");
            __builder.AddAttribute(87, "class", "text-warning");
#nullable restore
#line 104 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
__builder.AddContent(88, weekDayNames[dayOfWeek]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddContent(89, " ");
#nullable restore
#line 104 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
__builder.AddContent(90, temDateTime.Day);

#line default
#line hidden
#nullable disable
            __builder.AddContent(91, " ");
#nullable restore
#line 104 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
__builder.AddContent(92, monthNames[temDateTime.Month - 1]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n\t\t\t\t");
            __builder.OpenElement(94, "div");
            __builder.AddAttribute(95, "class", "ml-1 align-self-end");
            __builder.AddMarkupContent(96, "\r\n\t\t\t\t\tIn săptămână ");
            __builder.OpenElement(97, "span");
            __builder.AddAttribute(98, "class", "text-primary");
#nullable restore
#line 107 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
__builder.AddContent(99, parityNames[parity]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n\t\t\t");
            __builder.OpenComponent<global::BlazorServer.Shared.LessonSchedule.LessonScheduleTable>(101);
            __builder.AddAttribute(102, "invertParity", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 110 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
                                               invertParity

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(103, "weekParity", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 110 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
                                                                        parity

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(104, "lessons", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.List<BlazorServer.Data.LessonFromSchedule>>(
#nullable restore
#line 110 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
                                                                                        lessons

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(105, "dayOfWeek", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 110 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
                                                                                                           dayOfWeek

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.OpenElement(106, "div");
            __builder.AddAttribute(107, "class", "p-2");
            __builder.AddMarkupContent(108, "<h5>Orarul sunetelor</h5>\r\n\t\t\t");
            __builder.OpenComponent<global::BlazorServer.Shared.LessonSchedule.LessonDurationsTable>(109);
            __builder.AddAttribute(110, "lessonDurations", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.List<BlazorServer.Data.LessonDuration>>(
#nullable restore
#line 115 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
                                                   lessonDurations

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 117 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
	}
	else if (tab == "5days")
	{
		n = 0;
		day_5days = 0;
		temDateTime = dtNow;

		

#line default
#line hidden
#nullable disable
#nullable restore
#line 124 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
         while (day_5days < 5)
		{
			temDateTime = temDateTime.AddDays(1);
			dayOfWeek = GetDayOfWeek(temDateTime);

			

#line default
#line hidden
#nullable disable
#nullable restore
#line 129 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
             if (dayOfWeek != (int)NormalDayOfWeek.Saturday && dayOfWeek != (int)NormalDayOfWeek.Sunday)
			{
				day_5days++;
				parity = GetParityOfWeek(temDateTime);


#line default
#line hidden
#nullable disable
            __builder.OpenElement(111, "div");
            __builder.AddAttribute(112, "class", "p-2");
            __builder.OpenElement(113, "div");
            __builder.AddAttribute(114, "class", "d-flex");
            __builder.AddAttribute(115, "style", "margin-bottom: -1px;");
            __builder.OpenElement(116, "div");
            __builder.AddAttribute(117, "class", "p-1 pl-2 pr-2 bg-dark text-white");
            __builder.OpenElement(118, "span");
            __builder.AddAttribute(119, "class", "text-warning");
#nullable restore
#line 137 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
__builder.AddContent(120, weekDayNames[dayOfWeek]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddContent(121, " ");
#nullable restore
#line 137 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
__builder.AddContent(122, temDateTime.Day);

#line default
#line hidden
#nullable disable
            __builder.AddContent(123, " ");
#nullable restore
#line 137 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
__builder.AddContent(124, monthNames[temDateTime.Month - 1]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n\t\t\t\t\t\t");
            __builder.OpenElement(126, "div");
            __builder.AddAttribute(127, "class", "ml-1 align-self-end");
            __builder.AddMarkupContent(128, "\r\n\t\t\t\t\t\t\tIn săptămână ");
            __builder.OpenElement(129, "span");
            __builder.AddAttribute(130, "class", "text-primary");
#nullable restore
#line 140 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
__builder.AddContent(131, parityNames[parity]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\r\n\t\t\t\t\t");
            __builder.OpenComponent<global::BlazorServer.Shared.LessonSchedule.LessonScheduleTable>(133);
            __builder.AddAttribute(134, "invertParity", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 143 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
                                                       invertParity

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(135, "weekParity", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 143 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
                                                                                parity

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(136, "lessons", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.List<BlazorServer.Data.LessonFromSchedule>>(
#nullable restore
#line 143 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
                                                                                                lessons

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(137, "dayOfWeek", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 143 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
                                                                                                                   dayOfWeek

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 145 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
			}

#line default
#line hidden
#nullable disable
#nullable restore
#line 145 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
             

			n++;
		}

#line default
#line hidden
#nullable disable
#nullable restore
#line 148 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
         
	}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 152 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
  /* WARNING: Delete for relese. */

#line default
#line hidden
#nullable disable
#nullable restore
#line 153 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
__builder.AddContent(138, LiveSchedule.dtNow.ToString());

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(139, "\r\n");
#nullable restore
#line 154 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
__builder.AddContent(140, LiveSchedule.SleepDelay);

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 156 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Orar.razor"
       
	[Parameter] public string tab { get; set; }
	private List<LessonFromSchedule> lessons;
	private List<LessonDuration> lessonDurations;
	private bool invertParity = false;
	private string[] weekDayNames = new string [] { "Luni", "Marți", "Miercuri", "Joi", "Vineri", "Sambătă", "Duminică"};
	private string[] monthNames = new string [] { "ianuarie", "februarie", "martie", "aprilie", "mai", "iunie", "iulie", "august", "septembrie", "octombrie", "noiembrie", "decembrie"};
	private string[] parityNames = new string[] { "pară", "impară" };
	private DateTime dtNow;
	private DateTime temDateTime;  //Este utilizata pentru codul din partea cu html
	private int dayOfWeek;
	private int parity;
	private int day_5days;
	private int n;
	private int i;

	protected override void OnInitialized()
	{
		tab = tab ?? "principal";

		dtNow = LiveSchedule.dtNow;

		lessonDurations = LiveSchedule.LessonDurations;
		lessons = LiveSchedule.AllLessons;
		invertParity = LiveSchedule.InvertParity;
	}

	private string ReloadRenderPage(int delay)
	{
		Task.Run(async () => { await Task.Delay(delay); await InvokeAsync(() => StateHasChanged());});
		return "";
	}

	private int GetDayOfWeek(DateTime dt)
	{
		int day = (int)dt.DayOfWeek;
		return  day > 0 ? day - 1 : 6;
	}

	private int GetParityOfWeek(DateTime dt)
	{
		int weekParity = ISOWeek.GetWeekOfYear(dt) % 2;
		if (invertParity)
		{
			weekParity = weekParity == 0 ? 1 : 0;
		}
		return weekParity;
	}

	private string CheckNavLinkState(string name)
	{
		if (name == tab)
		{
			return "active";
		}
		return "";
	}

	private DateTime GetTomorrowDay()
	{
		int delta = 1;
		if (GetDayOfWeek(dtNow) == 5)
		{
			delta = 2;
		}
		if (GetDayOfWeek(dtNow) == 4)
		{
			delta = 3;
		}

		DateTime _dtNow = dtNow;
		return _dtNow.AddDays(delta);
	}

	private DateTime GetYesterdayDay()
	{
		int delta = -1;
		if (GetDayOfWeek(dtNow) == 6)
		{
			delta = -2;
		}
		else if (GetDayOfWeek(dtNow) == 0)
		{
			delta = -3;
		}

		DateTime _dtNow = dtNow;
		return _dtNow.AddDays(delta);
	}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Data.UserData UData { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Data.LiveSchedule LiveSchedule { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DBLibrary.IDataBaseAcces dbAcces { get; set; }
    }
}
#pragma warning restore 1591
