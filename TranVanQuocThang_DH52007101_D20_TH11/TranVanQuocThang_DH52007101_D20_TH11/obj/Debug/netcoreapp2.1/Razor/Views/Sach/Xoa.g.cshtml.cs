#pragma checksum "C:\Users\QuocThang\Desktop\TranVanQuocThang_DH52007101_D20_TH11\TranVanQuocThang_DH52007101_D20_TH11\Views\Sach\Xoa.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba87c56a4ddccdaa3422f68416e85b5adf648c09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sach_Xoa), @"mvc.1.0.view", @"/Views/Sach/Xoa.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Sach/Xoa.cshtml", typeof(AspNetCore.Views_Sach_Xoa))]
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
#line 1 "C:\Users\QuocThang\Desktop\TranVanQuocThang_DH52007101_D20_TH11\TranVanQuocThang_DH52007101_D20_TH11\Views\_ViewImports.cshtml"
using TranVanQuocThang_DH52007101_D20_TH11;

#line default
#line hidden
#line 2 "C:\Users\QuocThang\Desktop\TranVanQuocThang_DH52007101_D20_TH11\TranVanQuocThang_DH52007101_D20_TH11\Views\_ViewImports.cshtml"
using TranVanQuocThang_DH52007101_D20_TH11.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba87c56a4ddccdaa3422f68416e85b5adf648c09", @"/Views/Sach/Xoa.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95294a6f8cb4419a4f4702393ccf0ccf98bca129", @"/Views/_ViewImports.cshtml")]
    public class Views_Sach_Xoa : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TranVanQuocThang_DH52007101_D20_TH11.Models.Sach>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\QuocThang\Desktop\TranVanQuocThang_DH52007101_D20_TH11\TranVanQuocThang_DH52007101_D20_TH11\Views\Sach\Xoa.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(86, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(115, 415, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3af25da809f2457291b089c31db2e98f", async() => {
                BeginContext(121, 402, true);
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <title>Xoá thông tin sách</title>
    <!-- Latest compiled and minified CSS -->
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css"" rel=""stylesheet"">
    <!-- Latest compiled JavaScript -->
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js""></script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(530, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(532, 2352, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0f4ca4ddde74b53948aefafdce10b75", async() => {
                BeginContext(538, 31, true);
                WriteLiteral("\r\n    <div class=\"container\">\r\n");
                EndContext();
#line 20 "C:\Users\QuocThang\Desktop\TranVanQuocThang_DH52007101_D20_TH11\TranVanQuocThang_DH52007101_D20_TH11\Views\Sach\Xoa.cshtml"
          
            if (ViewBag.flagDelete == true) {

#line default
#line hidden
                BeginContext(628, 94, true);
                WriteLiteral("                <h2>Xóa thông tin sách</h2>\r\n                <h3>Bạn muốn xóa sách này?</h3>\r\n");
                EndContext();
#line 24 "C:\Users\QuocThang\Desktop\TranVanQuocThang_DH52007101_D20_TH11\TranVanQuocThang_DH52007101_D20_TH11\Views\Sach\Xoa.cshtml"
            } else {

#line default
#line hidden
                BeginContext(744, 54, true);
                WriteLiteral("                <h3>Bạn không thể xóa sách này!</h3>\r\n");
                EndContext();
#line 26 "C:\Users\QuocThang\Desktop\TranVanQuocThang_DH52007101_D20_TH11\TranVanQuocThang_DH52007101_D20_TH11\Views\Sach\Xoa.cshtml"
            }
        

#line default
#line hidden
                BeginContext(824, 8, true);
                WriteLiteral("        ");
                EndContext();
                BeginContext(832, 1601, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37567ef5fe9a4f71beeb69f5a9648bf0", async() => {
                    BeginContext(852, 170, true);
                    WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <table class=\"table\">\r\n                    <thead>\r\n                        <tr>\r\n                            <th>");
                    EndContext();
                    BeginContext(1022, 52, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08ddc96337824ca2854377281ed7421e", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 33 "C:\Users\QuocThang\Desktop\TranVanQuocThang_DH52007101_D20_TH11\TranVanQuocThang_DH52007101_D20_TH11\Views\Sach\Xoa.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.TenSach);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1074, 39, true);
                    WriteLiteral("</th>\r\n                            <th>");
                    EndContext();
                    BeginContext(1113, 51, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb6bb8a356b0424b900693441c9ff396", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 34 "C:\Users\QuocThang\Desktop\TranVanQuocThang_DH52007101_D20_TH11\TranVanQuocThang_DH52007101_D20_TH11\Views\Sach\Xoa.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.NgayXb);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1164, 39, true);
                    WriteLiteral("</th>\r\n                            <th>");
                    EndContext();
                    BeginContext(1203, 48, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a10e80c067a4e23b2296e8b57e6ad54", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 35 "C:\Users\QuocThang\Desktop\TranVanQuocThang_DH52007101_D20_TH11\TranVanQuocThang_DH52007101_D20_TH11\Views\Sach\Xoa.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Gia);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1251, 39, true);
                    WriteLiteral("</th>\r\n                            <th>");
                    EndContext();
                    BeginContext(1290, 51, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc0e7569a1cb4237aad9484fb30a19c0", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 36 "C:\Users\QuocThang\Desktop\TranVanQuocThang_DH52007101_D20_TH11\TranVanQuocThang_DH52007101_D20_TH11\Views\Sach\Xoa.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.MaLoai);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1341, 227, true);
                    WriteLiteral("</th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n                        <tr>\r\n                            <td>\r\n                                <input type=\"hidden\" name=\"maloai\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 1568, "\"", 1589, 1);
