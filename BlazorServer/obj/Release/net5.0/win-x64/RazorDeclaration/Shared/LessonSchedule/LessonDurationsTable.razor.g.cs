// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 1 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Shared\LessonSchedule\LessonDurationsTable.razor"
using Data;

#line default
#line hidden
#nullable disable
    public partial class LessonDurationsTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Shared\LessonSchedule\LessonDurationsTable.razor"
       
	[Parameter] public List<LessonDuration> lessonDurations { get; set; }

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


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
