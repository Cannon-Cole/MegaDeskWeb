#pragma checksum "C:\Users\Stoddard\Documents\BYUI\cit365\MegaDeskWeb\MegaDesk\Pages\DataManipulation\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da6c944588549747084b3be5541103aae02147ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MegaDesk.Pages.DataManipulation.Pages_DataManipulation_Delete), @"mvc.1.0.razor-page", @"/Pages/DataManipulation/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/DataManipulation/Delete.cshtml", typeof(MegaDesk.Pages.DataManipulation.Pages_DataManipulation_Delete), null)]
namespace MegaDesk.Pages.DataManipulation
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Stoddard\Documents\BYUI\cit365\MegaDeskWeb\MegaDesk\Pages\_ViewImports.cshtml"
using MegaDesk;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da6c944588549747084b3be5541103aae02147ee", @"/Pages/DataManipulation/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"460365d825535bcbd8bf03b94cf81c137a23c898", @"/Pages/_ViewImports.cshtml")]
    public class Pages_DataManipulation_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Stoddard\Documents\BYUI\cit365\MegaDeskWeb\MegaDesk\Pages\DataManipulation\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(103, 170, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>DeskQuote</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(274, 51, false);
#line 16 "C:\Users\Stoddard\Documents\BYUI\cit365\MegaDeskWeb\MegaDesk\Pages\DataManipulation\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.Width));

#line default
#line hidden
            EndContext();
            BeginContext(325, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(369, 47, false);
#line 19 "C:\Users\Stoddard\Documents\BYUI\cit365\MegaDeskWeb\MegaDesk\Pages\DataManipulation\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.Width));

#line default
#line hidden
            EndContext();
            BeginContext(416, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(460, 51, false);
#line 22 "C:\Users\Stoddard\Documents\BYUI\cit365\MegaDeskWeb\MegaDesk\Pages\DataManipulation\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.Depth));

#line default
#line hidden
            EndContext();
            BeginContext(511, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(555, 47, false);
#line 25 "C:\Users\Stoddard\Documents\BYUI\cit365\MegaDeskWeb\MegaDesk\Pages\DataManipulation\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.Depth));

#line default
#line hidden
            EndContext();
            BeginContext(602, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(646, 53, false);
#line 28 "C:\Users\Stoddard\Documents\BYUI\cit365\MegaDeskWeb\MegaDesk\Pages\DataManipulation\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.Drawers));

#line default
#line hidden
            EndContext();
            BeginContext(699, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(743, 49, false);
#line 31 "C:\Users\Stoddard\Documents\BYUI\cit365\MegaDeskWeb\MegaDesk\Pages\DataManipulation\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.Drawers));

#line default
#line hidden
            EndContext();
            BeginContext(792, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(836, 54, false);
#line 34 "C:\Users\Stoddard\Documents\BYUI\cit365\MegaDeskWeb\MegaDesk\Pages\DataManipulation\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.Material));

#line default
#line hidden
            EndContext();
            BeginContext(890, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(934, 50, false);
#line 37 "C:\Users\Stoddard\Documents\BYUI\cit365\MegaDeskWeb\MegaDesk\Pages\DataManipulation\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.Material));

#line default
#line hidden
            EndContext();
            BeginContext(984, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1028, 50, false);
#line 40 "C:\Users\Stoddard\Documents\BYUI\cit365\MegaDeskWeb\MegaDesk\Pages\DataManipulation\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.Rush));

#line default
#line hidden
            EndContext();
            BeginContext(1078, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1122, 46, false);
#line 43 "C:\Users\Stoddard\Documents\BYUI\cit365\MegaDeskWeb\MegaDesk\Pages\DataManipulation\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.Rush));

#line default
#line hidden
            EndContext();
            BeginContext(1168, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1212, 50, false);
#line 46 "C:\Users\Stoddard\Documents\BYUI\cit365\MegaDeskWeb\MegaDesk\Pages\DataManipulation\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1262, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1306, 46, false);
#line 49 "C:\Users\Stoddard\Documents\BYUI\cit365\MegaDeskWeb\MegaDesk\Pages\DataManipulation\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1352, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1396, 50, false);
#line 52 "C:\Users\Stoddard\Documents\BYUI\cit365\MegaDeskWeb\MegaDesk\Pages\DataManipulation\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1446, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1490, 46, false);
#line 55 "C:\Users\Stoddard\Documents\BYUI\cit365\MegaDeskWeb\MegaDesk\Pages\DataManipulation\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1536, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1580, 51, false);
#line 58 "C:\Users\Stoddard\Documents\BYUI\cit365\MegaDeskWeb\MegaDesk\Pages\DataManipulation\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.Total));

#line default
#line hidden
            EndContext();
            BeginContext(1631, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1675, 47, false);
#line 61 "C:\Users\Stoddard\Documents\BYUI\cit365\MegaDeskWeb\MegaDesk\Pages\DataManipulation\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.Total));

#line default
#line hidden
            EndContext();
            BeginContext(1722, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1760, 211, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c98b9baca2a74c65b66165cba6f38b9c", async() => {
                BeginContext(1780, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1790, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "601ebc2787f04907a2b350dc2eaca59f", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 66 "C:\Users\Stoddard\Documents\BYUI\cit365\MegaDeskWeb\MegaDesk\Pages\DataManipulation\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DeskQuote.ID);

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
                BeginContext(1836, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1920, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea61ab823d4d42138d2f17fac4236ac9", async() => {
                    BeginContext(1942, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1958, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1971, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MegaDesk.Pages.DataManipulation.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MegaDesk.Pages.DataManipulation.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MegaDesk.Pages.DataManipulation.DeleteModel>)PageContext?.ViewData;
        public MegaDesk.Pages.DataManipulation.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
