#pragma checksum "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6dc4bcde342596ef03aec4dfbb52b748e87114f1"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Login.razor"
 if (!UData.IsLoged)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "form-group");
            __builder.AddMarkupContent(3, "<label for=\"InputUserName\">Numele de utilizator</label>\r\n            ");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "type", "text");
            __builder.AddAttribute(6, "class", "form-control");
            __builder.AddAttribute(7, "id", "InputUserName");
            __builder.AddAttribute(8, "aria-describedby", "UserNameHelp");
            __builder.AddAttribute(9, "placeholder", "Introduceți numele de utilizator");
            __builder.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Login.razor"
                                                                                                                                                             UserName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => UserName = __value, UserName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.AddMarkupContent(13, "<small id=\"UserNameHelp\" class=\"form-text text-danger\">Introduceți aici numele și prenumele fără semne diacritice.</small>");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "form-group");
            __builder.AddMarkupContent(17, "<label for=\"InputPassword\">Parola</label>\r\n            ");
            __builder.OpenElement(18, "input");
            __builder.AddAttribute(19, "type", "password");
            __builder.AddAttribute(20, "class", "form-control");
            __builder.AddAttribute(21, "id", "InputPassword");
            __builder.AddAttribute(22, "placeholder", "Introduceți parola");
            __builder.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Login.razor"
                                                                                                                   Password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Password = __value, Password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "class", "btn btn-primary");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Login.razor"
                                                  CheckAccount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(29, "Autentifică");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 18 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Login.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(30, "<div class=\"alert alert-success\" role=\"alert\">\r\n        V-ați autentificat cu succes.\r\n    </div>");
#nullable restore
#line 24 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Login.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Login.razor"
 if (error == true)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(31, "<div class=\"alert alert-danger mt-3\" role=\"alert\">\r\n        Parola sau numele de utilizator pot fi incorect.\r\n    </div>");
#nullable restore
#line 31 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Login.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Personal\Programare\C#\Site TT-0119\BlazorServer\Pages\Login.razor"
       
    private string UserName { get; set; }
    private string Password { get; set; }
    private bool error { get; set; }

    private async void CheckAccount()
    {
        error = await UData.TryToLogin(UserName, Password);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Data.UserData UData { get; set; }
    }
}
#pragma warning restore 1591
