#pragma checksum "C:\Users\user\Documents\Daria\kurs_c#\DariaHornikLab6\DariaHornikLab6\Views\Home\GetAllCars.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ffd6a13d517eeefce239e6cdbdc394ce2909b57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetAllCars), @"mvc.1.0.view", @"/Views/Home/GetAllCars.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/GetAllCars.cshtml", typeof(AspNetCore.Views_Home_GetAllCars))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ffd6a13d517eeefce239e6cdbdc394ce2909b57", @"/Views/Home/GetAllCars.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c27c93ec28944b37b0365d8317357e91ed471524", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetAllCars : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CarViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\user\Documents\Daria\kurs_c#\DariaHornikLab6\DariaHornikLab6\Views\Home\GetAllCars.cshtml"
  
    ViewData["Title"] = "GetAllCars";

#line default
#line hidden
            BeginContext(73, 73, true);
            WriteLiteral("\r\n<h2>GetAllCars</h2>\r\n\r\n<!--Iteracja po wszystkich elementach listy-->\r\n");
            EndContext();
#line 9 "C:\Users\user\Documents\Daria\kurs_c#\DariaHornikLab6\DariaHornikLab6\Views\Home\GetAllCars.cshtml"
 foreach(var car in Model)
{

#line default
#line hidden
            BeginContext(177, 23, true);
            WriteLiteral("    <div>\r\n        <h2>");
            EndContext();
            BeginContext(201, 9, false);
#line 12 "C:\Users\user\Documents\Daria\kurs_c#\DariaHornikLab6\DariaHornikLab6\Views\Home\GetAllCars.cshtml"
       Write(car.Model);

#line default
#line hidden
            EndContext();
            BeginContext(210, 30, true);
            WriteLiteral("</h2>\r\n        <h4>Producent: ");
            EndContext();
            BeginContext(241, 17, false);
#line 13 "C:\Users\user\Documents\Daria\kurs_c#\DariaHornikLab6\DariaHornikLab6\Views\Home\GetAllCars.cshtml"
                  Write(car.Manufacturerr);

#line default
#line hidden
            EndContext();
            BeginContext(258, 26, true);
            WriteLiteral(" </h4>\r\n        <h4>Cena: ");
            EndContext();
            BeginContext(285, 9, false);
#line 14 "C:\Users\user\Documents\Daria\kurs_c#\DariaHornikLab6\DariaHornikLab6\Views\Home\GetAllCars.cshtml"
             Write(car.Price);

#line default
#line hidden
            EndContext();
            BeginContext(294, 19, true);
            WriteLiteral("</h4>\r\n        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 313, "\"", 342, 1);
#line 15 "C:\Users\user\Documents\Daria\kurs_c#\DariaHornikLab6\DariaHornikLab6\Views\Home\GetAllCars.cshtml"
WriteAttributeValue("", 319, Url.Content(car.Photo), 319, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 343, "\"", 359, 1);
#line 15 "C:\Users\user\Documents\Daria\kurs_c#\DariaHornikLab6\DariaHornikLab6\Views\Home\GetAllCars.cshtml"
WriteAttributeValue("", 349, car.Model, 349, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(360, 32, true);
            WriteLiteral("/>\r\n        <hr />\r\n    </div>\r\n");
            EndContext();
#line 18 "C:\Users\user\Documents\Daria\kurs_c#\DariaHornikLab6\DariaHornikLab6\Views\Home\GetAllCars.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CarViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
