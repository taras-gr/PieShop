#pragma checksum "C:\Users\Taras_Hrytsenko\Desktop\PieShop\MvcPS\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb55ef1a2c2e43c6232158ba303e52bf3272ea4c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Details.cshtml", typeof(AspNetCore.Views_Home_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb55ef1a2c2e43c6232158ba303e52bf3272ea4c", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MvcPS.Models.Pie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(25, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(32, 10, false);
#line 3 "C:\Users\Taras_Hrytsenko\Desktop\PieShop\MvcPS\Views\Home\Details.cshtml"
Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(42, 42, true);
            WriteLiteral("</h2>\r\n\r\n<div class=\"thumbnail\">\r\n    <img");
            EndContext();
            BeginWriteAttribute("alt", " alt=\"", 84, "\"", 101, 1);
#line 6 "C:\Users\Taras_Hrytsenko\Desktop\PieShop\MvcPS\Views\Home\Details.cshtml"
WriteAttributeValue("", 90, Model.Name, 90, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 102, "\"", 123, 1);
#line 6 "C:\Users\Taras_Hrytsenko\Desktop\PieShop\MvcPS\Views\Home\Details.cshtml"
WriteAttributeValue("", 108, Model.ImageUrl, 108, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(124, 118, true);
            WriteLiteral(" />\r\n    <div class=\"caption-full\">\r\n        <h3>\r\n            <a href=\"#\">Model.Name</a>\r\n        </h3>\r\n        <h4>");
            EndContext();
            BeginContext(243, 22, false);
#line 11 "C:\Users\Taras_Hrytsenko\Desktop\PieShop\MvcPS\Views\Home\Details.cshtml"
       Write(Model.ShortDescription);

#line default
#line hidden
            EndContext();
            BeginContext(265, 18, true);
            WriteLiteral("</h4>\r\n        <p>");
            EndContext();
            BeginContext(284, 21, false);
#line 12 "C:\Users\Taras_Hrytsenko\Desktop\PieShop\MvcPS\Views\Home\Details.cshtml"
      Write(Model.LongDescription);

#line default
#line hidden
            EndContext();
            BeginContext(305, 26, true);
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MvcPS.Models.Pie> Html { get; private set; }
    }
}
#pragma warning restore 1591
