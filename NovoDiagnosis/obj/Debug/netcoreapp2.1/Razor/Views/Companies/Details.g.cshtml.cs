#pragma checksum "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ef91e05b151d1032123ba18d9f3b901d8b38e5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Companies_Details), @"mvc.1.0.view", @"/Views/Companies/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Companies/Details.cshtml", typeof(AspNetCore.Views_Companies_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ef91e05b151d1032123ba18d9f3b901d8b38e5e", @"/Views/Companies/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22ba3f2932ac4e7dcc082159f12ac909dc9162a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Companies_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NovoDiagnosis.Models.Company>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(82, 121, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Company</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(204, 40, false);
#line 14 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(244, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(288, 36, false);
#line 17 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(324, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(368, 40, false);
#line 20 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Code));

#line default
#line hidden
            EndContext();
            BeginContext(408, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(452, 36, false);
#line 23 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Code));

#line default
#line hidden
            EndContext();
            BeginContext(488, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(532, 43, false);
#line 26 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(575, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(619, 39, false);
#line 29 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(658, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(702, 40, false);
#line 32 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(742, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(786, 36, false);
#line 35 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(822, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(866, 43, false);
#line 38 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Stateid));

#line default
#line hidden
            EndContext();
            BeginContext(909, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(953, 39, false);
#line 41 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Stateid));

#line default
#line hidden
            EndContext();
            BeginContext(992, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1036, 44, false);
#line 44 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Parentid));

#line default
#line hidden
            EndContext();
            BeginContext(1080, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1124, 40, false);
#line 47 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Parentid));

#line default
#line hidden
            EndContext();
            BeginContext(1164, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1208, 41, false);
#line 50 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1249, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1293, 37, false);
#line 53 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1330, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1374, 43, false);
#line 56 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Website));

#line default
#line hidden
            EndContext();
            BeginContext(1417, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1461, 39, false);
#line 59 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Website));

#line default
#line hidden
            EndContext();
            BeginContext(1500, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1544, 47, false);
#line 62 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1591, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1635, 43, false);
#line 65 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1678, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1722, 47, false);
#line 68 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1769, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1813, 43, false);
#line 71 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1856, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1900, 45, false);
#line 74 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedBy));

#line default
#line hidden
            EndContext();
            BeginContext(1945, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1989, 41, false);
#line 77 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreatedBy));

#line default
#line hidden
            EndContext();
            BeginContext(2030, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2074, 42, false);
#line 80 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Logoid));

#line default
#line hidden
            EndContext();
            BeginContext(2116, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2160, 38, false);
#line 83 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Logoid));

#line default
#line hidden
            EndContext();
            BeginContext(2198, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2242, 54, false);
#line 86 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SubscriptionStatus));

#line default
#line hidden
            EndContext();
            BeginContext(2296, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2340, 50, false);
#line 89 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.SubscriptionStatus));

#line default
#line hidden
            EndContext();
            BeginContext(2390, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2434, 41, false);
#line 92 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Plans));

#line default
#line hidden
            EndContext();
            BeginContext(2475, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2519, 37, false);
#line 95 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Plans));

#line default
#line hidden
            EndContext();
            BeginContext(2556, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2600, 55, false);
#line 98 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AuthorizationStatus));

#line default
#line hidden
            EndContext();
            BeginContext(2655, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2699, 51, false);
#line 101 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.AuthorizationStatus));

#line default
#line hidden
            EndContext();
            BeginContext(2750, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2794, 53, false);
#line 104 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AuthorizationNote));

#line default
#line hidden
            EndContext();
            BeginContext(2847, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2891, 49, false);
#line 107 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.AuthorizationNote));

#line default
#line hidden
            EndContext();
            BeginContext(2940, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2984, 51, false);
#line 110 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DisapprovalNote));

#line default
#line hidden
            EndContext();
            BeginContext(3035, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3079, 47, false);
#line 113 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.DisapprovalNote));

#line default
#line hidden
            EndContext();
            BeginContext(3126, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3170, 48, false);
#line 116 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AuthorizedBy));

#line default
#line hidden
            EndContext();
            BeginContext(3218, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3262, 44, false);
#line 119 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.AuthorizedBy));

#line default
#line hidden
            EndContext();
            BeginContext(3306, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3350, 49, false);
#line 122 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DisapprovedBy));

#line default
#line hidden
            EndContext();
            BeginContext(3399, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3443, 45, false);
#line 125 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.DisapprovedBy));

#line default
#line hidden
            EndContext();
            BeginContext(3488, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3532, 50, false);
#line 128 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AuthorizedDate));

#line default
#line hidden
            EndContext();
            BeginContext(3582, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3626, 46, false);
#line 131 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.AuthorizedDate));

#line default
#line hidden
            EndContext();
            BeginContext(3672, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3716, 51, false);
#line 134 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DisapprovalDate));

#line default
#line hidden
            EndContext();
            BeginContext(3767, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3811, 47, false);
#line 137 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.DisapprovalDate));

#line default
#line hidden
            EndContext();
            BeginContext(3858, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3902, 48, false);
#line 140 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DeletionNote));

#line default
#line hidden
            EndContext();
            BeginContext(3950, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3994, 44, false);
#line 143 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.DeletionNote));

#line default
#line hidden
            EndContext();
            BeginContext(4038, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4082, 40, false);
#line 146 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Guid));

#line default
#line hidden
            EndContext();
            BeginContext(4122, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4166, 36, false);
#line 149 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Guid));

#line default
#line hidden
            EndContext();
            BeginContext(4202, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4246, 45, false);
#line 152 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedOn));

#line default
#line hidden
            EndContext();
            BeginContext(4291, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4335, 41, false);
#line 155 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreatedOn));

#line default
#line hidden
            EndContext();
            BeginContext(4376, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4420, 45, false);
#line 158 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UpdatedOn));

#line default
#line hidden
            EndContext();
            BeginContext(4465, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4509, 41, false);
#line 161 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.UpdatedOn));

#line default
#line hidden
            EndContext();
            BeginContext(4550, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4594, 45, false);
#line 164 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsDeleted));

#line default
#line hidden
            EndContext();
            BeginContext(4639, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4683, 41, false);
#line 167 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsDeleted));

#line default
#line hidden
            EndContext();
            BeginContext(4724, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4768, 48, false);
#line 170 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SubsidiaryId));

#line default
#line hidden
            EndContext();
            BeginContext(4816, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4860, 44, false);
#line 173 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.SubsidiaryId));

#line default
#line hidden
            EndContext();
            BeginContext(4904, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4948, 42, false);
#line 176 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SiteId));

#line default
#line hidden
            EndContext();
            BeginContext(4990, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(5034, 38, false);
#line 179 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.SiteId));

#line default
#line hidden
            EndContext();
            BeginContext(5072, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(5116, 53, false);
#line 182 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CompanyListPageId));

#line default
#line hidden
            EndContext();
            BeginContext(5169, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(5213, 49, false);
#line 185 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.CompanyListPageId));

#line default
#line hidden
            EndContext();
            BeginContext(5262, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(5306, 42, false);
#line 188 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(5348, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(5392, 38, false);
#line 191 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(5430, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(5474, 44, false);
#line 194 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LogoLink));

#line default
#line hidden
            EndContext();
            BeginContext(5518, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(5562, 40, false);
#line 197 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.LogoLink));

#line default
#line hidden
            EndContext();
            BeginContext(5602, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(5646, 43, false);
#line 200 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RegCode));

#line default
#line hidden
            EndContext();
            BeginContext(5689, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(5733, 39, false);
#line 203 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.RegCode));

#line default
#line hidden
            EndContext();
            BeginContext(5772, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(5816, 47, false);
#line 206 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RegAgeLimit));

#line default
#line hidden
            EndContext();
            BeginContext(5863, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(5907, 43, false);
#line 209 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.RegAgeLimit));

#line default
#line hidden
            EndContext();
            BeginContext(5950, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(5994, 52, false);
#line 212 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.WeboperationMode));

#line default
#line hidden
            EndContext();
            BeginContext(6046, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(6090, 48, false);
#line 215 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.WeboperationMode));

#line default
#line hidden
            EndContext();
            BeginContext(6138, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(6182, 45, false);
#line 218 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsRenewal));

#line default
#line hidden
            EndContext();
            BeginContext(6227, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(6271, 41, false);
#line 221 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsRenewal));

#line default
#line hidden
            EndContext();
            BeginContext(6312, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(6359, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a5c6cb3600746d79b11249632679316", async() => {
                BeginContext(6405, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 226 "C:\Users\novoadmin\Desktop\diag3\NovoDiagnosis\Views\Companies\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6413, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(6421, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "428bb3ace0544fd79a5400b7b567dece", async() => {
                BeginContext(6443, 12, true);
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
            BeginContext(6459, 10, true);
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