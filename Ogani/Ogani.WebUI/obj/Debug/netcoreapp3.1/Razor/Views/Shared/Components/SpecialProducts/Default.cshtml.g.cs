#pragma checksum "D:\code\Lessons\OganiApiProjectFromMacInWindows\Ogani\Ogani.WebUI\Views\Shared\Components\SpecialProducts\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0790b2867b53ac0ccb7474db203422dac6ec25b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Ogani.WebUI.Views.Shared.Components.SpecialProducts.Views_Shared_Components_SpecialProducts_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SpecialProducts/Default.cshtml")]
namespace Ogani.WebUI.Views.Shared.Components.SpecialProducts
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
#line 2 "D:\code\Lessons\OganiApiProjectFromMacInWindows\Ogani\Ogani.WebUI\Views\_ViewImports.cshtml"
using Ogani.Application.Models.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\code\Lessons\OganiApiProjectFromMacInWindows\Ogani\Ogani.WebUI\Views\_ViewImports.cshtml"
using Ogani.WebUI.Models.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\code\Lessons\OganiApiProjectFromMacInWindows\Ogani\Ogani.WebUI\Views\_ViewImports.cshtml"
using Ogani.WebUI.AppCode.Types;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\code\Lessons\OganiApiProjectFromMacInWindows\Ogani\Ogani.WebUI\Views\_ViewImports.cshtml"
using Ogani.WebUI.Models.DataContext;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\code\Lessons\OganiApiProjectFromMacInWindows\Ogani\Ogani.WebUI\Views\_ViewImports.cshtml"
using Ogani.Application.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\code\Lessons\OganiApiProjectFromMacInWindows\Ogani\Ogani.WebUI\Views\_ViewImports.cshtml"
using Resource;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0790b2867b53ac0ccb7474db203422dac6ec25b", @"/Views/Shared/Components/SpecialProducts/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2836519ccc3a4002f974a14ea30bbf63497b9926", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_SpecialProducts_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("latest-product-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\code\Lessons\OganiApiProjectFromMacInWindows\Ogani\Ogani.WebUI\Views\Shared\Components\SpecialProducts\Default.cshtml"
  
    int count = 0;
    int forCount = 1;
    int length = Model.Count();
    int lengthColumn = (int)Math.Ceiling(length / 3.0);

    if (length > 3)
    {
        length = 3;
    }
    Product p;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 15 "D:\code\Lessons\OganiApiProjectFromMacInWindows\Ogani\Ogani.WebUI\Views\Shared\Components\SpecialProducts\Default.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>");
#nullable restore
#line 17 "D:\code\Lessons\OganiApiProjectFromMacInWindows\Ogani\Ogani.WebUI\Views\Shared\Components\SpecialProducts\Default.cshtml"
   Write(ViewBag.CardTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <div class=\"latest-product-slider owl-carousel owl-loaded owl-drag\">\r\n");
#nullable restore
#line 19 "D:\code\Lessons\OganiApiProjectFromMacInWindows\Ogani\Ogani.WebUI\Views\Shared\Components\SpecialProducts\Default.cshtml"
         for (int i = 0; i < lengthColumn; i++)
        {
            {
                if (length - (i * 3) > 3)
                {
                    forCount = 3;
                }
                else
                {
                    forCount = length - (i * 3);
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"latest-prdouct-slider-item\">\r\n\r\n");
#nullable restore
#line 33 "D:\code\Lessons\OganiApiProjectFromMacInWindows\Ogani\Ogani.WebUI\Views\Shared\Components\SpecialProducts\Default.cshtml"
                 for (int j = 0; j < length; j++)
                {
                    {
                        p = Model.ElementAt(count++);
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0790b2867b53ac0ccb7474db203422dac6ec25b7220", async() => {
                WriteLiteral("\r\n                        <div class=\"latest-product-item-pic\">\r\n                            <img");
                BeginWriteAttribute("src", " src=\"", 1131, "\"", 1211, 2);
                WriteAttributeValue("", 1137, "/uploads/images/products/", 1137, 25, true);
#nullable restore
#line 40 "D:\code\Lessons\OganiApiProjectFromMacInWindows\Ogani\Ogani.WebUI\Views\Shared\Components\SpecialProducts\Default.cshtml"
WriteAttributeValue("", 1162, p.Images?.FirstOrDefault(i=>i.IsMain)?.ImagePath, 1162, 49, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 1212, "\"", 1225, 1);
#nullable restore
#line 40 "D:\code\Lessons\OganiApiProjectFromMacInWindows\Ogani\Ogani.WebUI\Views\Shared\Components\SpecialProducts\Default.cshtml"
WriteAttributeValue("", 1218, p.Name, 1218, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        </div>\r\n                        <div class=\"latest-product-item-text\">\r\n                            <h6>");
#nullable restore
#line 43 "D:\code\Lessons\OganiApiProjectFromMacInWindows\Ogani\Ogani.WebUI\Views\Shared\Components\SpecialProducts\Default.cshtml"
                           Write(p.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                            <span>$");
#nullable restore
#line 44 "D:\code\Lessons\OganiApiProjectFromMacInWindows\Ogani\Ogani.WebUI\Views\Shared\Components\SpecialProducts\Default.cshtml"
                              Write(p.Price.ToString("0.##"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "D:\code\Lessons\OganiApiProjectFromMacInWindows\Ogani\Ogani.WebUI\Views\Shared\Components\SpecialProducts\Default.cshtml"
                                                                    WriteLiteral(p.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 47 "D:\code\Lessons\OganiApiProjectFromMacInWindows\Ogani\Ogani.WebUI\Views\Shared\Components\SpecialProducts\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n");
#nullable restore
#line 49 "D:\code\Lessons\OganiApiProjectFromMacInWindows\Ogani\Ogani.WebUI\Views\Shared\Components\SpecialProducts\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 51 "D:\code\Lessons\OganiApiProjectFromMacInWindows\Ogani\Ogani.WebUI\Views\Shared\Components\SpecialProducts\Default.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
