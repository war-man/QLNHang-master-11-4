#pragma checksum "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Shared\Components\SaleOffHome\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ec2cd6f94e66ca8b9d2985c5dd9f0f932ceb15d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SaleOffHome_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SaleOffHome/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/SaleOffHome/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_SaleOffHome_Default))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\_ViewImports.cshtml"
using WebApplication8;

#line default
#line hidden
#line 2 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\_ViewImports.cshtml"
using WebApplication8.Models;

#line default
#line hidden
#line 3 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\_ViewImports.cshtml"
using WebApplication8.Models.AccountViewModels;

#line default
#line hidden
#line 4 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\_ViewImports.cshtml"
using WebApplication8.Models.ManageViewModels;

#line default
#line hidden
#line 5 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 6 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#line 7 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#line 8 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\_ViewImports.cshtml"
using WebApplication8.Models.IdentityModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ec2cd6f94e66ca8b9d2985c5dd9f0f932ceb15d", @"/Views/Shared/Components/SaleOffHome/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9902d642f80e647e7edd6b1baa8f080cbac5746b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_SaleOffHome_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication8.Models.WebShop.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(60, 212, true);
            WriteLiteral("<!-- ============================================== SPECIAL OFFER ============================================== -->\r\n\r\n<div class=\"sidebar-widget outer-bottom-small wow fadeInUp\">\r\n    <h3 class=\"section-title\">");
            EndContext();
            BeginContext(273, 17, false);
#line 5 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Shared\Components\SaleOffHome\Default.cshtml"
                         Write(Global["SaleOff"]);

#line default
#line hidden
            EndContext();
            BeginContext(290, 61, true);
            WriteLiteral("</h3>\r\n\r\n    <div class=\"sidebar-widget-body outer-top-xs\">\r\n");
            EndContext();
