#pragma checksum "D:\visual studio\Веб-приложение\Blazor Приложения\Jewerly\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99c71e79c977db72c0f613da1b885de3beab6d9d"
// <auto-generated/>
#pragma warning disable 1591
namespace Jewerly.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Добро пожаловать в Ювелюрную мастерскую!</h1>\r\n\r\nЭто привественная страница.\r\n\r\n");
            __builder.OpenComponent<Jewerly.Shared.SurveyPrompt>(1);
            __builder.AddAttribute(2, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
