#pragma checksum "C:\Users\Victo\Desktop\Proyectos 2022\Portafolio\Portafolio\Portafolio\Views\Home\_SeccionProyectos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db372047b0be0e3433f25495bbed545292400ebe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__SeccionProyectos), @"mvc.1.0.view", @"/Views/Home/_SeccionProyectos.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db372047b0be0e3433f25495bbed545292400ebe", @"/Views/Home/_SeccionProyectos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1869180723fd9e2bc1853cf5fde03473f9a2ed6b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__SeccionProyectos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Proyecto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Victo\Desktop\Proyectos 2022\Portafolio\Portafolio\Portafolio\Views\Home\_SeccionProyectos.cshtml"
 if (Model is not null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"text-center\" style=\"padding-top: 6rem;\">\r\n        <h1>Mis tabajos recientes</h1>\r\n        <p>Aqui puedes ver algunos de mis trabajos mas recientes</p>\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"container\">\r\n        <div class=\"row row-cols-1 row-cols-md-3 g-4\">\r\n");
#nullable restore
#line 12 "C:\Users\Victo\Desktop\Proyectos 2022\Portafolio\Portafolio\Portafolio\Views\Home\_SeccionProyectos.cshtml"
             foreach (var proyecto in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col\">\r\n                    <div class=\"card h-100\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 497, "\"", 522, 1);
#nullable restore
#line 16 "C:\Users\Victo\Desktop\Proyectos 2022\Portafolio\Portafolio\Portafolio\Views\Home\_SeccionProyectos.cshtml"
WriteAttributeValue("", 503, proyecto.ImagenURL, 503, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"imagen-proyecto\" />\r\n                        <div class=\"card-body\">\r\n                            <h5 class=\"card-title\">");
#nullable restore
#line 18 "C:\Users\Victo\Desktop\Proyectos 2022\Portafolio\Portafolio\Portafolio\Views\Home\_SeccionProyectos.cshtml"
                                              Write(proyecto.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p class=\"card-text\">");
#nullable restore
#line 19 "C:\Users\Victo\Desktop\Proyectos 2022\Portafolio\Portafolio\Portafolio\Views\Home\_SeccionProyectos.cshtml"
                                            Write(proyecto.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"card-footer\">\r\n                            <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 907, "\"", 928, 1);
#nullable restore
#line 22 "C:\Users\Victo\Desktop\Proyectos 2022\Portafolio\Portafolio\Portafolio\Views\Home\_SeccionProyectos.cshtml"
WriteAttributeValue("", 914, proyecto.Link, 914, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\"\r\n                               rel=\"noopener noreferrer\">Visitar</a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 27 "C:\Users\Victo\Desktop\Proyectos 2022\Portafolio\Portafolio\Portafolio\Views\Home\_SeccionProyectos.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n");
#nullable restore
#line 30 "C:\Users\Victo\Desktop\Proyectos 2022\Portafolio\Portafolio\Portafolio\Views\Home\_SeccionProyectos.cshtml"
}

#line default
#line hidden
#nullable disable
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