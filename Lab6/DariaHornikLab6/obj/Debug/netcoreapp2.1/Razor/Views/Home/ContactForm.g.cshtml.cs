#pragma checksum "C:\Users\user\Documents\Daria\kurs_c#\DariaHornikLab6\DariaHornikLab6\Views\Home\ContactForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29756a6165e1d1591cdba344e149163d1f5653c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ContactForm), @"mvc.1.0.view", @"/Views/Home/ContactForm.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ContactForm.cshtml", typeof(AspNetCore.Views_Home_ContactForm))]
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
#line 1 "C:\Users\user\Documents\Daria\kurs_c#\DariaHornikLab6\DariaHornikLab6\Views\_ViewImports.cshtml"
using DariaHornikLab6;

#line default
#line hidden
#line 2 "C:\Users\user\Documents\Daria\kurs_c#\DariaHornikLab6\DariaHornikLab6\Views\_ViewImports.cshtml"
using DariaHornikLab6.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29756a6165e1d1591cdba344e149163d1f5653c3", @"/Views/Home/ContactForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c27c93ec28944b37b0365d8317357e91ed471524", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ContactForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContactFormViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\user\Documents\Daria\kurs_c#\DariaHornikLab6\DariaHornikLab6\Views\Home\ContactForm.cshtml"
  
    ViewData["Title"] = "ContactForm";

#line default
#line hidden
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\user\Documents\Daria\kurs_c#\DariaHornikLab6\DariaHornikLab6\Views\Home\ContactForm.cshtml"
  
    ViewBag.Title = "Exercise5";

#line default
#line hidden
            BeginContext(121, 29, true);
            WriteLiteral("<!--Formularz kontaktowy-->\r\n");
            EndContext();
#line 11 "C:\Users\user\Documents\Daria\kurs_c#\DariaHornikLab6\DariaHornikLab6\Views\Home\ContactForm.cshtml"
 using (Html.BeginForm("ContactForm", "Home", FormMethod.Post))
{
    

#line default
#line hidden
            BeginContext(223, 23, false);
#line 13 "C:\Users\user\Documents\Daria\kurs_c#\DariaHornikLab6\DariaHornikLab6\Views\Home\ContactForm.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(250, 148, true);
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <h4>ContactForm</h4>\r\n        <hr />\r\n        <!--Imię-->\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(399, 98, false);
#line 20 "C:\Users\user\Documents\Daria\kurs_c#\DariaHornikLab6\DariaHornikLab6\Views\Home\ContactForm.cshtml"
       Write(Html.LabelFor(model => model.FirstName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(497, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(553, 98, false);
#line 22 "C:\Users\user\Documents\Daria\kurs_c#\DariaHornikLab6\DariaHornikLab6\Views\Home\ContactForm.cshtml"
           Write(Html.EditorFor(model => model.FirstName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(651, 109, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <!--Nazwisko-->\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(761, 97, false);
#line 27 "C:\Users\user\Documents\Daria\kurs_c#\DariaHornikLab6\DariaHornikLab6\Views\Home\ContactForm.cshtml"
       Write(Html.LabelFor(model => model.LastName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(858, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(914, 97, false);
#line 29 "C:\Users\user\Documents\Daria\kurs_c#\DariaHornikLab6\DariaHornikLab6\Views\Home\ContactForm.cshtml"
           Write(Html.EditorFor(model => model.LastName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1011, 105, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <!--Opis-->\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(1117, 100, false);
#line 34 "C:\Users\user\Documents\Daria\kurs_c#\DariaHornikLab6\DariaHornikLab6\Views\Home\ContactForm.cshtml"
       Write(Html.LabelFor(model => model.Description, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1217, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(1273, 100, false);
#line 36 "C:\Users\user\Documents\Daria\kurs_c#\DariaHornikLab6\DariaHornikLab6\Views\Home\ContactForm.cshtml"
           Write(Html.EditorFor(model => model.Description, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1373, 253, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-offset-2 col-md-10\">\r\n                <input type=\"submit\" value=\"Create\" class=\"btn btn-success\" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 45 "C:\Users\user\Documents\Daria\kurs_c#\DariaHornikLab6\DariaHornikLab6\Views\Home\ContactForm.cshtml"
}

#line default
#line hidden
            BeginContext(1629, 11, true);
            WriteLiteral("<div>\r\n    ");
            EndContext();
            BeginContext(1641, 40, false);
#line 47 "C:\Users\user\Documents\Daria\kurs_c#\DariaHornikLab6\DariaHornikLab6\Views\Home\ContactForm.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(1681, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactFormViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591