#pragma checksum "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Shared\LessonSchedule\ScheduleTomorrow.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91cc0403eb76797918b7b186d085debc95d7352f"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorServer.Shared.LessonSchedule
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
#line 1 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Shared\LessonSchedule\ScheduleTomorrow.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Shared\LessonSchedule\ScheduleTomorrow.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
    public partial class ScheduleTomorrow : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Shared\LessonSchedule\ScheduleTomorrow.razor"
__builder.AddContent(0, dtNow.ToString());

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, ";\r\n\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Shared\LessonSchedule\ScheduleTomorrow.razor"
       
	private DateTime dtNow;
	protected override void OnInitialized()
	{
		TimeZoneInfo cstZone = TimeZoneInfo.FindSystemTimeZoneById("GTB Standard Time");
		dtNow = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, cstZone);
		int weekOfYear = ISOWeek.GetWeekOfYear(dtNow);
	}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
