#pragma checksum "D:\Cprojects\ProjectsForWork\MyBlogApp\MyBlogApp.General\Views\Profile\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42fad41b26f1b11553bb35dd247f197267b6fbd9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_Detail), @"mvc.1.0.view", @"/Views/Profile/Detail.cshtml")]
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
#nullable restore
#line 1 "D:\Cprojects\ProjectsForWork\MyBlogApp\MyBlogApp.General\Views\Profile\Detail.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42fad41b26f1b11553bb35dd247f197267b6fbd9", @"/Views/Profile/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5ce47ad42af177f962a6579dcccf7d35d63f30f", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProfileModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-top: 20px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UploadProfileImage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral(@"

<div class=""container body-content"">
    <div class=""row sectionHeader"">
        <div class=""sectionProfileHeading"">
            User Profile
        </div>
    </div>
    <div class=""row userProfile"">
        <div class=""col-md-4"">
            <div id=""userProfileImage""");
            BeginWriteAttribute("style", " style=\"", 386, "\"", 436, 4);
            WriteAttributeValue("", 394, "background-image:", 394, 17, true);
            WriteAttributeValue(" ", 411, "url(", 412, 5, true);
#nullable restore
#line 16 "D:\Cprojects\ProjectsForWork\MyBlogApp\MyBlogApp.General\Views\Profile\Detail.cshtml"
WriteAttributeValue("", 416, Model.ProfileImage, 416, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 435, ")", 435, 1, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n");
#nullable restore
#line 17 "D:\Cprojects\ProjectsForWork\MyBlogApp\MyBlogApp.General\Views\Profile\Detail.cshtml"
             if (User.Identity.Name == Model.UserName)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42fad41b26f1b11553bb35dd247f197267b6fbd97742", async() => {
                WriteLiteral(@"
                    <div id=""upload"">
                        <label class=""btn btn-secondary btn-file"">
                            Browse<input type=""file"" name=""file"" style=""display: none""/>
                        </label>
                    </div>
                    <button type=""submit"" id=""btnProfile"" class=""btn btn-primary"">Submit</button>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 27 "D:\Cprojects\ProjectsForWork\MyBlogApp\MyBlogApp.General\Views\Profile\Detail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n    <div class=\"col-md-8 profileDetail\">\r\n        <div id=\"userName\">");
#nullable restore
#line 31 "D:\Cprojects\ProjectsForWork\MyBlogApp\MyBlogApp.General\Views\Profile\Detail.cshtml"
                      Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 32 "D:\Cprojects\ProjectsForWork\MyBlogApp\MyBlogApp.General\Views\Profile\Detail.cshtml"
         if (@Model.IsAdmin)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span class=\"isAdmin\">Admin</span>\r\n");
#nullable restore
#line 35 "D:\Cprojects\ProjectsForWork\MyBlogApp\MyBlogApp.General\Views\Profile\Detail.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div id=\"userRating\">Current Rating: ");
#nullable restore
#line 36 "D:\Cprojects\ProjectsForWork\MyBlogApp\MyBlogApp.General\Views\Profile\Detail.cshtml"
                                        Write(Model.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div id=\"userEmailLabel\">Email: ");
#nullable restore
#line 37 "D:\Cprojects\ProjectsForWork\MyBlogApp\MyBlogApp.General\Views\Profile\Detail.cshtml"
                                   Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div id=\"userCreateLabel\">Member since: ");
#nullable restore
#line 38 "D:\Cprojects\ProjectsForWork\MyBlogApp\MyBlogApp.General\Views\Profile\Detail.cshtml"
                                           Write(Model.MemberSince);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<User> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProfileModel> Html { get; private set; }
    }
}
#pragma warning restore 1591