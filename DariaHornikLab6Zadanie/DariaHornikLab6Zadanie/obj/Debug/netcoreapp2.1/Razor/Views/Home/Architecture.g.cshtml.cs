#pragma checksum "C:\Users\user\Documents\Daria\kurs_c#\daria_hornik\DariaHornikLab6Zadanie\DariaHornikLab6Zadanie\Views\Home\Architecture.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1929b7fd142a650e8236196cc8544670fb982826"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Architecture), @"mvc.1.0.view", @"/Views/Home/Architecture.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Architecture.cshtml", typeof(AspNetCore.Views_Home_Architecture))]
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
#line 1 "C:\Users\user\Documents\Daria\kurs_c#\daria_hornik\DariaHornikLab6Zadanie\DariaHornikLab6Zadanie\Views\_ViewImports.cshtml"
using DariaHornikLab6Zadanie;

#line default
#line hidden
#line 2 "C:\Users\user\Documents\Daria\kurs_c#\daria_hornik\DariaHornikLab6Zadanie\DariaHornikLab6Zadanie\Views\_ViewImports.cshtml"
using DariaHornikLab6Zadanie.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1929b7fd142a650e8236196cc8544670fb982826", @"/Views/Home/Architecture.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c347239611bb81a4b901c759c87d274ebdccd69d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Architecture : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-image: url(https://cdn.pixabay.com/photo/2018/02/15/14/37/leaf-3155438__340.jpg); background-position: center; background-repeat:repea"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 598, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba892657b0c64ec6b7cfe8ab8d59bd10", async() => {
                BeginContext(160, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 3 "C:\Users\user\Documents\Daria\kurs_c#\daria_hornik\DariaHornikLab6Zadanie\DariaHornikLab6Zadanie\Views\Home\Architecture.cshtml"
      
        ViewData["Title"] = "Wrocławska architektura";
    

#line default
#line hidden
                BeginContext(235, 40, true);
                WriteLiteral("\r\n    <h2>Wrocławska architektura</h2>\r\n");
                EndContext();
#line 8 "C:\Users\user\Documents\Daria\kurs_c#\daria_hornik\DariaHornikLab6Zadanie\DariaHornikLab6Zadanie\Views\Home\Architecture.cshtml"
     foreach (var attr in Model)
    {

#line default
#line hidden
                BeginContext(316, 31, true);
                WriteLiteral("        <div>\r\n            <h2>");
                EndContext();
                BeginContext(348, 9, false);
#line 11 "C:\Users\user\Documents\Daria\kurs_c#\daria_hornik\DariaHornikLab6Zadanie\DariaHornikLab6Zadanie\Views\Home\Architecture.cshtml"
           Write(attr.Name);

#line default
#line hidden
                EndContext();
                BeginContext(357, 36, true);
                WriteLiteral("</h2>\r\n            <h4>Lokalizacja: ");
                EndContext();
                BeginContext(394, 10, false);
#line 12 "C:\Users\user\Documents\Daria\kurs_c#\daria_hornik\DariaHornikLab6Zadanie\DariaHornikLab6Zadanie\Views\Home\Architecture.cshtml"
                        Write(attr.Place);

#line default
#line hidden
                EndContext();
                BeginContext(404, 30, true);
                WriteLiteral(" </h4>\r\n            <h4>Opis: ");
                EndContext();
                BeginContext(435, 16, false);
#line 13 "C:\Users\user\Documents\Daria\kurs_c#\daria_hornik\DariaHornikLab6Zadanie\DariaHornikLab6Zadanie\Views\Home\Architecture.cshtml"
                 Write(attr.Description);

#line default
#line hidden
                EndContext();
                BeginContext(451, 45, true);
                WriteLiteral("</h4>\r\n            <hr />\r\n\r\n        </div>\r\n");
                EndContext();
#line 17 "C:\Users\user\Documents\Daria\kurs_c#\daria_hornik\DariaHornikLab6Zadanie\DariaHornikLab6Zadanie\Views\Home\Architecture.cshtml"
    }

#line default
#line hidden
                BeginContext(503, 21, true);
                WriteLiteral("\r\n    <div>\r\n        ");
                EndContext();
                BeginContext(525, 52, false);
#line 20 "C:\Users\user\Documents\Daria\kurs_c#\daria_hornik\DariaHornikLab6Zadanie\DariaHornikLab6Zadanie\Views\Home\Architecture.cshtml"
   Write(Html.ActionLink("Powrót do strony głównej", "Index"));

#line default
#line hidden
                EndContext();
                BeginContext(577, 14, true);
                WriteLiteral("\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
