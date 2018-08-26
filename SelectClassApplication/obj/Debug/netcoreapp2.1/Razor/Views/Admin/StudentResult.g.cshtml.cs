#pragma checksum "E:\StudentSelectClassSystem\SelectClassApplication\Views\Admin\StudentResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70f2ac9e159e433a3f1041f8bc65c2d87f9a8c84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_StudentResult), @"mvc.1.0.view", @"/Views/Admin/StudentResult.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/StudentResult.cshtml", typeof(AspNetCore.Views_Admin_StudentResult))]
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
#line 1 "E:\StudentSelectClassSystem\SelectClassApplication\Views\Admin\StudentResult.cshtml"
using StudentSelectClassLibrary.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70f2ac9e159e433a3f1041f8bc65c2d87f9a8c84", @"/Views/Admin/StudentResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb52c2f572b921410e3ad1814d08c49d20b1c9fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_StudentResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\StudentSelectClassSystem\SelectClassApplication\Views\Admin\StudentResult.cshtml"
  
    var title = ViewBag.Title;
    List<TblStudent> students = ViewBag.students;
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(178, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(185, 5, false);
#line 8 "E:\StudentSelectClassSystem\SelectClassApplication\Views\Admin\StudentResult.cshtml"
Write(title);

#line default
#line hidden
            EndContext();
            BeginContext(190, 442, true);
            WriteLiteral(@"</h2>
<div class=""row col-xs-12"">
    <table class=""table"">
        <thead>
            <tr>
                <th>编号</th>
                <th>学号</th>
                <th>姓名</th>
                <th>性别</th>
                <th>生日</th>
                <th>院系</th>
                <th>专业</th>
                <th>班级</th>
                <th>密码</th>
                <th>操作</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 26 "E:\StudentSelectClassSystem\SelectClassApplication\Views\Admin\StudentResult.cshtml"
             foreach (var item in students)
            {

#line default
#line hidden
            BeginContext(692, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(731, 14, false);
#line 29 "E:\StudentSelectClassSystem\SelectClassApplication\Views\Admin\StudentResult.cshtml"
               Write(item.StudentId);

#line default
#line hidden
            EndContext();
            BeginContext(745, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(773, 15, false);
#line 30 "E:\StudentSelectClassSystem\SelectClassApplication\Views\Admin\StudentResult.cshtml"
               Write(item.StudentNum);

#line default
#line hidden
            EndContext();
            BeginContext(788, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(816, 16, false);
#line 31 "E:\StudentSelectClassSystem\SelectClassApplication\Views\Admin\StudentResult.cshtml"
               Write(item.StudentName);

#line default
#line hidden
            EndContext();
            BeginContext(832, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(860, 15, false);
#line 32 "E:\StudentSelectClassSystem\SelectClassApplication\Views\Admin\StudentResult.cshtml"
               Write(item.StudentSex);

#line default
#line hidden
            EndContext();
            BeginContext(875, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(903, 20, false);
#line 33 "E:\StudentSelectClassSystem\SelectClassApplication\Views\Admin\StudentResult.cshtml"
               Write(item.StudentBirthday);

#line default
#line hidden
            EndContext();
            BeginContext(923, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(951, 14, false);
#line 34 "E:\StudentSelectClassSystem\SelectClassApplication\Views\Admin\StudentResult.cshtml"
               Write(item.StudentId);

#line default
#line hidden
            EndContext();
            BeginContext(965, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(993, 13, false);
#line 35 "E:\StudentSelectClassSystem\SelectClassApplication\Views\Admin\StudentResult.cshtml"
               Write(item.MajorNum);

#line default
#line hidden
            EndContext();
            BeginContext(1006, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1034, 20, false);
#line 36 "E:\StudentSelectClassSystem\SelectClassApplication\Views\Admin\StudentResult.cshtml"
               Write(item.StudentPassword);

#line default
#line hidden
            EndContext();
            BeginContext(1054, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 38 "E:\StudentSelectClassSystem\SelectClassApplication\Views\Admin\StudentResult.cshtml"
        }

#line default
#line hidden
            BeginContext(1091, 54, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n\r\n");
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