#line 9 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Shared\Components\SaleOffHome\Default.cshtml"
         foreach (var p in Model)
            {

#line default
#line hidden
            BeginContext(511, 486, true);
            WriteLiteral(@"            <div class=""item"">
                <div class=""products special-product"">
                    <div class=""product"">
                        <div class=""product-micro"">
                            <div class=""row product-micro-row"">
                                <div class=""col col-xs-5"">
                                    <div class=""product-image"">
                                        <div class=""border-box"">
                                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 997, "\"", 1041, 2);
            WriteAttributeValue("", 1004, "/Content/img/products/images/", 1004, 29, true);
#line 19 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Shared\Components\SaleOffHome\Default.cshtml"
WriteAttributeValue("", 1033, p.Image, 1033, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1042, 107, true);
            WriteLiteral(" data-lightbox=\"image-1\" data-title=\"Nunc ullamcors\">\r\n                                                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1149, "\"", 1192, 2);
            WriteAttributeValue("", 1155, "/Content/img/products/images/", 1155, 29, true);
#line 20 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Shared\Components\SaleOffHome\Default.cshtml"
WriteAttributeValue("", 1184, p.Image, 1184, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1193, 30, true);
            WriteLiteral(" alt=\"\" class=\"img-responsive\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1223, "\"", 1233, 1);
#line 20 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Shared\Components\SaleOffHome\Default.cshtml"
WriteAttributeValue("", 1228, p.Id, 1228, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1234, 693, true);
            WriteLiteral(@">
                                                <div class=""zoom-overlay""></div>
                                            </a>
                                        </div><!-- /.image -->
                                        <div class=""tag tag-micro sale"">
                                            <span>sale</span>
                                        </div>


                                    </div><!-- /.product-image -->
                                </div><!-- /.col -->
                                <div class=""col col-xs-7"">
                                    <div class=""product-info"">
                                        <h3 class=""name""><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1927, "\"", 1963, 4);
            WriteAttributeValue("", 1934, "/Product/Detail/", 1934, 16, true);
#line 33 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Shared\Components\SaleOffHome\Default.cshtml"
WriteAttributeValue("", 1950, p.Id, 1950, 5, false);

#line default
#line hidden
            WriteAttributeValue("", 1955, "/", 1955, 1, true);
#line 33 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Shared\Components\SaleOffHome\Default.cshtml"
WriteAttributeValue("", 1956, p.Name, 1956, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1964, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1966, 6, false);
#line 33 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Shared\Components\SaleOffHome\Default.cshtml"
                                                                                            Write(p.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1972, 295, true);
            WriteLiteral(@"</a></h3>
                                        <div class=""rating rateit-small hidden""></div>
                                        <div class=""product-price"">
                                            <span class=""price numeral-init"">
                                                ");
            EndContext();
            BeginContext(2268, 37, false);
#line 37 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Shared\Components\SaleOffHome\Default.cshtml"
                                           Write(Html.Raw(p.PriceP * (1 - p.Discount)));

#line default
#line hidden
            EndContext();
            BeginContext(2305, 55, true);
            WriteLiteral("\r\n                                            </span>\r\n");
            EndContext();
#line 39 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Shared\Components\SaleOffHome\Default.cshtml"
                                             if (p.Discount > 0)
                                            {

#line default
#line hidden
            BeginContext(2473, 97, true);
            WriteLiteral("                                                <span class=\"price-before-discount numeral-init\">");
            EndContext();
            BeginContext(2571, 8, false);
#line 41 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Shared\Components\SaleOffHome\Default.cshtml"
                                                                                            Write(p.PriceP);

#line default
#line hidden
            EndContext();
            BeginContext(2579, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 42 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Shared\Components\SaleOffHome\Default.cshtml"

                                            }

#line default
#line hidden
            BeginContext(2637, 183, true);
            WriteLiteral("                                        </div><!-- /.product-price -->\r\n                                        <div class=\"action\"><a href=\"javascript:void(0);\" data-urlpartialcart=\"");
            EndContext();
            BeginContext(2821, 65, false);
#line 45 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Shared\Components\SaleOffHome\Default.cshtml"
                                                                                                          Write(Url.RouteUrl(new { controller = "Cart", action = "PartialCart" }));

#line default
#line hidden
            EndContext();
            BeginContext(2886, 84, true);
            WriteLiteral("\"\r\n                                                                data-urladdcart=\"");
            EndContext();
            BeginContext(2971, 51, false);
#line 46 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Shared\Components\SaleOffHome\Default.cshtml"
                                                                            Write(Url.RouteUrl(new {controller="Cart",action="Add" }));

#line default
#line hidden
            EndContext();
            BeginContext(3022, 115, true);
            WriteLiteral("\" class=\"lnk btn btn-primary addProduct\"\r\n                                                                data-id=\"");
            EndContext();
            BeginContext(3138, 4, false);
#line 47 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Shared\Components\SaleOffHome\Default.cshtml"
                                                                    Write(p.Id);

#line default
#line hidden
            EndContext();
            BeginContext(3142, 13, true);
            WriteLiteral("\" data-name=\"");
            EndContext();
            BeginContext(3156, 6, false);
#line 47 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Shared\Components\SaleOffHome\Default.cshtml"
                                                                                      Write(p.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3162, 344, true);
            WriteLiteral(@""">Thêm vào giỏ</a></div>
                                    </div>
                                </div><!-- /.col -->
                            </div><!-- /.product-micro-row -->
                        </div><!-- /.product-micro -->

                    </div> <!--end of product-->


                </div>
            </div>
");
            EndContext();
#line 58 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Shared\Components\SaleOffHome\Default.cshtml"
        }

#line default
#line hidden
            BeginContext(3517, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(3535, 205, true);
            WriteLiteral("\r\n\r\n    </div><!-- /.sidebar-widget-body -->\r\n\r\n</div><!-- /.sidebar-widget -->\r\n<!-- ============================================== SPECIAL OFFER : END ============================================== -->\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public CustomerIdentity CustomerIdentity { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Global { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication8.Models.WebShop.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
