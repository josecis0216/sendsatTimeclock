#pragma checksum "/Users/josecisneros/sendsatTimeclock/Pages/admin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d090758e29412abe0f11ecbd26e2763ef1bb64d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(sendsatTimeclock.Pages.Pages_admin), @"mvc.1.0.razor-page", @"/Pages/admin.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d090758e29412abe0f11ecbd26e2763ef1bb64d", @"/Pages/admin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f743446faf2b744a1fea176492a06d8ed30fc96", @"/Pages/_ViewImports.cshtml")]
    public class Pages_admin : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/josecisneros/sendsatTimeclock/Pages/admin.cshtml"
  
    ViewData["Title"] = "Time Clock Admin";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 6 "/Users/josecisneros/sendsatTimeclock/Pages/admin.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<div class=""text-center"">
    <div class=""card"" style=""width: 18rem;"">
        <div class=""card-body"">
            <h5 class=""card-title"">Time Clock Admin</h5>
            <ul class=""nav"">
                <li class=""nav-item"">
                    <a class=""nav-link active"" href=""#"">Admin Home</a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""#"">Users</a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""#"">Add User</a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""#"">Back to Time Clock</a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""#"">Logout</a>
                </li>
            </ul>
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AdminModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AdminModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AdminModel>)PageContext?.ViewData;
        public AdminModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591