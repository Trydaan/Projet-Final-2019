#pragma checksum "C:\Users\Baptiste Lequeu\Documents\GitHub\Projet-Final-2019\AboMagAdmin\AboMagAdmin\Pages\Users\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9deb707ad14822554ffcedc4e6e0ff54a5ed37c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AboMagAdmin.Pages.Users.Pages_Users_Details), @"mvc.1.0.razor-page", @"/Pages/Users/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Users/Details.cshtml", typeof(AboMagAdmin.Pages.Users.Pages_Users_Details), @"{id:int}")]
namespace AboMagAdmin.Pages.Users
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id:int}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9deb707ad14822554ffcedc4e6e0ff54a5ed37c4", @"/Pages/Users/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"089eac6559696061db1171388812caae60cfc7cb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Users_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            BeginContext(63, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Baptiste Lequeu\Documents\GitHub\Projet-Final-2019\AboMagAdmin\AboMagAdmin\Pages\Users\Details.cshtml"
  
    ViewData["Title"] = "Détail";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(154, 121, true);
            WriteLiteral("\r\n<h1>Détail du client</h1>\r\n\r\n<div>\r\n    \r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(276, 44, false);
#line 16 "C:\Users\Baptiste Lequeu\Documents\GitHub\Projet-Final-2019\AboMagAdmin\AboMagAdmin\Pages\Users\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.User.Nom));

#line default
#line hidden
            EndContext();
            BeginContext(320, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(382, 40, false);
#line 19 "C:\Users\Baptiste Lequeu\Documents\GitHub\Projet-Final-2019\AboMagAdmin\AboMagAdmin\Pages\Users\Details.cshtml"
       Write(Html.DisplayFor(model => model.User.Nom));

#line default
#line hidden
            EndContext();
            BeginContext(422, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(483, 47, false);
#line 22 "C:\Users\Baptiste Lequeu\Documents\GitHub\Projet-Final-2019\AboMagAdmin\AboMagAdmin\Pages\Users\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.User.Prenom));

#line default
#line hidden
            EndContext();
            BeginContext(530, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(592, 43, false);
#line 25 "C:\Users\Baptiste Lequeu\Documents\GitHub\Projet-Final-2019\AboMagAdmin\AboMagAdmin\Pages\Users\Details.cshtml"
       Write(Html.DisplayFor(model => model.User.Prenom));

#line default
#line hidden
            EndContext();
            BeginContext(635, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(696, 46, false);
#line 28 "C:\Users\Baptiste Lequeu\Documents\GitHub\Projet-Final-2019\AboMagAdmin\AboMagAdmin\Pages\Users\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.User.Email));

#line default
#line hidden
            EndContext();
            BeginContext(742, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(804, 42, false);
#line 31 "C:\Users\Baptiste Lequeu\Documents\GitHub\Projet-Final-2019\AboMagAdmin\AboMagAdmin\Pages\Users\Details.cshtml"
       Write(Html.DisplayFor(model => model.User.Email));

#line default
#line hidden
            EndContext();
            BeginContext(846, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(907, 54, false);
#line 34 "C:\Users\Baptiste Lequeu\Documents\GitHub\Projet-Final-2019\AboMagAdmin\AboMagAdmin\Pages\Users\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.User.DateNaissance));

#line default
#line hidden
            EndContext();
            BeginContext(961, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1023, 50, false);
#line 37 "C:\Users\Baptiste Lequeu\Documents\GitHub\Projet-Final-2019\AboMagAdmin\AboMagAdmin\Pages\Users\Details.cshtml"
       Write(Html.DisplayFor(model => model.User.DateNaissance));

#line default
#line hidden
            EndContext();
            BeginContext(1073, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1134, 54, false);
#line 40 "C:\Users\Baptiste Lequeu\Documents\GitHub\Projet-Final-2019\AboMagAdmin\AboMagAdmin\Pages\Users\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.User.LieuNaissance));

#line default
#line hidden
            EndContext();
            BeginContext(1188, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1250, 50, false);
#line 43 "C:\Users\Baptiste Lequeu\Documents\GitHub\Projet-Final-2019\AboMagAdmin\AboMagAdmin\Pages\Users\Details.cshtml"
       Write(Html.DisplayFor(model => model.User.LieuNaissance));

#line default
#line hidden
            EndContext();
            BeginContext(1300, 57, true);
            WriteLiteral("\r\n        </dd>\r\n        \r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1357, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9deb707ad14822554ffcedc4e6e0ff54a5ed37c49115", async() => {
                BeginContext(1408, 7, true);
                WriteLiteral("Valider");
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
#line 49 "C:\Users\Baptiste Lequeu\Documents\GitHub\Projet-Final-2019\AboMagAdmin\AboMagAdmin\Pages\Users\Details.cshtml"
                           WriteLiteral(Model.User.Id);

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
            BeginContext(1419, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1427, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9deb707ad14822554ffcedc4e6e0ff54a5ed37c411473", async() => {
                BeginContext(1449, 17, true);
                WriteLiteral("Retour à la liste");
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
            BeginContext(1470, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AboMagAdmin.Pages.Users.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AboMagAdmin.Pages.Users.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AboMagAdmin.Pages.Users.DetailsModel>)PageContext?.ViewData;
        public AboMagAdmin.Pages.Users.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
