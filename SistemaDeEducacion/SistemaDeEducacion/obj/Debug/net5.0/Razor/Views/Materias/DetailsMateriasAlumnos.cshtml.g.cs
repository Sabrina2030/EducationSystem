#pragma checksum "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Materias\DetailsMateriasAlumnos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3756862bea3495dbca745baa6041c604be2523e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Materias_DetailsMateriasAlumnos), @"mvc.1.0.view", @"/Views/Materias/DetailsMateriasAlumnos.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3756862bea3495dbca745baa6041c604be2523e7", @"/Views/Materias/DetailsMateriasAlumnos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"975b9075ec801c2f802cffd22888095d0f54f424", @"/Views/_ViewImports.cshtml")]
    public class Views_Materias_DetailsMateriasAlumnos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MateriaViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h4>\r\n    Materia:\r\n</h4>\r\n\r\n");
#nullable restore
#line 7 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Materias\DetailsMateriasAlumnos.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        ");
#nullable restore
#line 10 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Materias\DetailsMateriasAlumnos.cshtml"
   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n");
#nullable restore
#line 12 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Materias\DetailsMateriasAlumnos.cshtml"
    break;
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4>Alumnos:</h4>\r\n\r\n<h5>\r\n    Nombre:\r\n</h5>\r\n\r\n");
#nullable restore
#line 21 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Materias\DetailsMateriasAlumnos.cshtml"
 foreach (var item in Model)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Materias\DetailsMateriasAlumnos.cshtml"
     foreach (var nombre in item.Students)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>\r\n            ");
#nullable restore
#line 26 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Materias\DetailsMateriasAlumnos.cshtml"
       Write(Html.DisplayFor(modelItem => nombre.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n");
#nullable restore
#line 28 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Materias\DetailsMateriasAlumnos.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Materias\DetailsMateriasAlumnos.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h5>\r\n    Apellido:\r\n</h5>\r\n\r\n");
#nullable restore
#line 35 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Materias\DetailsMateriasAlumnos.cshtml"
 foreach (var item in Model)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Materias\DetailsMateriasAlumnos.cshtml"
     foreach (var apellido in item.Students)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>\r\n            ");
#nullable restore
#line 40 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Materias\DetailsMateriasAlumnos.cshtml"
       Write(Html.DisplayFor(modelItem => apellido.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n");
#nullable restore
#line 42 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Materias\DetailsMateriasAlumnos.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Materias\DetailsMateriasAlumnos.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h5>\r\n    DNI:\r\n</h5>\r\n\r\n");
#nullable restore
#line 49 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Materias\DetailsMateriasAlumnos.cshtml"
 foreach (var item in Model)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Materias\DetailsMateriasAlumnos.cshtml"
     foreach (var dni in item.Students)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>\r\n            ");
#nullable restore
#line 54 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Materias\DetailsMateriasAlumnos.cshtml"
       Write(Html.DisplayFor(modelItem => dni.Dni));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n");
#nullable restore
#line 56 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Materias\DetailsMateriasAlumnos.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Materias\DetailsMateriasAlumnos.cshtml"
     
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MateriaViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591