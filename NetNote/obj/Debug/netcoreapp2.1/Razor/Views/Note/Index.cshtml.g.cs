#pragma checksum "/Users/zhanghq/Documents/GitHub/NetNoteCore/NetNote/Views/Note/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de6cdd9d083b882741d509e7910c24c52a78ed63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Note_Index), @"mvc.1.0.view", @"/Views/Note/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Note/Index.cshtml", typeof(AspNetCore.Views_Note_Index))]
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
#line 1 "/Users/zhanghq/Documents/GitHub/NetNoteCore/NetNote/Views/_ViewImports.cshtml"
using NetNote;

#line default
#line hidden
#line 2 "/Users/zhanghq/Documents/GitHub/NetNoteCore/NetNote/Views/_ViewImports.cshtml"
using NetNote.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de6cdd9d083b882741d509e7910c24c52a78ed63", @"/Views/Note/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06ca0ce1c1a789cbc8243d4e78af112bf3a1537b", @"/Views/_ViewImports.cshtml")]
    public class Views_Note_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<NetNote.Models.Note>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "/Users/zhanghq/Documents/GitHub/NetNoteCore/NetNote/Views/Note/Index.cshtml"
  
    var pageindex = Convert.ToInt32(ViewBag.PageIndex);
    var pagecount = Convert.ToInt32(ViewBag.PageCount);
    var pagestart = pageindex - 2 > 0 ? pageindex - 2 : 1;
    var pageend = pageindex + 2 >= pagecount ? pagecount : pagestart + 4;