#line 42 "C:\Users\QuocThang\Desktop\TranVanQuocThang_DH52007101_D20_TH11\TranVanQuocThang_DH52007101_D20_TH11\Views\Sach\Xoa.cshtml"
WriteAttributeValue("", 1576, Model.MaSach, 1576, 13, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(1590, 37, true);
                    WriteLiteral(" />\r\n                                ");
                    EndContext();
                    BeginContext(1627, 47, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e334cebe2ed5413ebc60e7e3f92f373d", async() => {
                        BeginContext(1653, 13, false);
#line 43 "C:\Users\QuocThang\Desktop\TranVanQuocThang_DH52007101_D20_TH11\TranVanQuocThang_DH52007101_D20_TH11\Views\Sach\Xoa.cshtml"
                                                    Write(Model.TenSach);

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 43 "C:\Users\QuocThang\Desktop\TranVanQuocThang_DH52007101_D20_TH11\TranVanQuocThang_DH52007101_D20_TH11\Views\Sach\Xoa.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.TenSach);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1674, 88, true);
                    WriteLiteral("\r\n                            </td>\r\n                            <td id=\"formattedDate\">");
                    EndContext();
                    BeginContext(1763, 12, false);
#line 45 "C:\Users\QuocThang\Desktop\TranVanQuocThang_DH52007101_D20_TH11\TranVanQuocThang_DH52007101_D20_TH11\Views\Sach\Xoa.cshtml"
                                              Write(Model.NgayXb);

#line default
#line hidden
                    EndContext();
                    BeginContext(1775, 39, true);
                    WriteLiteral("</td>\r\n                            <td>");
                    EndContext();
                    BeginContext(1814, 39, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e8b1ddfc3e649f79bf2597e91103484", async() => {
                        BeginContext(1836, 9, false);
#line 46 "C:\Users\QuocThang\Desktop\TranVanQuocThang_DH52007101_D20_TH11\TranVanQuocThang_DH52007101_D20_TH11\Views\Sach\Xoa.cshtml"
                                                Write(Model.Gia);

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 46 "C:\Users\QuocThang\Desktop\TranVanQuocThang_DH52007101_D20_TH11\TranVanQuocThang_DH52007101_D20_TH11\Views\Sach\Xoa.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Gia);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1853, 39, true);
                    WriteLiteral("</td>\r\n                            <td>");
                    EndContext();
                    BeginContext(1892, 45, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "620efa4c8b314bffb28ad16e37101d76", async() => {
                        BeginContext(1917, 12, false);
#line 47 "C:\Users\QuocThang\Desktop\TranVanQuocThang_DH52007101_D20_TH11\TranVanQuocThang_DH52007101_D20_TH11\Views\Sach\Xoa.cshtml"
                                                   Write(Model.MaLoai);

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 47 "C:\Users\QuocThang\Desktop\TranVanQuocThang_DH52007101_D20_TH11\TranVanQuocThang_DH52007101_D20_TH11\Views\Sach\Xoa.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.MaLoai);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1937, 116, true);
                    WriteLiteral("</td>\r\n                        </tr>\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n\r\n");
                    EndContext();
#line 53 "C:\Users\QuocThang\Desktop\TranVanQuocThang_DH52007101_D20_TH11\TranVanQuocThang_DH52007101_D20_TH11\Views\Sach\Xoa.cshtml"
              
                if (ViewBag.flagDelete == true) {

#line default
#line hidden
                    BeginContext(2120, 171, true);
                    WriteLiteral("                    <div class=\"form-group\">\r\n                        <input type=\"submit\" value=\"Xóa\" class=\"btn btn-primary\" /><br /><br />\r\n                    </div>\r\n");
                    EndContext();
#line 58 "C:\Users\QuocThang\Desktop\TranVanQuocThang_DH52007101_D20_TH11\TranVanQuocThang_DH52007101_D20_TH11\Views\Sach\Xoa.cshtml"
                }
            

#line default
#line hidden
                    BeginContext(2325, 37, true);
                    WriteLiteral("\r\n            <div>\r\n                ");
                    EndContext();
                    BeginContext(2362, 34, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "237357791472470f831246de10a4fb42", async() => {
                        BeginContext(2384, 8, true);
                        WriteLiteral("Quay lại");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2396, 30, true);
                    WriteLiteral("\r\n            </div>\r\n        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2433, 92, true);
                WriteLiteral("\r\n\r\n        <script>\r\n            // Lấy giá trị ngày từ server\r\n            var rawDate = \"");
                EndContext();
                BeginContext(2526, 12, false);
#line 68 "C:\Users\QuocThang\Desktop\TranVanQuocThang_DH52007101_D20_TH11\TranVanQuocThang_DH52007101_D20_TH11\Views\Sach\Xoa.cshtml"
                      Write(Model.NgayXb);

#line default
#line hidden
                EndContext();
                BeginContext(2538, 339, true);
                WriteLiteral(@""";

            // Chuyển đổi ngày thành định dạng ""dd/MM/yyyy""
            var formattedDate = new Date(rawDate).toLocaleDateString('en-GB');

            // Hiển thị ngày đã định dạng trong thẻ có id là ""formattedDate""
            document.getElementById(""formattedDate"").innerText = formattedDate;
        </script>
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2884, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TranVanQuocThang_DH52007101_D20_TH11.Models.Sach> Html { get; private set; }
    }
}
#pragma warning restore 1591
