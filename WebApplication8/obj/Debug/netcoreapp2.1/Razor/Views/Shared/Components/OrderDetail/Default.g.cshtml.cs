#pragma checksum "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Views\Shared\Components\OrderDetail\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e6f12d57bed78bd2c985e0184d3493050e04cbe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_OrderDetail_Default), @"mvc.1.0.view", @"/Views/Shared/Components/OrderDetail/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/OrderDetail/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_OrderDetail_Default))]
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
#line 1 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Views\_ViewImports.cshtml"
using WebApplication8;

#line default
#line hidden
#line 2 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Views\_ViewImports.cshtml"
using WebApplication8.Models;

#line default
#line hidden
#line 3 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Views\_ViewImports.cshtml"
using WebApplication8.Models.AccountViewModels;

#line default
#line hidden
#line 4 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Views\_ViewImports.cshtml"
using WebApplication8.Models.ManageViewModels;

#line default
#line hidden
#line 5 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 6 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#line 7 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#line 8 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Views\_ViewImports.cshtml"
using WebApplication8.Models.IdentityModels;

#line default
#line hidden
#line 2 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Views\Shared\Components\OrderDetail\Default.cshtml"
using WebApplication8.Models.ShoppingCart;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e6f12d57bed78bd2c985e0184d3493050e04cbe", @"/Views/Shared/Components/OrderDetail/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0a3fafe41e76a33d850d2ac657d18b4d78f4541", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_OrderDetail_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication8.Models.WebShop.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(103, 206, true);
            WriteLiteral("\n<table class=\"table table-striped\">\n    <tr>\n        <th>Id</th>\n        <th>Tên Sản phẩm</th>\n        <th>Giá </th>\n        <th>Discount</th>\n        <th>Số lượng</th>\n        <th>Giá trị</th>\n\n    </tr>\n");
            EndContext();
#line 14 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Views\Shared\Components\OrderDetail\Default.cshtml"
     foreach (var p in Model)
    {

#line default
#line hidden
            BeginContext(345, 29, true);
            WriteLiteral("        <tr>\n            <td>");
            EndContext();
            BeginContext(375, 4, false);
#line 17 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Views\Shared\Components\OrderDetail\Default.cshtml"
           Write(p.Id);

#line default
#line hidden
            EndContext();
            BeginContext(379, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(402, 6, false);
#line 18 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Views\Shared\Components\OrderDetail\Default.cshtml"
           Write(p.Name);

#line default
#line hidden
            EndContext();
            BeginContext(408, 49, true);
            WriteLiteral("</td>\n            <td><span class=\"numeral-init\">");
            EndContext();
            BeginContext(458, 8, false);
#line 19 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Views\Shared\Components\OrderDetail\Default.cshtml"
                                      Write(p.PriceP);

#line default
#line hidden
            EndContext();
            BeginContext(466, 29, true);
            WriteLiteral("</span></td>\n            <td>");
            EndContext();
            BeginContext(496, 24, false);
#line 20 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Views\Shared\Components\OrderDetail\Default.cshtml"
           Write(Html.Raw(p.Discount*100));

#line default
#line hidden
            EndContext();
            BeginContext(520, 45, true);
            WriteLiteral("</td>\n            <td><input class=\"quantity\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 565, "\"", 584, 1);
#line 21 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Views\Shared\Components\OrderDetail\Default.cshtml"
WriteAttributeValue("", 573, p.Quantity, 573, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(585, 10, true);
            WriteLiteral(" data-id=\"");
            EndContext();
            BeginContext(596, 4, false);
#line 21 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Views\Shared\Components\OrderDetail\Default.cshtml"
                                                                Write(p.Id);

#line default
#line hidden
            EndContext();
            BeginContext(600, 10, true);
            WriteLiteral("\" size=\"3\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 610, "\"", 623, 2);
#line 21 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Views\Shared\Components\OrderDetail\Default.cshtml"
WriteAttributeValue("", 615, p.Id, 615, 5, false);

#line default
#line hidden
            WriteAttributeValue("", 620, "-ss", 620, 3, true);
            EndWriteAttribute();
            BeginContext(624, 24, true);
            WriteLiteral(" /></td>\n            <td");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 648, "\"", 658, 1);
#line 22 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Views\Shared\Components\OrderDetail\Default.cshtml"
WriteAttributeValue("", 653, p.Id, 653, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(659, 28, true);
            WriteLiteral("><span class=\"numeral-init\">");
            EndContext();
            BeginContext(688, 50, false);
#line 22 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Views\Shared\Components\OrderDetail\Default.cshtml"
                                                 Write(Html.Raw(p.PriceP * p.Quantity * (1 - p.Discount)));

#line default
#line hidden
            EndContext();
            BeginContext(738, 28, true);
            WriteLiteral("</span></td>\n\n        </tr>\n");
            EndContext();
#line 25 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Views\Shared\Components\OrderDetail\Default.cshtml"
    }

#line default
#line hidden
            BeginContext(772, 131, true);
            WriteLiteral("    <tr>\n        <th colspan=\"5\" style=\"text-align:right\">Total:</th>\n        <th class=\"nn-cart-total\"><span class=\"numeral-init\">");
            EndContext();
            BeginContext(904, 18, false);
#line 28 "C:\Users\tien\Downloads\Compressed\QLNHang-master\QLNHang-master\WebApplication8\Views\Shared\Components\OrderDetail\Default.cshtml"
                                                        Write(ShoppingCart.Total);

#line default
#line hidden
            EndContext();
            BeginContext(922, 36, true);
            WriteLiteral("</span></th>\n\n    </tr>\n</table>\n\n\n\n");
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