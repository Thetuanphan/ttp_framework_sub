#pragma checksum "E:\FileGit\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\ManHinh\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25b4067d8c1857e82f13a523488481477dcdcc1e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ManHinh_Edit), @"mvc.1.0.view", @"/Views/ManHinh/Edit.cshtml")]
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
#line 1 "E:\FileGit\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\_ViewImports.cshtml"
using DoAn_CuaHangLaptop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\FileGit\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\_ViewImports.cshtml"
using DoAn_CuaHangLaptop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25b4067d8c1857e82f13a523488481477dcdcc1e", @"/Views/ManHinh/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7b8ba9fc583e43ab0ed1cccc6fe68ac4fc52165", @"/Views/_ViewImports.cshtml")]
    public class Views_ManHinh_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DoAn_CuaHangLaptop.Models.ManHinh>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\FileGit\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\ManHinh\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    var manhinh = ViewData["ManHinh"] as ManHinh;
    Layout = "/Views/Shared/_Layout2.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 style=\"text-align: center; color: coral;\">Cập nhật thông tin</h1>\r\n<hr />\r\n\r\n");
#nullable restore
#line 12 "E:\FileGit\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\ManHinh\Edit.cshtml"
 using (Html.BeginForm("Edit", "ManHinh", new { style = "border:1px solid red; " }))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table\" , style=\"text-align:center;\">\r\n    <tr style=\"display: none;\">\r\n        <td> <b>Mã màn hình</b></td>\r\n        <td><input type=\"text\" id=\"maMH\" name=\"maMH\"");
            BeginWriteAttribute("value", " value=\"", 533, "\"", 554, 1);
#nullable restore
#line 17 "E:\FileGit\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\ManHinh\Edit.cshtml"
WriteAttributeValue("", 541, manhinh.MaMH, 541, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 70%;\"></td>\r\n    </tr>\r\n    <tr>\r\n        <td> <b>Kích thước</b></td>\r\n        <td><input type=\"text\" id=\"kichThuoc\" name=\"kichThuoc\"");
            BeginWriteAttribute("value", " value=\"", 703, "\"", 729, 1);
#nullable restore
#line 21 "E:\FileGit\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\ManHinh\Edit.cshtml"
WriteAttributeValue("", 711, manhinh.KichThuoc, 711, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 70%;\"></td>\r\n    </tr>\r\n    <tr>\r\n        <td> <b>Độ phân giải</b></td>\r\n        <td><input type=\"text\" id=\"doPhanGiai\" name=\"doPhanGiai\"");
            BeginWriteAttribute("value", " value=\"", 882, "\"", 909, 1);
#nullable restore
#line 25 "E:\FileGit\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\ManHinh\Edit.cshtml"
WriteAttributeValue("", 890, manhinh.DoPhanGiai, 890, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 70%;\"></td>\r\n    </tr>\r\n    <tr>\r\n        <td> <b>Tần số quét</b></td>\r\n        <td><input type=\"text\" id=\"tanSoQuet\" name=\"tanSoQuet\"");
            BeginWriteAttribute("value", " value=\"", 1059, "\"", 1085, 1);
#nullable restore
#line 29 "E:\FileGit\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\ManHinh\Edit.cshtml"
WriteAttributeValue("", 1067, manhinh.TanSoQuet, 1067, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 70%;\"></td>\r\n    </tr>\r\n    <tr>\r\n        <td> <b>Công nghệ màn hình</b> </td>\r\n        <td>  <input type=\"text\" id=\"congNgheMH\" name=\"congNgheMH\"");
            BeginWriteAttribute("value", " value=\"", 1247, "\"", 1274, 1);
#nullable restore
#line 33 "E:\FileGit\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\ManHinh\Edit.cshtml"
WriteAttributeValue("", 1255, manhinh.CongNgheMH, 1255, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 70%;\"></td>\r\n    </tr>\r\n    <tr>\r\n        <td> <b>Cảm ứng</b></td>\r\n        <td>  <input type=\"text\" id=\"camUng\" name=\"camUng\"");
            BeginWriteAttribute("value", " value=\"", 1416, "\"", 1439, 1);
#nullable restore
#line 37 "E:\FileGit\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\ManHinh\Edit.cshtml"
WriteAttributeValue("", 1424, manhinh.CamUng, 1424, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 70%;\"></td>\r\n    </tr>\r\n</table>\r\n    <br />\r\n    <div style=\"text-align: center\"> <input type=\"submit\" value=\"Cập nhật\" /></div>\r\n");
#nullable restore
#line 42 "E:\FileGit\framework_IS220.M11_11\DoAn_CuaHangLaptop\DoAn_CuaHangLaptop\Views\ManHinh\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25b4067d8c1857e82f13a523488481477dcdcc1e7945", async() => {
                WriteLiteral("Trở về");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DoAn_CuaHangLaptop.Models.ManHinh> Html { get; private set; }
    }
}
#pragma warning restore 1591
