#pragma checksum "D:\Cprojects\ProjectsForWork\MyBlogApp\MyBlogApp.General\Views\Account\Lockout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c455d19eee7e3c76e68cc0c8d0b232a19bfd3c5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Lockout), @"mvc.1.0.view", @"/Views/Account/Lockout.cshtml")]
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
#line 1 "D:\Cprojects\ProjectsForWork\MyBlogApp\MyBlogApp.General\Views\_ViewImports.cshtml"
using MyBlogApp.General;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Cprojects\ProjectsForWork\MyBlogApp\MyBlogApp.General\Views\_ViewImports.cshtml"
using MyBlogApp.General.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Cprojects\ProjectsForWork\MyBlogApp\MyBlogApp.General\Views\_ViewImports.cshtml"
using MyBlogApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Cprojects\ProjectsForWork\MyBlogApp\MyBlogApp.General\Views\_ViewImports.cshtml"
using MyBlogApp.General.Models.Forum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Cprojects\ProjectsForWork\MyBlogApp\MyBlogApp.General\Views\_ViewImports.cshtml"
using MyBlogApp.General.Models.Post;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Cprojects\ProjectsForWork\MyBlogApp\MyBlogApp.General\Views\_ViewImports.cshtml"
using MyBlogApp.General.Models.Search;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Cprojects\ProjectsForWork\MyBlogApp\MyBlogApp.General\Views\_ViewImports.cshtml"
using MyBlogApp.General.Models.User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Cprojects\ProjectsForWork\MyBlogApp\MyBlogApp.General\Views\_ViewImports.cshtml"
using MyBlogApp.General.Models.Reply;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Cprojects\ProjectsForWork\MyBlogApp\MyBlogApp.General\Views\_ViewImports.cshtml"
using MyBlogApp.General.Models.AccountViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c455d19eee7e3c76e68cc0c8d0b232a19bfd3c5c", @"/Views/Account/Lockout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5ce47ad42af177f962a6579dcccf7d35d63f30f", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Lockout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Cprojects\ProjectsForWork\MyBlogApp\MyBlogApp.General\Views\Account\Lockout.cshtml"
  
    ViewData["Title"] = "Locked out";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        <h3 class=\"text-danger\">");
#nullable restore
#line 7 "D:\Cprojects\ProjectsForWork\MyBlogApp\MyBlogApp.General\Views\Account\Lockout.cshtml"
                           Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <p class=\"text-danger\">This account has been locked out, please try again later.</p>\r\n    </div>\r\n</div>");
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
