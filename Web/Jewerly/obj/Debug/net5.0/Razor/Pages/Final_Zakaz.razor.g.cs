#pragma checksum "D:\visual studio\Веб-приложение\Blazor Приложения\Jewerly\Pages\Final_Zakaz.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6c28eb8cb69465b396d04bb1c91994f28b8af54"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/final_zakaz")]
    public partial class Final_Zakaz : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudContainer>(0);
            __builder.AddAttribute(1, "Class", "mt-16");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudGrid>(3);
                __builder2.AddAttribute(4, "Class", "mt-8");
                __builder2.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudItem>(6);
                    __builder3.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudCard>(8);
                        __builder4.AddAttribute(9, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 9 "D:\visual studio\Веб-приложение\Blazor Приложения\Jewerly\Pages\Final_Zakaz.razor"
                                25

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudCardHeader>(11);
                            __builder5.AddAttribute(12, "CardHeaderContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudText>(13);
                                __builder6.AddAttribute(14, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 12 "D:\visual studio\Веб-приложение\Blazor Приложения\Jewerly\Pages\Final_Zakaz.razor"
                                       Typo.h5

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(15, "Align", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Align>(
#nullable restore
#line 12 "D:\visual studio\Веб-приложение\Blazor Приложения\Jewerly\Pages\Final_Zakaz.razor"
                                                       Align.Center

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddMarkupContent(17, "Ваше изделие");
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(18, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudCardContent>(19);
                            __builder5.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenElement(21, "div");
                                __builder6.OpenElement(22, "img");
                                __builder6.AddAttribute(23, "width", "490");
                                __builder6.AddAttribute(24, "height", "400");
                                __builder6.AddAttribute(25, "src", 
#nullable restore
#line 17 "D:\visual studio\Веб-приложение\Blazor Приложения\Jewerly\Pages\Final_Zakaz.razor"
                                                            spr.UrlPic

#line default
#line hidden
#nullable disable
                                );
                                __builder6.AddAttribute(26, "alt", "Изделие");
                                __builder6.CloseElement();
                                __builder6.CloseElement();
                                __builder6.AddMarkupContent(27, "\r\n                    <br>\r\n                    ");
                                __builder6.OpenComponent<MudBlazor.MudSelect<double>>(28);
                                __builder6.AddAttribute(29, "Label", "Размер");
                                __builder6.AddAttribute(30, "Strict", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 20 "D:\visual studio\Веб-приложение\Blazor Приложения\Jewerly\Pages\Final_Zakaz.razor"
                                                                                            true

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(31, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 20 "D:\visual studio\Веб-приложение\Blazor Приложения\Jewerly\Pages\Final_Zakaz.razor"
                                                                                                           Variant.Filled

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(32, "Format", "F2");
                                __builder6.AddAttribute(33, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<double>(
#nullable restore
#line 20 "D:\visual studio\Веб-приложение\Blazor Приложения\Jewerly\Pages\Final_Zakaz.razor"
                                                        selectedVal

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(34, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<double>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<double>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedVal = __value, selectedVal))));
                                __builder6.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
#nullable restore
#line 21 "D:\visual studio\Веб-приложение\Blazor Приложения\Jewerly\Pages\Final_Zakaz.razor"
                         for (double i = 15; i <= 20; i += 0.5)
                        {

#line default
#line hidden
#nullable disable
                                    __builder7.OpenComponent<MudBlazor.MudSelectItem<double>>(36);
                                    __builder7.AddAttribute(37, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<double>(
#nullable restore
#line 23 "D:\visual studio\Веб-приложение\Blazor Приложения\Jewerly\Pages\Final_Zakaz.razor"
                                                              i

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.CloseComponent();
#nullable restore
#line 24 "D:\visual studio\Веб-приложение\Blazor Приложения\Jewerly\Pages\Final_Zakaz.razor"
                        }

#line default
#line hidden
#nullable disable
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(38, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudCardActions>(39);
                            __builder5.AddAttribute(40, "Class", "d-flex justify-center");
                            __builder5.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudButton>(42);
                                __builder6.AddAttribute(43, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 29 "D:\visual studio\Веб-приложение\Blazor Приложения\Jewerly\Pages\Final_Zakaz.razor"
                                        Variant.Filled

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(44, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 29 "D:\visual studio\Веб-приложение\Blazor Приложения\Jewerly\Pages\Final_Zakaz.razor"
                                                               Color.Primary

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(45, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 29 "D:\visual studio\Веб-приложение\Blazor Приложения\Jewerly\Pages\Final_Zakaz.razor"
                                                                                    Size.Large

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(46, "Style", "width:50%;");
                                __builder6.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddMarkupContent(48, "Заказать");
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(49, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudItem>(50);
                    __builder3.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudCard>(52);
                        __builder4.AddAttribute(53, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 34 "D:\visual studio\Веб-приложение\Blazor Приложения\Jewerly\Pages\Final_Zakaz.razor"
                                25

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(54, "\r\n\r\n\r\n");
            __builder.OpenComponent<MudBlazor.MudThemeProvider>(55);
            __builder.AddAttribute(56, "Theme", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.MudTheme>(
#nullable restore
#line 42 "D:\visual studio\Веб-приложение\Blazor Приложения\Jewerly\Pages\Final_Zakaz.razor"
                         MyCustomTheme

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(57, "\r\n");
            __builder.OpenComponent<MudBlazor.MudDialogProvider>(58);
            __builder.CloseComponent();
            __builder.AddMarkupContent(59, "\r\n");
            __builder.OpenComponent<MudBlazor.MudSnackbarProvider>(60);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "D:\visual studio\Веб-приложение\Blazor Приложения\Jewerly\Pages\Final_Zakaz.razor"
       

    MudTheme MyCustomTheme = new MudTheme()
    {
        Palette = new Palette()
        {
            Primary = Colors.Grey.Darken4,
            //Error = Colors.Blue.Darken1,
            Dark = Colors.Shades.White,
        },

        LayoutProperties = new LayoutProperties()
        {
            DrawerWidthLeft = "260px",
            DrawerWidthRight = "300px"
        }
    }; //цвета
    public IzdelieSpr spr = Conf_Osobenn.selectedIzd;
    double selectedVal; //выбранный размер
    public Izdelie izdel = new Izdelie();
    private void Price_shet()
    {
        //izdel.Razmer = selectedVal; //он выбирает размер и сразу справа появляет цена посчитанныая и возможность нажать на заказ
        
        
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IzdelieService Service { get; set; }
    }
}
#pragma warning restore 1591
