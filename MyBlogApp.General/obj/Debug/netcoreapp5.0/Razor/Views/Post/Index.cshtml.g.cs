#pragma checksum "D:\Cprojects\ProjectsForWork\MyBlogApp\MyBlogApp.General\Views\Post\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c5113411060af58407e4a53c62e7de60d629532"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_Index), @"mvc.1.0.view", @"/Views/Post/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c5113411060af58407e4a53c62e7de60d629532", @"/Views/Post/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5ce47ad42af177f962a6579dcccf7d35d63f30f", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PostIndexModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Forum", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Topic", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Reply", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateReply", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-newReply"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"container body-content\">\r\n    <div class=\"row postHeader\">\r\n        <div class=\"postHeading\">\r\n            <div class=\"postIndexTitle\">\r\n                ");
#nullable restore
#line 7 "D:\Cprojects\ProjectsForWork\MyBlogApp\MyBlogApp.General\Views\Post\Index.cshtml"
           Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div id=\"headingBtn\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c5113411060af58407e4a53c62e7de60d6295327500", async() => {
                WriteLiteral("Back to ");
#nullable restore
#line 9 "D:\Cprojects\ProjectsForWork\MyBlogApp\MyBlogApp.General\Views\Post\Index.cshtml"
                                                                                                                                       Write(Model.ForumName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 9 "D:\Cprojects\ProjectsForWork\MyBlogApp\MyBlogApp.General\Views\Post\Index.cshtml"
                                                                                WriteLiteral(Model.ForumId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row\" id=\"postIndexContent\">\r\n        <div class=\"col-md-3 postAuthorContainer\">\r\n            <div class=\"postAuthorImage\"");
            BeginWriteAttribute("style", " style=\"", 559, "\"", 608, 4);
            WriteAttributeValue("", 567, "background-image:", 567, 17, true);
            WriteAttributeValue(" ", 584, "url(", 585, 5, true);
#nullable restore
#line 15 "D:\Cprojects\ProjectsForWork\MyBlogApp\MyBlogApp.General\Views\Post\Index.cshtml"
WriteAttributeValue("", 589, Model.AuthorImage, 589, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 607, ")", 607, 1, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c5113411060af58407e4a53c62e7de60d62953211097", async() => {
#nullable restore
#line 16 "D:\Cprojects\ProjectsForWork\MyBlogApp\MyBlogApp.General\Views\Post\Index.cshtml"
                                                                                      Write(Model.AuthorName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 16 "D:\Cprojects\ProjectsForWork\MyBlogApp\MyBlogApp.General\Views\Post\Index.cshtml"
                                                              WriteLiteral(Model.AuthorId);

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
            WriteLiteral("\r\n            <div class=\"postDate\">");
#nullable restore
#line 17 "D:\Cprojects\ProjectsForWork\MyBlogApp\MyBlogApp.General\Views\Post\Index.cshtml"
                             Write(Model.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 18 "D:\Cprojects\ProjectsForWork\MyBlogApp\MyBlogApp.General\Views\Post\Index.cshtml"
             if (Model.IsAuthorAdmin)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"isAdmin smaller\">Admin</span>\r\n");
#nullable restore
#line 21 "D:\Cprojects\ProjectsForWork\MyBlogApp\MyBlogApp.General\Views\Post\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"col-md-9 postContentContainer\">\r\n            <div class=\"postContent\">\r\n                ");
#nullable restore
#line 25 "D:\Cprojects\ProjectsForWork\MyBlogApp\MyBlogApp.General\Views\Post\Index.cshtml"
           Write(Html.Raw(Model.PostContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row\" id=\"replyDevider\"></div>\r\n\r\n");
#nullable restore
#line 32 "D:\Cprojects\ProjectsForWork\MyBlogApp\MyBlogApp.General\Views\Post\Index.cshtml"
     if (User.Identity.IsAuthenticated)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <span>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c5113411060af58407e4a53c62e7de60d62953215315", async() => {
                WriteLiteral("Reply for this post");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "D:\Cprojects\ProjectsForWork\MyBlogApp\MyBlogApp.General\Views\Post\Index.cshtml"
                                                                       WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</span>\r\n        </div>\r\n");
#nullable restore
#line 37 "D:\Cprojects\ProjectsForWork\MyBlogApp\MyBlogApp.General\Views\Post\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "D:\Cprojects\ProjectsForWork\MyBlogApp\MyBlogApp.General\Views\Post\Index.cshtml"
     if (@Model.PostReplies.Any())
    {
        foreach (var repl in Model.PostReplies)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row replyContent\">\r\n                <div class=\"col-md-3 replyAuthorContainer\">\r\n                    <div class=\"postAuthorImage\"");
            BeginWriteAttribute("style", " style=\"", 1679, "\"", 1727, 4);
            WriteAttributeValue("", 1687, "background-image:", 1687, 17, true);
            WriteAttributeValue(" ", 1704, "url(", 1705, 5, true);
#nullable restore
#line 44 "D:\Cprojects\ProjectsForWork\MyBlogApp\MyBlogApp.General\Views\Post\Index.cshtml"
WriteAttributeValue("", 1709, repl.AuthorImage, 1709, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1726, ")", 1726, 1, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c5113411060af58407e4a53c62e7de60d62953219069", async() => {
#nullable restore
#line 45 "D:\Cprojects\ProjectsForWork\MyBlogApp\MyBlogApp.General\Views\Post\Index.cshtml"
                                                                                             Write(repl.AuthorName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "D:\Cprojects\ProjectsForWork\MyBlogApp\MyBlogApp.General\Views\Post\Index.cshtml"
                                                                      WriteLiteral(repl.AuthorId);

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
            WriteLiteral("\r\n");
#nullable restore
#line 46 "D:\Cprojects\ProjectsForWork\MyBlogApp\MyBlogApp.General\Views\Post\Index.cshtml"
                     if (repl.IsAuthorAdmin)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"isAdmin smaller\">Admin</span>\r\n                        <br />\r\n");
#nullable restore
#line 50 "D:\Cprojects\ProjectsForWork\MyBlogApp\MyBlogApp.General\Views\Post\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>");
#nullable restore
#line 51 "D:\Cprojects\ProjectsForWork\MyBlogApp\MyBlogApp.General\Views\Post\Index.cshtml"
                     Write(repl.CreatedDate.ToString(""));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n                <div class=\"col=md-9 replyContentContainer\">\r\n                    <div class=\"postContent\">\r\n                        ");
#nullable restore
#line 55 "D:\Cprojects\ProjectsForWork\MyBlogApp\MyBlogApp.General\Views\Post\Index.cshtml"
                   Write(Html.Raw(repl.ReplyContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 59 "D:\Cprojects\ProjectsForWork\MyBlogApp\MyBlogApp.General\Views\Post\Index.cshtml"
        }
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"noPosts\">\r\n            <h3>No posts to show yet.</h3>\r\n        </div>\r\n");
#nullable restore
#line 66 "D:\Cprojects\ProjectsForWork\MyBlogApp\MyBlogApp.General\Views\Post\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PostIndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
