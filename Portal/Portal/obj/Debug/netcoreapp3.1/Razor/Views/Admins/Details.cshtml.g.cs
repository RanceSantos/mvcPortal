#pragma checksum "C:\Users\User\source\repos\mvcPortal\Portal\Portal\Views\Admins\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "362db69fdedb1ce964c3b5ef4e808bed6cbc1aee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admins_Details), @"mvc.1.0.view", @"/Views/Admins/Details.cshtml")]
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
#line 1 "C:\Users\User\source\repos\mvcPortal\Portal\Portal\Views\_ViewImports.cshtml"
using Portal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\mvcPortal\Portal\Portal\Views\_ViewImports.cshtml"
using Portal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"362db69fdedb1ce964c3b5ef4e808bed6cbc1aee", @"/Views/Admins/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea73c18953461b2da0883cbece56eb399a5ce162", @"/Views/_ViewImports.cshtml")]
    public class Views_Admins_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Portal.Models.Admin>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\User\source\repos\mvcPortal\Portal\Portal\Views\Admins\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <!--<hr />-->\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 12 "C:\Users\User\source\repos\mvcPortal\Portal\Portal\Views\Admins\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StudentID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 15 "C:\Users\User\source\repos\mvcPortal\Portal\Portal\Views\Admins\Details.cshtml"
       Write(Html.DisplayFor(model => model.StudentID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 18 "C:\Users\User\source\repos\mvcPortal\Portal\Portal\Views\Admins\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Last_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 21 "C:\Users\User\source\repos\mvcPortal\Portal\Portal\Views\Admins\Details.cshtml"
       Write(Html.DisplayFor(model => model.Last_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 24 "C:\Users\User\source\repos\mvcPortal\Portal\Portal\Views\Admins\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.First_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 27 "C:\Users\User\source\repos\mvcPortal\Portal\Portal\Views\Admins\Details.cshtml"
       Write(Html.DisplayFor(model => model.First_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 30 "C:\Users\User\source\repos\mvcPortal\Portal\Portal\Views\Admins\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 33 "C:\Users\User\source\repos\mvcPortal\Portal\Portal\Views\Admins\Details.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </dd>
    </dl>
</div>
<br />
<center>
    <!--PRELIM-->
    <div class=""table TablePrelim"">
        <table class="" w-75 Prelim"">
            <thead class=""thead-dark"">
                <tr>
                    <th colspan=""2"">Preliminary</th>
                    <th></th>
                    <th></th>
                    <th></th>
                </tr>
            </thead>
            <thead class=""thead-light"">
                <tr>
                    <th> </th>
                    <th>#1</th>
                    <th>#2</th>
                    <th>#3</th>
                    <th>Total</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>Quizzes</td>
                    <td>");
#nullable restore
#line 62 "C:\Users\User\source\repos\mvcPortal\Portal\Portal\Views\Admins\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Pq1));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 63 "C:\Users\User\source\repos\mvcPortal\Portal\Portal\Views\Admins\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Pq2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 64 "C:\Users\User\source\repos\mvcPortal\Portal\Portal\Views\Admins\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Pq3));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 65 "C:\Users\User\source\repos\mvcPortal\Portal\Portal\Views\Admins\Details.cshtml"
                   Write(Html.DisplayFor(model => model.PqAve));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Assignments</td>\r\n                    <td>");
#nullable restore
#line 69 "C:\Users\User\source\repos\mvcPortal\Portal\Portal\Views\Admins\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Pa1));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 70 "C:\Users\User\source\repos\mvcPortal\Portal\Portal\Views\Admins\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Pa2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 71 "C:\Users\User\source\repos\mvcPortal\Portal\Portal\Views\Admins\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Pa3));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 72 "C:\Users\User\source\repos\mvcPortal\Portal\Portal\Views\Admins\Details.cshtml"
                   Write(Html.DisplayFor(model => model.PaAve));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr class=\"bg-secondary text-light\">\r\n                    <td colspan=\"4\">Total Average</td>\r\n                    <td>");
#nullable restore
#line 76 "C:\Users\User\source\repos\mvcPortal\Portal\Portal\Views\Admins\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Prelim));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                </tr>
            </tbody>
        </table>
    </div>

    <!--MIDTERM-->
    <div class=""table TableMidterm"">
        <table class="" w-75 Midtern"">
            <thead class=""thead-dark"">
                <tr>
                    <th colspan=""2"">Midterm</th>
                    <th></th>
                    <th></th>
                    <th></th>
                </tr>
            </thead>
            <thead class=""thead-light"">
                <tr>
                    <th> </th>
                    <th>#1</th>
                    <th>#2</th>
                    <th>#3</th>
                    <th>Total</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>Quizzes</td>
                    <td>");
#nullable restore
#line 105 "C:\Users\User\source\repos\mvcPortal\Portal\Portal\Views\Admins\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Mq1));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 106 "C:\Users\User\source\repos\mvcPortal\Portal\Portal\Views\Admins\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Mq2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 107 "C:\Users\User\source\repos\mvcPortal\Portal\Portal\Views\Admins\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Mq3));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 108 "C:\Users\User\source\repos\mvcPortal\Portal\Portal\Views\Admins\Details.cshtml"
                   Write(Html.DisplayFor(model => model.MqAve));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Assignments</td>\r\n                    <td>");
#nullable restore
#line 112 "C:\Users\User\source\repos\mvcPortal\Portal\Portal\Views\Admins\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Ma1));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 113 "C:\Users\User\source\repos\mvcPortal\Portal\Portal\Views\Admins\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Ma2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 114 "C:\Users\User\source\repos\mvcPortal\Portal\Portal\Views\Admins\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Ma3));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 115 "C:\Users\User\source\repos\mvcPortal\Portal\Portal\Views\Admins\Details.cshtml"
                   Write(Html.DisplayFor(model => model.MaAve));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr class=\"bg-secondary text-light\">\r\n                    <td colspan=\"4\">Total Average</td>\r\n                    <td>");
#nullable restore
#line 119 "C:\Users\User\source\repos\mvcPortal\Portal\Portal\Views\Admins\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Midterm));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                </tr>
            </tbody>
        </table>
    </div>

    <!--PREfi-->
    <div class=""table TablePrefinals"">
        <table class="" w-75 Prefinals"">
            <thead class=""thead-dark"">
                <tr>
                    <th colspan=""2"">Pre-Finals Grade</th>
                    <th></th>
                    <th></th>
                    <th></th>
                </tr>
            </thead>
            <thead class=""thead-light"">
                <tr>
                    <th> </th>
                    <th>#1</th>
                    <th>#2</th>
                    <th>#3</th>
                    <th>Total</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>Quizzes</td>
                    <td>");
#nullable restore
#line 148 "C:\Users\User\source\repos\mvcPortal\Portal\Portal\Views\Admins\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Pfq1));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 149 "C:\Users\User\source\repos\mvcPortal\Portal\Portal\Views\Admins\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Pfq2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 150 "C:\Users\User\source\repos\mvcPortal\Portal\Portal\Views\Admins\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Pfq3));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 151 "C:\Users\User\source\repos\mvcPortal\Portal\Portal\Views\Admins\Details.cshtml"
                   Write(Html.DisplayFor(model => model.PfqAve));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Assignments</td>\r\n                    <td>");
#nullable restore
#line 155 "C:\Users\User\source\repos\mvcPortal\Portal\Portal\Views\Admins\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Pfa1));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 156 "C:\Users\User\source\repos\mvcPortal\Portal\Portal\Views\Admins\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Pfa2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 157 "C:\Users\User\source\repos\mvcPortal\Portal\Portal\Views\Admins\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Pfa3));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 158 "C:\Users\User\source\repos\mvcPortal\Portal\Portal\Views\Admins\Details.cshtml"
                   Write(Html.DisplayFor(model => model.PfaAve));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr class=\"bg-secondary text-light\">\r\n                    <td colspan=\"4\">Total Average</td>\r\n                    <td>");
#nullable restore
#line 162 "C:\Users\User\source\repos\mvcPortal\Portal\Portal\Views\Admins\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Prefinals));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                </tr>
            </tbody>
        </table>
    </div>

    <!--Finals-->
    <div class=""table TableFinals"">
        <table class=""  w-75 Finals"">
            <thead class=""thead-dark"">
                <tr>
                    <th colspan=""2"">Finals Grade</th>
                    <th></th>
                    <th></th>
                    <th></th>
                </tr>
            </thead>
            <thead class=""thead-light"">
                <tr>
                    <th> </th>
                    <th>#1</th>
                    <th>#2</th>
                    <th>#3</th>
                    <th>Total</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>Quizzes</td>
                    <td>");
#nullable restore
#line 191 "C:\Users\User\source\repos\mvcPortal\Portal\Portal\Views\Admins\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Fq1));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 192 "C:\Users\User\source\repos\mvcPortal\Portal\Portal\Views\Admins\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Fq2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 193 "C:\Users\User\source\repos\mvcPortal\Portal\Portal\Views\Admins\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Fq3));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 194 "C:\Users\User\source\repos\mvcPortal\Portal\Portal\Views\Admins\Details.cshtml"
                   Write(Html.DisplayFor(model => model.FqAve));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Assignments</td>\r\n                    <td>");
#nullable restore
#line 198 "C:\Users\User\source\repos\mvcPortal\Portal\Portal\Views\Admins\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Fa1));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 199 "C:\Users\User\source\repos\mvcPortal\Portal\Portal\Views\Admins\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Fa2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 200 "C:\Users\User\source\repos\mvcPortal\Portal\Portal\Views\Admins\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Fa3));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 201 "C:\Users\User\source\repos\mvcPortal\Portal\Portal\Views\Admins\Details.cshtml"
                   Write(Html.DisplayFor(model => model.FaAve));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr class=\"bg-secondary text-light\">\r\n                    <td colspan=\"4\">Total Average</td>\r\n                    <td>");
#nullable restore
#line 205 "C:\Users\User\source\repos\mvcPortal\Portal\Portal\Views\Admins\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Finals));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n\r\n    <div class=\"btn edit\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "362db69fdedb1ce964c3b5ef4e808bed6cbc1aee21865", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 212 "C:\Users\User\source\repos\mvcPortal\Portal\Portal\Views\Admins\Details.cshtml"
                                                       WriteLiteral(Model.ID);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "362db69fdedb1ce964c3b5ef4e808bed6cbc1aee24123", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    </center>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Portal.Models.Admin> Html { get; private set; }
    }
}
#pragma warning restore 1591