#line default
#line hidden
            BeginContext(290, 62, true);
            WriteLiteral("<div class=\"container-fluid\">\r\n    <div class=\"row\">\r\n        ");
            EndContext();
            BeginContext(352, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f28ea8b90d584c2a94de34072385f2a6", async() => {
                BeginContext(372, 6, true);
                WriteLiteral("添加Note");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(382, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 12 "/Users/zhanghq/Documents/GitHub/NetNoteCore/NetNote/Views/Note/Index.cshtml"
     foreach (var item in Model)
    {
        

#line default
#line hidden
#line 14 "/Users/zhanghq/Documents/GitHub/NetNoteCore/NetNote/Views/Note/Index.cshtml"
         if (string.IsNullOrEmpty(item.Password))
        {

#line default
#line hidden
            BeginContext(499, 51, true);
            WriteLiteral("            <div class=\"row\">\r\n                <h3>");
            EndContext();
            BeginContext(551, 10, false);
#line 17 "/Users/zhanghq/Documents/GitHub/NetNoteCore/NetNote/Views/Note/Index.cshtml"
               Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(561, 30, true);
            WriteLiteral("</h3>\r\n                <h5>类型：");
            EndContext();
            BeginContext(592, 14, false);
#line 18 "/Users/zhanghq/Documents/GitHub/NetNoteCore/NetNote/Views/Note/Index.cshtml"
                  Write(item.Type.Name);

#line default
#line hidden
            EndContext();
            BeginContext(606, 43, true);
            WriteLiteral("</h5>\r\n                <div class=\"content\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 649, "\"", 665, 2);
            WriteAttributeValue("", 654, "md_", 654, 3, true);
#line 19 "/Users/zhanghq/Documents/GitHub/NetNoteCore/NetNote/Views/Note/Index.cshtml"
WriteAttributeValue("", 657, item.Id, 657, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(666, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(668, 12, false);
#line 19 "/Users/zhanghq/Documents/GitHub/NetNoteCore/NetNote/Views/Note/Index.cshtml"
                                                 Write(item.Content);

#line default
#line hidden
            EndContext();
            BeginContext(680, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 20 "/Users/zhanghq/Documents/GitHub/NetNoteCore/NetNote/Views/Note/Index.cshtml"
                 if (!string.IsNullOrEmpty(item.Attachment))
                {

#line default
#line hidden
            BeginContext(769, 22, true);
            WriteLiteral("                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 791, "\"", 814, 1);
#line 22 "/Users/zhanghq/Documents/GitHub/NetNoteCore/NetNote/Views/Note/Index.cshtml"
WriteAttributeValue("", 798, item.Attachment, 798, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(815, 9, true);
            WriteLiteral(">下载</a>\r\n");
            EndContext();
#line 23 "/Users/zhanghq/Documents/GitHub/NetNoteCore/NetNote/Views/Note/Index.cshtml"
                }

#line default
#line hidden
            BeginContext(843, 44, true);
            WriteLiteral("                <hr />\r\n            </div>\r\n");
            EndContext();
#line 26 "/Users/zhanghq/Documents/GitHub/NetNoteCore/NetNote/Views/Note/Index.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(923, 29, true);
            WriteLiteral("            <div class=\"row\">");
            EndContext();
            BeginContext(952, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d1a6b96ff7b464b997f682eb25c66bf", async() => {
                BeginContext(999, 5, true);
                WriteLiteral("内容已加密");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 29 "/Users/zhanghq/Documents/GitHub/NetNoteCore/NetNote/Views/Note/Index.cshtml"
                                                      WriteLiteral(item.Id);

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
            BeginContext(1008, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 30 "/Users/zhanghq/Documents/GitHub/NetNoteCore/NetNote/Views/Note/Index.cshtml"
        }

#line default
#line hidden
#line 30 "/Users/zhanghq/Documents/GitHub/NetNoteCore/NetNote/Views/Note/Index.cshtml"
         

    }

#line default
#line hidden
            BeginContext(1036, 55, true);
            WriteLiteral("</div>\r\n<nav>\r\n    <ul class=\"pagination\">\r\n        <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1091, "\"", 1134, 1);
#line 36 "/Users/zhanghq/Documents/GitHub/NetNoteCore/NetNote/Views/Note/Index.cshtml"
WriteAttributeValue("", 1099, pageindex == 1 ? "disabled" : "", 1099, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1135, 15, true);
            WriteLiteral(">\r\n            ");
            EndContext();
            BeginContext(1150, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a37dc6f3de8495b804712b89ece4ba5", async() => {
                BeginContext(1232, 7, true);
                WriteLiteral("&laquo;");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageindex", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 37 "/Users/zhanghq/Documents/GitHub/NetNoteCore/NetNote/Views/Note/Index.cshtml"
                                            WriteLiteral(pageindex == 1 ? 1 : pageindex - 1);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageindex"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageindex", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageindex"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1243, 17, true);
            WriteLiteral("\r\n        </li>\r\n");
            EndContext();
#line 39 "/Users/zhanghq/Documents/GitHub/NetNoteCore/NetNote/Views/Note/Index.cshtml"
         for (int i = pagestart; i <= pageend; i++)
        {

#line default
#line hidden
            BeginContext(1324, 16, true);
            WriteLiteral("            <li ");
            EndContext();
            BeginContext(1342, 36, false);
#line 41 "/Users/zhanghq/Documents/GitHub/NetNoteCore/NetNote/Views/Note/Index.cshtml"
            Write(pageindex == i ? "class=active" : "");

#line default
#line hidden
            EndContext();
            BeginContext(1379, 19, true);
            WriteLiteral(">\r\n                ");
            EndContext();
            BeginContext(1398, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a7b03607c8747a68c6074127f13ae1f", async() => {
                BeginContext(1446, 1, false);
#line 42 "/Users/zhanghq/Documents/GitHub/NetNoteCore/NetNote/Views/Note/Index.cshtml"
                                                          Write(i);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageindex", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 42 "/Users/zhanghq/Documents/GitHub/NetNoteCore/NetNote/Views/Note/Index.cshtml"
                                               WriteLiteral(i);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageindex"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageindex", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageindex"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1451, 21, true);
            WriteLiteral("\r\n            </li>\r\n");
            EndContext();
#line 44 "/Users/zhanghq/Documents/GitHub/NetNoteCore/NetNote/Views/Note/Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1483, 11, true);
            WriteLiteral("        <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1494, "\"", 1545, 1);
#line 45 "/Users/zhanghq/Documents/GitHub/NetNoteCore/NetNote/Views/Note/Index.cshtml"
WriteAttributeValue("", 1502, pageindex == pagecount ? "disabled" : "", 1502, 43, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1546, 15, true);
            WriteLiteral(">\r\n            ");
            EndContext();
            BeginContext(1561, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "822f20007e214236a0bf07ed3ed4e43a", async() => {
                BeginContext(1659, 7, true);
                WriteLiteral("&raquo;");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageindex", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 46 "/Users/zhanghq/Documents/GitHub/NetNoteCore/NetNote/Views/Note/Index.cshtml"
                                            WriteLiteral(pageindex == pagecount ? pagecount : pageindex + 1);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageindex"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageindex", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageindex"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1670, 36, true);
            WriteLiteral("\r\n        </li>\r\n\r\n    </ul>\r\n</nav>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<NetNote.Models.Note>> Html { get; private set; }
    }
}
#pragma warning restore 1591
