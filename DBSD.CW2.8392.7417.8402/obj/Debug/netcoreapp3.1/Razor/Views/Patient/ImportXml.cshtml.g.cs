#pragma checksum "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\ImportXml.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "748cd677baddcedeb9b52dcf5e082b1ff3e4512f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patient_ImportXml), @"mvc.1.0.view", @"/Views/Patient/ImportXml.cshtml")]
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
#line 1 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\_ViewImports.cshtml"
using DBSD.CW2._8392._7417._8402;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\_ViewImports.cshtml"
using DBSD.CW2._8392._7417._8402.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"748cd677baddcedeb9b52dcf5e082b1ff3e4512f", @"/Views/Patient/ImportXml.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6b3cc620517f9b8e87349db55ecedf872ccbc36", @"/Views/_ViewImports.cshtml")]
    public class Views_Patient_ImportXml : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DBSD.CW2._8392._7417._8402.Models.Patient>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ImportXml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\ImportXml.cshtml"
  
    ViewData["Title"] = "ImportXml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Import Xml</h1>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "748cd677baddcedeb9b52dcf5e082b1ff3e4512f5270", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "748cd677baddcedeb9b52dcf5e082b1ff3e4512f5540", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 12 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\ImportXml.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            <div class=""form-group"">
                <label for=""importFile""></label>
                <input name=""importFile"" class=""form-control import-file"" type=""file"" />
            </div>

            <div class=""form-group"">
                <input type=""submit"" value=""Import"" class=""btn our-btn"" />
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 24 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\ImportXml.cshtml"
 if(Model != null) 
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table table-bordered table-hover table-striped\">\r\n    <thead");
            BeginWriteAttribute("class", " class=\"", 814, "\"", 822, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <tr>\r\n\r\n            <th scope=\"col\">\r\n                ");
#nullable restore
#line 31 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\ImportXml.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th scope=\"col\">\r\n                ");
#nullable restore
#line 34 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\ImportXml.cshtml"
           Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th scope=\"col\">\r\n                ");
#nullable restore
#line 37 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\ImportXml.cshtml"
           Write(Html.DisplayNameFor(model => model.DoB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th scope=\"col\">\r\n                ");
#nullable restore
#line 40 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\ImportXml.cshtml"
           Write(Html.DisplayNameFor(model => model.Occupation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th scope=\"col\">\r\n                ");
#nullable restore
#line 43 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\ImportXml.cshtml"
           Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th scope=\"col\">\r\n                ");
#nullable restore
#line 46 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\ImportXml.cshtml"
           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th scope=\"col\">\r\n                ");
#nullable restore
#line 50 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\ImportXml.cshtml"
           Write(Html.DisplayNameFor(model => model.DiagnoseId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th scope=\"col\">\r\n                ");
#nullable restore
#line 53 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\ImportXml.cshtml"
           Write(Html.DisplayNameFor(model => model.DoctorId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th scope=\"col\">\r\n                ");
#nullable restore
#line 56 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\ImportXml.cshtml"
           Write(Html.DisplayNameFor(model => model.WardId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 61 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\ImportXml.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 65 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\ImportXml.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 68 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\ImportXml.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 71 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\ImportXml.cshtml"
           Write(Html.DisplayFor(modelItem => item.DoB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 74 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\ImportXml.cshtml"
           Write(Html.DisplayFor(modelItem => item.Occupation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 77 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\ImportXml.cshtml"
           Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 80 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\ImportXml.cshtml"
           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 84 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\ImportXml.cshtml"
           Write(Html.DisplayFor(modelItem => item.DiagnoseId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 87 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\ImportXml.cshtml"
           Write(Html.DisplayFor(modelItem => item.DoctorId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 90 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\ImportXml.cshtml"
           Write(Html.DisplayFor(modelItem => item.WardId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 93 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\ImportXml.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
#nullable restore
#line 96 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\ImportXml.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DBSD.CW2._8392._7417._8402.Models.Patient>> Html { get; private set; }
    }
}
#pragma warning restore 1591
