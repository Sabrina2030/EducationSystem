#pragma checksum "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Alumnos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72db1100c42e9a04890bd146808ec05fbb1a7b36"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Alumnos_Index), @"mvc.1.0.view", @"/Views/Alumnos/Index.cshtml")]
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
#line 1 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\_ViewImports.cshtml"
using SistemaDeEducacion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\_ViewImports.cshtml"
using SistemaDeEducacion.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72db1100c42e9a04890bd146808ec05fbb1a7b36", @"/Views/Alumnos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"975b9075ec801c2f802cffd22888095d0f54f424", @"/Views/_ViewImports.cshtml")]
    public class Views_Alumnos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AlumnosViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<table>
    <thead>
        <tr>
            <th>Nombre</th>
            <th>Apellido</th>
            <th>DNI</th>
            <th>Fecha Nacimiento</th>
            <th>sexo</th>
            <th>Domicilio</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 15 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Alumnos\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 18 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Alumnos\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 19 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Alumnos\Index.cshtml"
           Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Alumnos\Index.cshtml"
           Write(item.Dni);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Alumnos\Index.cshtml"
           Write(item.DateOfBirth);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Alumnos\Index.cshtml"
           Write(item.Sexo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Alumnos\Index.cshtml"
           Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 25 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Alumnos\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AlumnosViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
