// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\LucLab.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\LucLab.razor"
using System.Net.NetworkInformation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\LucLab.razor"
using System.Net.Sockets;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/luc-lab")]
    public partial class LucLab : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\LucLab.razor"
       
	private int count = 0;
	private bool end = false;

	protected override async Task OnInitializedAsync()
	{
		Work();
		end = true;
	}

	//async void RunAsync()
	//{
	//	await Task.Run(async () => Work());
	//}

	async void Work()
	{
		while (true)
		{
			count++;
			StateHasChanged();
			await Task.Delay(1000);
		}
	}

	public string GetLocalIPv4(NetworkInterfaceType _type)
	{
		string output = "";
		foreach (NetworkInterface item in NetworkInterface.GetAllNetworkInterfaces())
		{
			if (item.NetworkInterfaceType == _type && item.OperationalStatus == OperationalStatus.Up)
			{
				foreach (UnicastIPAddressInformation ip in item.GetIPProperties().UnicastAddresses)
				{
					if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
					{
						output = ip.Address.ToString();
					}
				}
			}
		}
		return output;
	}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591