#pragma checksum "C:\Users\Victo\Desktop\Proyectos 2022\Portafolio\Portafolio\Portafolio\Views\Home\_ListadoProyectos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "faf51d30227206c38b9f84b9af6d29ac87abfa4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__ListadoProyectos), @"mvc.1.0.view", @"/Views/Home/_ListadoProyectos.cshtml")]
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
#line 1 "C:\Users\Victo\Desktop\Proyectos 2022\Portafolio\Portafolio\Portafolio\Views\_ViewImports.cshtml"
using Portafolio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Victo\Desktop\Proyectos 2022\Portafolio\Portafolio\Portafolio\Views\_ViewImports.cshtml"
using Portafolio.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"faf51d30227206c38b9f84b9af6d29ac87abfa4f", @"/Views/Home/_ListadoProyectos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1869180723fd9e2bc1853cf5fde03473f9a2ed6b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__ListadoProyectos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Proyecto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Victo\Desktop\Proyectos 2022\Portafolio\Portafolio\Portafolio\Views\Home\_ListadoProyectos.cshtml"
 if (Model is not null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\">\r\n        <div class=\"row row-cols-1 row-cols-md-3 g-4\">\r\n");
#nullable restore
#line 7 "C:\Users\Victo\Desktop\Proyectos 2022\Portafolio\Portafolio\Portafolio\Views\Home\_ListadoProyectos.cshtml"
             foreach (var proyecto in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col\">\r\n                    <div class=\"card h-100\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 315, "\"", 340, 1);
#nullable restore
#line 11 "C:\Users\Victo\Desktop\Proyectos 2022\Portafolio\Portafolio\Portafolio\Views\Home\_ListadoProyectos.cshtml"
WriteAttributeValue("", 321, proyecto.ImagenURL, 321, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"imagen-proyecto\" />\r\n                        <div class=\"card-body\">\r\n                            <h5 class=\"card-title\">");
#nullable restore
#line 13 "C:\Users\Victo\Desktop\Proyectos 2022\Portafolio\Portafolio\Portafolio\Views\Home\_ListadoProyectos.cshtml"
                                              Write(proyecto.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p class=\"card-text\">");
#nullable restore
#line 14 "C:\Users\Victo\Desktop\Proyectos 2022\Portafolio\Portafolio\Portafolio\Views\Home\_ListadoProyectos.cshtml"
                                            Write(proyecto.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"card-footer\">\r\n                            <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 725, "\"", 746, 1);
#nullable restore
#line 17 "C:\Users\Victo\Desktop\Proyectos 2022\Portafolio\Portafolio\Portafolio\Views\Home\_ListadoProyectos.cshtml"
WriteAttributeValue("", 732, proyecto.Link, 732, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\"\r\n                               rel=\"noopener noreferrer\">Visitar</a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 22 "C:\Users\Victo\Desktop\Proyectos 2022\Portafolio\Portafolio\Portafolio\Views\Home\_ListadoProyectos.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n");
#nullable restore
#line 25 "C:\Users\Victo\Desktop\Proyectos 2022\Portafolio\Portafolio\Portafolio\Views\Home\_ListadoProyectos.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Proyecto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
