#pragma checksum "C:\Users\user\Documents\Daria\kurs_c#\daria_hornik\DariaHornikLab6Zadanie\DariaHornikLab6Zadanie\Views\Home\ShowAllAttractions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb50fd3c95a8788b1c7363fcd73270d95802be99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShowAllAttractions), @"mvc.1.0.view", @"/Views/Home/ShowAllAttractions.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ShowAllAttractions.cshtml", typeof(AspNetCore.Views_Home_ShowAllAttractions))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb50fd3c95a8788b1c7363fcd73270d95802be99", @"/Views/Home/ShowAllAttractions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c347239611bb81a4b901c759c87d274ebdccd69d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ShowAllAttractions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Attraction>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-image: url(https://cdn.pixabay.com/photo/2018/02/15/14/37/leaf-3155438__340.jpg); background-position: center; background-repeat:repeat"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 733, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9e9017e08fa49fcb93e7065d8045422", async() => {
                BeginContext(161, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
                BeginContext(194, 4, true);
                WriteLiteral("    ");
                EndContext();
#line 4 "C:\Users\user\Documents\Daria\kurs_c#\daria_hornik\DariaHornikLab6Zadanie\DariaHornikLab6Zadanie\Views\Home\ShowAllAttractions.cshtml"
      
        ViewData["Title"] = "Wszystkie atrakcje";
    

#line default
#line hidden
                BeginContext(260, 37, true);
                WriteLiteral("\r\n    <h2>Wszystkie atrakcje</h2>\r\n\r\n");
                EndContext();
#line 10 "C:\Users\user\Documents\Daria\kurs_c#\daria_hornik\DariaHornikLab6Zadanie\DariaHornikLab6Zadanie\Views\Home\ShowAllAttractions.cshtml"
     foreach (var attr in Model)
    {

#line default
#line hidden
                BeginContext(338, 31, true);
                WriteLiteral("        <div>\r\n            <h2>");
                EndContext();
                BeginContext(370, 9, false);
#line 13 "C:\Users\user\Documents\Daria\kurs_c#\daria_hornik\DariaHornikLab6Zadanie\DariaHornikLab6Zadanie\Views\Home\ShowAllAttractions.cshtml"
           Write(attr.Name);

#line default
#line hidden
                EndContext();
                BeginContext(379, 36, true);
                WriteLiteral("</h2>\r\n            <h4>Lokalizacja: ");
                EndContext();
                BeginContext(416, 10, false);
#line 14 "C:\Users\user\Documents\Daria\kurs_c#\daria_hornik\DariaHornikLab6Zadanie\DariaHornikLab6Zadanie\Views\Home\ShowAllAttractions.cshtml"
                        Write(attr.Place);

#line default
#line hidden
                EndContext();
                BeginContext(426, 30, true);
                WriteLiteral(" </h4>\r\n            <h4>Opis: ");
                EndContext();
                BeginContext(457, 16, false);
#line 15 "C:\Users\user\Documents\Daria\kurs_c#\daria_hornik\DariaHornikLab6Zadanie\DariaHornikLab6Zadanie\Views\Home\ShowAllAttractions.cshtml"
                 Write(attr.Description);

#line default
#line hidden
                EndContext();
                BeginContext(473, 28, true);
                WriteLiteral("</h4>\r\n            <h4>Typ: ");
                EndContext();
                BeginContext(502, 9, false);
#line 16 "C:\Users\user\Documents\Daria\kurs_c#\daria_hornik\DariaHornikLab6Zadanie\DariaHornikLab6Zadanie\Views\Home\ShowAllAttractions.cshtml"
                Write(attr.Type);

#line default
#line hidden
                EndContext();
                BeginContext(511, 30, true);
                WriteLiteral("</h4>\r\n            <h4>Ocena: ");
                EndContext();
                BeginContext(542, 10, false);
#line 17 "C:\Users\user\Documents\Daria\kurs_c#\daria_hornik\DariaHornikLab6Zadanie\DariaHornikLab6Zadanie\Views\Home\ShowAllAttractions.cshtml"
                  Write(attr.Grade);

#line default
#line hidden
                EndContext();
                BeginContext(552, 45, true);
                WriteLiteral("</h4>\r\n\r\n            <hr />\r\n        </div>\r\n");
                EndContext();
#line 21 "C:\Users\user\Documents\Daria\kurs_c#\daria_hornik\DariaHornikLab6Zadanie\DariaHornikLab6Zadanie\Views\Home\ShowAllAttractions.cshtml"
    }

#line default
#line hidden
                BeginContext(604, 8, true);
                WriteLiteral("    <h4>");
                EndContext();
                BeginContext(613, 16, false);
#line 22 "C:\Users\user\Documents\Daria\kurs_c#\daria_hornik\DariaHornikLab6Zadanie\DariaHornikLab6Zadanie\Views\Home\ShowAllAttractions.cshtml"
   Write(TempData["Info"]);

#line default
#line hidden
                EndContext();
                BeginContext(629, 30, true);
                WriteLiteral("</h4>\r\n\r\n\r\n    <div>\r\n        ");
                EndContext();
                BeginContext(660, 52, false);
#line 26 "C:\Users\user\Documents\Daria\kurs_c#\daria_hornik\DariaHornikLab6Zadanie\DariaHornikLab6Zadanie\Views\Home\ShowAllAttractions.cshtml"
   Write(Html.ActionLink("Powrót do strony głównej", "Index"));

#line default
#line hidden
                EndContext();
                BeginContext(712, 14, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Attraction>> Html { get; private set; }
    }
}
#pragma warning restore 1591
