#pragma checksum "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "edb7be5f510a0ed616b5458a2f3cce80acd01537"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Companies_Delete), @"mvc.1.0.view", @"/Views/Companies/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Companies/Delete.cshtml", typeof(AspNetCore.Views_Companies_Delete))]
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
#line 1 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\_ViewImports.cshtml"
using NovoDiagnosis;

#line default
#line hidden
#line 2 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\_ViewImports.cshtml"
using NovoDiagnosis.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edb7be5f510a0ed616b5458a2f3cce80acd01537", @"/Views/Companies/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22ba3f2932ac4e7dcc082159f12ac909dc9162a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Companies_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NovoDiagnosis.Models.Company>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(81, 168, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Company</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(250, 40, false);
#line 15 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(290, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(334, 36, false);
#line 18 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(370, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(414, 40, false);
#line 21 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Code));

#line default
#line hidden
            EndContext();
            BeginContext(454, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(498, 36, false);
#line 24 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Code));

#line default
#line hidden
            EndContext();
            BeginContext(534, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(578, 43, false);
#line 27 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(621, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(665, 39, false);
#line 30 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(704, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(748, 40, false);
#line 33 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(788, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(832, 36, false);
#line 36 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(868, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(912, 43, false);
#line 39 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Stateid));

#line default
#line hidden
            EndContext();
            BeginContext(955, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(999, 39, false);
#line 42 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Stateid));

#line default
#line hidden
            EndContext();
            BeginContext(1038, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1082, 44, false);
#line 45 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Parentid));

#line default
#line hidden
            EndContext();
            BeginContext(1126, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1170, 40, false);
#line 48 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Parentid));

#line default
#line hidden
            EndContext();
            BeginContext(1210, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1254, 41, false);
#line 51 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1295, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1339, 37, false);
#line 54 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1376, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1420, 43, false);
#line 57 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Website));

#line default
#line hidden
            EndContext();
            BeginContext(1463, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1507, 39, false);
#line 60 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Website));

#line default
#line hidden
            EndContext();
            BeginContext(1546, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1590, 47, false);
#line 63 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1637, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1681, 43, false);
#line 66 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1724, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1768, 47, false);
#line 69 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1815, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1859, 43, false);
#line 72 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1902, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1946, 45, false);
#line 75 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedBy));

#line default
#line hidden
            EndContext();
            BeginContext(1991, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2035, 41, false);
#line 78 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CreatedBy));

#line default
#line hidden
            EndContext();
            BeginContext(2076, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2120, 42, false);
#line 81 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Logoid));

#line default
#line hidden
            EndContext();
            BeginContext(2162, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2206, 38, false);
#line 84 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Logoid));

#line default
#line hidden
            EndContext();
            BeginContext(2244, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2288, 54, false);
#line 87 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SubscriptionStatus));

#line default
#line hidden
            EndContext();
            BeginContext(2342, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2386, 50, false);
#line 90 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SubscriptionStatus));

#line default
#line hidden
            EndContext();
            BeginContext(2436, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2480, 41, false);
#line 93 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Plans));

#line default
#line hidden
            EndContext();
            BeginContext(2521, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2565, 37, false);
#line 96 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Plans));

#line default
#line hidden
            EndContext();
            BeginContext(2602, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2646, 55, false);
#line 99 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AuthorizationStatus));

#line default
#line hidden
            EndContext();
            BeginContext(2701, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2745, 51, false);
#line 102 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AuthorizationStatus));

#line default
#line hidden
            EndContext();
            BeginContext(2796, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2840, 53, false);
#line 105 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AuthorizationNote));

#line default
#line hidden
            EndContext();
            BeginContext(2893, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2937, 49, false);
#line 108 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AuthorizationNote));

#line default
#line hidden
            EndContext();
            BeginContext(2986, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3030, 51, false);
#line 111 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DisapprovalNote));

#line default
#line hidden
            EndContext();
            BeginContext(3081, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3125, 47, false);
#line 114 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DisapprovalNote));

#line default
#line hidden
            EndContext();
            BeginContext(3172, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3216, 48, false);
#line 117 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AuthorizedBy));

#line default
#line hidden
            EndContext();
            BeginContext(3264, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3308, 44, false);
#line 120 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AuthorizedBy));

#line default
#line hidden
            EndContext();
            BeginContext(3352, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3396, 49, false);
#line 123 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DisapprovedBy));

#line default
#line hidden
            EndContext();
            BeginContext(3445, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3489, 45, false);
#line 126 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DisapprovedBy));

#line default
#line hidden
            EndContext();
            BeginContext(3534, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3578, 50, false);
#line 129 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AuthorizedDate));

#line default
#line hidden
            EndContext();
            BeginContext(3628, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3672, 46, false);
#line 132 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AuthorizedDate));

#line default
#line hidden
            EndContext();
            BeginContext(3718, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3762, 51, false);
#line 135 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DisapprovalDate));

#line default
#line hidden
            EndContext();
            BeginContext(3813, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3857, 47, false);
#line 138 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DisapprovalDate));

#line default
#line hidden
            EndContext();
            BeginContext(3904, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3948, 48, false);
#line 141 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DeletionNote));

#line default
#line hidden
            EndContext();
            BeginContext(3996, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4040, 44, false);
#line 144 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DeletionNote));

#line default
#line hidden
            EndContext();
            BeginContext(4084, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4128, 40, false);
#line 147 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Guid));

#line default
#line hidden
            EndContext();
            BeginContext(4168, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4212, 36, false);
#line 150 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Guid));

#line default
#line hidden
            EndContext();
            BeginContext(4248, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4292, 45, false);
#line 153 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedOn));

#line default
#line hidden
            EndContext();
            BeginContext(4337, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4381, 41, false);
#line 156 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CreatedOn));

#line default
#line hidden
            EndContext();
            BeginContext(4422, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4466, 45, false);
#line 159 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UpdatedOn));

#line default
#line hidden
            EndContext();
            BeginContext(4511, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4555, 41, false);
#line 162 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UpdatedOn));

#line default
#line hidden
            EndContext();
            BeginContext(4596, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4640, 45, false);
#line 165 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IsDeleted));

#line default
#line hidden
            EndContext();
            BeginContext(4685, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4729, 41, false);
#line 168 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IsDeleted));

#line default
#line hidden
            EndContext();
            BeginContext(4770, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4814, 48, false);
#line 171 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SubsidiaryId));

#line default
#line hidden
            EndContext();
            BeginContext(4862, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4906, 44, false);
#line 174 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SubsidiaryId));

#line default
#line hidden
            EndContext();
            BeginContext(4950, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4994, 42, false);
#line 177 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SiteId));

#line default
#line hidden
            EndContext();
            BeginContext(5036, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(5080, 38, false);
#line 180 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SiteId));

#line default
#line hidden
            EndContext();
            BeginContext(5118, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(5162, 53, false);
#line 183 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CompanyListPageId));

#line default
#line hidden
            EndContext();
            BeginContext(5215, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(5259, 49, false);
#line 186 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CompanyListPageId));

#line default
#line hidden
            EndContext();
            BeginContext(5308, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(5352, 42, false);
#line 189 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(5394, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(5438, 38, false);
#line 192 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(5476, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(5520, 44, false);
#line 195 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LogoLink));

#line default
#line hidden
            EndContext();
            BeginContext(5564, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(5608, 40, false);
#line 198 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LogoLink));

#line default
#line hidden
            EndContext();
            BeginContext(5648, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(5692, 43, false);
#line 201 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.RegCode));

#line default
#line hidden
            EndContext();
            BeginContext(5735, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(5779, 39, false);
#line 204 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.RegCode));

#line default
#line hidden
            EndContext();
            BeginContext(5818, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(5862, 47, false);
#line 207 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.RegAgeLimit));

#line default
#line hidden
            EndContext();
            BeginContext(5909, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(5953, 43, false);
#line 210 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.RegAgeLimit));

#line default
#line hidden
            EndContext();
            BeginContext(5996, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(6040, 52, false);
#line 213 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.WeboperationMode));

#line default
#line hidden
            EndContext();
            BeginContext(6092, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(6136, 48, false);
#line 216 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.WeboperationMode));

#line default
#line hidden
            EndContext();
            BeginContext(6184, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(6228, 45, false);
#line 219 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IsRenewal));

#line default
#line hidden
            EndContext();
            BeginContext(6273, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(6317, 41, false);
#line 222 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IsRenewal));

#line default
#line hidden
            EndContext();
            BeginContext(6358, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(6396, 207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b882c2b6be3b436bb23398b928424d42", async() => {
                BeginContext(6422, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(6432, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "837d25c7bdd647d4aaf763cb6ad16868", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 227 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6468, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(6552, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87684a9a7f87414b9e5e31e55917899f", async() => {
                    BeginContext(6574, 12, true);
                    WriteLiteral("Back to List");
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
                BeginContext(6590, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6603, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NovoDiagnosis.Models.Company> Html { get; private set; }
    }
}
#pragma warning restore 1591