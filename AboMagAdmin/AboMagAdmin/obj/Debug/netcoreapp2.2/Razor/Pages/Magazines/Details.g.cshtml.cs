#pragma checksum "C:\Users\Baptiste Lequeu\Documents\GitHub\Projet-Final-2019\AboMagAdmin\AboMagAdmin\Pages\Magazines\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c5d6c40ac56759f753d3c23d05c1f895c258037"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AboMagAdmin.Pages.Magazines.Pages_Magazines_Details), @"mvc.1.0.razor-page", @"/Pages/Magazines/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Magazines/Details.cshtml", typeof(AboMagAdmin.Pages.Magazines.Pages_Magazines_Details), null)]
namespace AboMagAdmin.Pages.Magazines
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Baptiste Lequeu\Documents\GitHub\Projet-Final-2019\AboMagAdmin\AboMagAdmin\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Baptiste Lequeu\Documents\GitHub\Projet-Final-2019\AboMagAdmin\AboMagAdmin\Pages\_ViewImports.cshtml"
using AboMagAdmin;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c5d6c40ac56759f753d3c23d05c1f895c258037", @"/Pages/Magazines/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"089eac6559696061db1171388812caae60cfc7cb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Magazines_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Baptiste Lequeu\Documents\GitHub\Projet-Final-2019\AboMagAdmin\AboMagAdmin\Pages\Magazines\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(148, 129, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Magazine</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(278, 50, false);
#line 16 "C:\Users\Baptiste Lequeu\Documents\GitHub\Projet-Final-2019\AboMagAdmin\AboMagAdmin\Pages\Magazines\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Magazine.Titre));

#line default
#line hidden
            EndContext();
            BeginContext(328, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(390, 46, false);
#line 19 "C:\Users\Baptiste Lequeu\Documents\GitHub\Projet-Final-2019\AboMagAdmin\AboMagAdmin\Pages\Magazines\Details.cshtml"
       Write(Html.DisplayFor(model => model.Magazine.Titre));

#line default
#line hidden
            EndContext();
            BeginContext(436, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(497, 47, false);
#line 22 "C:\Users\Baptiste Lequeu\Documents\GitHub\Projet-Final-2019\AboMagAdmin\AboMagAdmin\Pages\Magazines\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Magazine.Nb));

#line default
#line hidden
            EndContext();
            BeginContext(544, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(606, 43, false);
#line 25 "C:\Users\Baptiste Lequeu\Documents\GitHub\Projet-Final-2019\AboMagAdmin\AboMagAdmin\Pages\Magazines\Details.cshtml"
       Write(Html.DisplayFor(model => model.Magazine.Nb));

#line default
#line hidden
            EndContext();
            BeginContext(649, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(710, 56, false);
#line 28 "C:\Users\Baptiste Lequeu\Documents\GitHub\Projet-Final-2019\AboMagAdmin\AboMagAdmin\Pages\Magazines\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Magazine.Description));

#line default
#line hidden
            EndContext();
            BeginContext(766, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(828, 52, false);
#line 31 "C:\Users\Baptiste Lequeu\Documents\GitHub\Projet-Final-2019\AboMagAdmin\AboMagAdmin\Pages\Magazines\Details.cshtml"
       Write(Html.DisplayFor(model => model.Magazine.Description));

#line default
#line hidden
            EndContext();
            BeginContext(880, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(941, 55, false);
#line 34 "C:\Users\Baptiste Lequeu\Documents\GitHub\Projet-Final-2019\AboMagAdmin\AboMagAdmin\Pages\Magazines\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Magazine.PrixAnnuel));

#line default
#line hidden
            EndContext();
            BeginContext(996, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1058, 51, false);
#line 37 "C:\Users\Baptiste Lequeu\Documents\GitHub\Projet-Final-2019\AboMagAdmin\AboMagAdmin\Pages\Magazines\Details.cshtml"
       Write(Html.DisplayFor(model => model.Magazine.PrixAnnuel));

#line default
#line hidden
            EndContext();
            BeginContext(1109, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1156, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c5d6c40ac56759f753d3c23d05c1f895c2580378174", async() => {
                BeginContext(1211, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 42 "C:\Users\Baptiste Lequeu\Documents\GitHub\Projet-Final-2019\AboMagAdmin\AboMagAdmin\Pages\Magazines\Details.cshtml"
                           WriteLiteral(Model.Magazine.Id);

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
            BeginContext(1219, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1227, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c5d6c40ac56759f753d3c23d05c1f895c25803710537", async() => {
                BeginContext(1249, 12, true);
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
            BeginContext(1265, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AboMagAdmin.Pages.Magazines.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AboMagAdmin.Pages.Magazines.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AboMagAdmin.Pages.Magazines.DetailsModel>)PageContext?.ViewData;
        public AboMagAdmin.Pages.Magazines.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
