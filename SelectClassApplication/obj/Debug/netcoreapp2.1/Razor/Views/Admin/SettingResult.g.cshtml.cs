#pragma checksum "E:\StudentSelectClassSystem\SelectClassApplication\Views\Admin\SettingResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b175505f54e9703237011f1da4ae9fe66297de02"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_SettingResult), @"mvc.1.0.view", @"/Views/Admin/SettingResult.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/SettingResult.cshtml", typeof(AspNetCore.Views_Admin_SettingResult))]
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
#line 1 "E:\StudentSelectClassSystem\SelectClassApplication\Views\_ViewImports.cshtml"
using SelectClassApplication;

#line default
#line hidden
#line 2 "E:\StudentSelectClassSystem\SelectClassApplication\Views\_ViewImports.cshtml"
using SelectClassApplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b175505f54e9703237011f1da4ae9fe66297de02", @"/Views/Admin/SettingResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb52c2f572b921410e3ad1814d08c49d20b1c9fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_SettingResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\StudentSelectClassSystem\SelectClassApplication\Views\Admin\SettingResult.cshtml"
  
    var title = ViewBag.Title;
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(88, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(95, 5, false);
#line 7 "E:\StudentSelectClassSystem\SelectClassApplication\Views\Admin\SettingResult.cshtml"
Write(title);

#line default
#line hidden
            EndContext();
            BeginContext(100, 9, true);
            WriteLiteral("</h2>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
