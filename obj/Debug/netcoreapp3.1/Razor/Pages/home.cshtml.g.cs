#pragma checksum "/Users/josecisneros/sendsatTimeclock/Pages/home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5855b5a0cb2f2d6236e6f21e2a617a3a95499521"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(sendsatTimeclock.Pages.Pages_home), @"mvc.1.0.razor-page", @"/Pages/home.cshtml")]
namespace sendsatTimeclock.Pages
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
#line 1 "/Users/josecisneros/sendsatTimeclock/Pages/_ViewImports.cshtml"
using sendsatTimeclock;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5855b5a0cb2f2d6236e6f21e2a617a3a95499521", @"/Pages/home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f743446faf2b744a1fea176492a06d8ed30fc96", @"/Pages/_ViewImports.cshtml")]
    public class Pages_home : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "/Users/josecisneros/sendsatTimeclock/Pages/home.cshtml"
  
   ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(" \n<div class=\"text-center\">\n   <div class=\"card\" style=\"width: 100%;\">\n       <div class=\"card-body\">\n           <h5 class=\"card-title\" style=\"float: left;\">");
#nullable restore
#line 10 "/Users/josecisneros/sendsatTimeclock/Pages/home.cshtml"
                                                  Write(DateTime.Today.ToString("D"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n           <h5 class=\"card-title\" style=\"float: right;\">");
#nullable restore
#line 11 "/Users/josecisneros/sendsatTimeclock/Pages/home.cshtml"
                                                   Write(string.Format("{0:t}", DateTime.Now));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
           <table class=""table table-hover"">
               <thead>
                   <tr>
                   <th scope=""col"">Employee</th>
                   <th scope=""col"">Ext.</th>
                   <th scope=""col"">Message</th>
                   <th scope=""col"">In/Out</th>
                   <th scope=""col""></th>
                   <th scope=""col"">Action</th>
                   <th scope=""col""></th>
                   </tr>
               </thead>
               <tbody>
");
#nullable restore
#line 25 "/Users/josecisneros/sendsatTimeclock/Pages/home.cshtml"
                     foreach (var item in Model.User) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td>\n                            ");
#nullable restore
#line 28 "/Users/josecisneros/sendsatTimeclock/Pages/home.cshtml"
                       Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 31 "/Users/josecisneros/sendsatTimeclock/Pages/home.cshtml"
                       Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 34 "/Users/josecisneros/sendsatTimeclock/Pages/home.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 37 "/Users/josecisneros/sendsatTimeclock/Pages/home.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Ext));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 40 "/Users/josecisneros/sendsatTimeclock/Pages/home.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 43 "/Users/josecisneros/sendsatTimeclock/Pages/home.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Admin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 46 "/Users/josecisneros/sendsatTimeclock/Pages/home.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                    </tr>\n");
#nullable restore
#line 49 "/Users/josecisneros/sendsatTimeclock/Pages/home.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("               </tbody>\n           </table>\n           ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5855b5a0cb2f2d6236e6f21e2a617a3a954995217624", async() => {
                WriteLiteral("Admin");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
           <!-- Modal -->
           <div class=""modal fade"" id=""punchInOut"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
               <div class=""modal-dialog"">
                   <div class=""modal-content"">
                   <div class=""modal-header"">
                       <h5 class=""modal-title"" id=""exampleModalLabel"">Clock out as Jose Cisneros</h5>
                       <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                       <span aria-hidden=""true"">&times;</span>
                       </button>
                   </div>
                   <div class=""modal-body"">
                       ...
                   </div>
                   <div class=""modal-footer"">
                       <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                       <button type=""button"" class=""btn btn-primary"">Clock Out</button>
                   </div>
               </div>
           </div>");
            WriteLiteral("\n       </div>\n   </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<sendsatTimeclock.Pages.Index.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<sendsatTimeclock.Pages.Index.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<sendsatTimeclock.Pages.Index.IndexModel>)PageContext?.ViewData;
        public sendsatTimeclock.Pages.Index.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
