#pragma checksum "D:\visual studio\Веб-приложение\Blazor Приложения\Jewerly\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8d40c48028da3bcc03406db5819cb588e3612d2"
// <auto-generated/>
#pragma warning disable 1591
namespace Jewerly.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\visual studio\Веб-приложение\Blazor Приложения\Jewerly\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\visual studio\Веб-приложение\Blazor Приложения\Jewerly\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\visual studio\Веб-приложение\Blazor Приложения\Jewerly\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\visual studio\Веб-приложение\Blazor Приложения\Jewerly\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\visual studio\Веб-приложение\Blazor Приложения\Jewerly\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\visual studio\Веб-приложение\Blazor Приложения\Jewerly\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\visual studio\Веб-приложение\Blazor Приложения\Jewerly\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\visual studio\Веб-приложение\Blazor Приложения\Jewerly\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\visual studio\Веб-приложение\Blazor Приложения\Jewerly\_Imports.razor"
using Jewerly.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\visual studio\Веб-приложение\Blazor Приложения\Jewerly\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\visual studio\Веб-приложение\Blazor Приложения\Jewerly\_Imports.razor"
using Jewerly.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\visual studio\Веб-приложение\Blazor Приложения\Jewerly\_Imports.razor"
using Jewerly.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\visual studio\Веб-приложение\Blazor Приложения\Jewerly\_Imports.razor"
using Jewerly;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\visual studio\Веб-приложение\Blazor Приложения\Jewerly\_Imports.razor"
using Npgsql;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddAttribute(2, "b-hd8auoaqux");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href b-hd8auoaqux>Jewerly</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "D:\visual studio\Веб-приложение\Blazor Приложения\Jewerly\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "b-hd8auoaqux");
            __builder.AddMarkupContent(8, "<span class=\"navbar-toggler-icon\" b-hd8auoaqux></span>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "D:\visual studio\Веб-приложение\Blazor Приложения\Jewerly\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
