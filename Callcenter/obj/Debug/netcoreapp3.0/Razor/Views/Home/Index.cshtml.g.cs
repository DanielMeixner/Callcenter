#pragma checksum "C:\Users\fapo.SPOTTOG\Documents\gdv\Callcenter\Callcenter\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "506e13dc50423d271467277e2e76d2f4c6716630"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\fapo.SPOTTOG\Documents\gdv\Callcenter\Callcenter\Views\_ViewImports.cshtml"
using Callcenter;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fapo.SPOTTOG\Documents\gdv\Callcenter\Callcenter\Views\_ViewImports.cshtml"
using Callcenter.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"506e13dc50423d271467277e2e76d2f4c6716630", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c66f1195914a2836811753a222d04fd95172ba92", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Collections.Generic.List<Callcenter.Models.Entry>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/signalr/dist/browser/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\fapo.SPOTTOG\Documents\gdv\Callcenter\Callcenter\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Callcenter";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .marked {
        background-color: rosybrown;
    }

    .other {
        background-color: aqua;
    }
</style>
<script type=""text/javascript"">
    function MarkItem(elmid) {
        var element = document.getElementById(elmid);
        if (!element.classList.contains(""other"")) {
            element.classList.add(""marked"");
            var xhttp = new XMLHttpRequest();
            xhttp.open(""POST"", ""/Entry"", true);
            xhttp.setRequestHeader(""Content-type"", ""application/x-www-form-urlencoded"");
            xhttp.send(""id=""+elmid);
        } else {
            alert(""Element "" + elmid + "" wird schon bearbeiter"");
        }
    }
    function DelItem(elmid) {
        var element = document.getElementById(elmid);
        if (element.classList.contains(""marked"")) {
            window.location.href = ""/Entry/Delete/"" + elmid;
        } else {
            alert(""Element "" + elmid + "" nicht als bearbeitet Markiert"");
        }
    }
</script>
<div class=""text-cen");
            WriteLiteral("ter\">\r\n    <h1 class=\"display-4\">");
#nullable restore
#line 37 "C:\Users\fapo.SPOTTOG\Documents\gdv\Callcenter\Callcenter\Views\Home\Index.cshtml"
                     Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n</div>\r\n<div id=\"tablespace\">\r\n    <table style=\"width: 100% \">\r\n        <tr>\r\n            <th>Timestamp</th>\r\n            <th>phone</th>\r\n            <th>requestText</th>\r\n            <th>Mark</th>\r\n            <th>Finish</th>\r\n        </tr>\r\n");
#nullable restore
#line 48 "C:\Users\fapo.SPOTTOG\Documents\gdv\Callcenter\Callcenter\Views\Home\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr");
            BeginWriteAttribute("id", " id=\"", 1501, "\"", 1514, 1);
#nullable restore
#line 50 "C:\Users\fapo.SPOTTOG\Documents\gdv\Callcenter\Callcenter\Views\Home\Index.cshtml"
WriteAttributeValue("", 1506, item.id, 1506, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 1515, "\"", 1536, 1);
#nullable restore
#line 50 "C:\Users\fapo.SPOTTOG\Documents\gdv\Callcenter\Callcenter\Views\Home\Index.cshtml"
WriteAttributeValue("", 1523, item.CString, 1523, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <td>");
#nullable restore
#line 51 "C:\Users\fapo.SPOTTOG\Documents\gdv\Callcenter\Callcenter\Views\Home\Index.cshtml"
               Write(item.timestamp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 52 "C:\Users\fapo.SPOTTOG\Documents\gdv\Callcenter\Callcenter\Views\Home\Index.cshtml"
               Write(item.phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 53 "C:\Users\fapo.SPOTTOG\Documents\gdv\Callcenter\Callcenter\Views\Home\Index.cshtml"
               Write(item.requestText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td");
            BeginWriteAttribute("onclick", " onclick=\"", 1683, "\"", 1713, 3);
            WriteAttributeValue("", 1693, "MarkItem(\'", 1693, 10, true);
#nullable restore
#line 54 "C:\Users\fapo.SPOTTOG\Documents\gdv\Callcenter\Callcenter\Views\Home\Index.cshtml"
WriteAttributeValue("", 1703, item.id, 1703, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1711, "\')", 1711, 2, true);
            EndWriteAttribute();
            WriteLiteral(">O</td>\r\n                <td");
            BeginWriteAttribute("onclick", " onclick=\"", 1742, "\"", 1771, 3);
            WriteAttributeValue("", 1752, "DelItem(\'", 1752, 9, true);
#nullable restore
#line 55 "C:\Users\fapo.SPOTTOG\Documents\gdv\Callcenter\Callcenter\Views\Home\Index.cshtml"
WriteAttributeValue("", 1761, item.id, 1761, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1769, "\')", 1769, 2, true);
            EndWriteAttribute();
            WriteLiteral(">X</td>\r\n            </tr>\r\n");
#nullable restore
#line 57 "C:\Users\fapo.SPOTTOG\Documents\gdv\Callcenter\Callcenter\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "506e13dc50423d271467277e2e76d2f4c67166308429", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script type=""text/javascript"">
    ""use strict"";
    var connection = new signalR.HubConnectionBuilder().withUrl(""/Hub"").build();
    connection.start().then(function () {
        console.log(""SignalR Connected"");
    }).catch(function (err) {
        return console.error(err.toString());
    });
    connection.on(""marked"", function (id) {
        console.log(""SignalR - Marked: "" + id);
        var element = document.getElementById(id);
        if (element && element != undefined && element != null && !element.classList.contains(""marked"")) {
            element.classList.add(""other"");
        }
    });
    connection.on(""delete"", function (id) {
        console.log(""SignalR - Delete: "" + id);
        var element = document.getElementById(id);
        if (element && element != undefined && element != null) {
            element.parentElement.removeChild(element);
        }
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<System.Collections.Generic.List<Callcenter.Models.Entry>> Html { get; private set; }
    }
}
#pragma warning restore 1591
