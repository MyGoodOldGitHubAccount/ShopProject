#pragma checksum "C:\.NET\ShopProject\Views\Basket\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fe10f9195ff749a0a4cc5a75f4bf2e8d1314b7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Basket_Show), @"mvc.1.0.view", @"/Views/Basket/Show.cshtml")]
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
#nullable restore
#line 1 "C:\.NET\ShopProject\Views\_ViewImports.cshtml"
using ShopProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\.NET\ShopProject\Views\_ViewImports.cshtml"
using ShopProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\.NET\ShopProject\Views\_ViewImports.cshtml"
using ShopProject.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\.NET\ShopProject\Views\_ViewImports.cshtml"
using ShopProject.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\.NET\ShopProject\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fe10f9195ff749a0a4cc5a75f4bf2e8d1314b7a", @"/Views/Basket/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ddfd98410ea69ad1fcd1a5995f99fbebd9a5585", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Basket_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BasketViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\.NET\ShopProject\Views\Basket\Show.cshtml"
 if (Model.AmountOfGoods != 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""container"">
        <div class=""row"">
            <div class=""col-8"">

                <table class=""table table-bordered"">
                    <thead>
                        Goods in order
                    </thead>
                    <tr>
                        <th>
                            Name
                        </th>
                        <th>
                            Price
                        </th>
                        <th>
                            Amount
                        </th>
                        <th>
                            Price for all instances
                        </th>
                    </tr>

");
#nullable restore
#line 28 "C:\.NET\ShopProject\Views\Basket\Show.cshtml"
                     for (int i = 0; i < Model.AmountOfGoods; i++)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n\r\n                                <td> ");
#nullable restore
#line 33 "C:\.NET\ShopProject\Views\Basket\Show.cshtml"
                                Write(Model.GoodNames[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 34 "C:\.NET\ShopProject\Views\Basket\Show.cshtml"
                               Write(Model.GoodPrices[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td> ");
#nullable restore
#line 35 "C:\.NET\ShopProject\Views\Basket\Show.cshtml"
                                Write(Model.GoodAmounts[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td> ");
#nullable restore
#line 36 "C:\.NET\ShopProject\Views\Basket\Show.cshtml"
                                Write(Model.SumOfGoods[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                               \r\n\r\n\r\n                            </tr>\r\n");
#nullable restore
#line 42 "C:\.NET\ShopProject\Views\Basket\Show.cshtml"
                        
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </table>\r\n\r\n            </div>\r\n           \r\n        </div>\r\n        <div class=\"text-md-center\"> Total Sum: ");
#nullable restore
#line 50 "C:\.NET\ShopProject\Views\Basket\Show.cshtml"
                                           Write(Model.TotalSum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n       \r\n    </div>\r\n");
#nullable restore
#line 53 "C:\.NET\ShopProject\Views\Basket\Show.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1> EMPTY :(</h1>\r\n");
#nullable restore
#line 57 "C:\.NET\ShopProject\Views\Basket\Show.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BasketViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
