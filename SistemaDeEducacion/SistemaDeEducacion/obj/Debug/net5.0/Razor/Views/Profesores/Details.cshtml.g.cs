#pragma checksum "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Profesores\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "691a879c9f7709ea40b9e54fc8de3e7301e4e86f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profesores_Details), @"mvc.1.0.view", @"/Views/Profesores/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"691a879c9f7709ea40b9e54fc8de3e7301e4e86f", @"/Views/Profesores/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"975b9075ec801c2f802cffd22888095d0f54f424", @"/Views/_ViewImports.cshtml")]
    public class Views_Profesores_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProfesorViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<dd>\r\n    Nombre del Profesor:\r\n</dd>\r\n\r\n");
#nullable restore
#line 7 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Profesores\Details.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <dd>\r\n        ");
#nullable restore
#line 10 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Profesores\Details.cshtml"
   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n");
#nullable restore
#line 12 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Profesores\Details.cshtml"
    break;
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<dd>\r\n    Apellido del Profesor:\r\n</dd>\r\n\r\n");
#nullable restore
#line 19 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Profesores\Details.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <dd>\r\n        ");
#nullable restore
#line 22 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Profesores\Details.cshtml"
   Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n");
#nullable restore
#line 24 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Profesores\Details.cshtml"
    break;
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<dd>\r\n    Fecha de nacimiento:\r\n</dd>\r\n\r\n");
#nullable restore
#line 31 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Profesores\Details.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <dd>\r\n        ");
#nullable restore
#line 34 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Profesores\Details.cshtml"
   Write(Html.DisplayFor(modelItem => item.DateOfBirth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n");
#nullable restore
#line 36 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Profesores\Details.cshtml"
    break;
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<dd>\r\n    Sexo:\r\n</dd>\r\n\r\n");
#nullable restore
#line 43 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Profesores\Details.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <dd>\r\n        ");
#nullable restore
#line 46 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Profesores\Details.cshtml"
   Write(Html.DisplayFor(modelItem => item.Sexo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n");
#nullable restore
#line 48 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Profesores\Details.cshtml"
    break;
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<dd>\r\n    DNI:\r\n</dd>\r\n\r\n");
#nullable restore
#line 55 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Profesores\Details.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <dd>\r\n        ");
#nullable restore
#line 58 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Profesores\Details.cshtml"
   Write(Html.DisplayFor(modelItem => item.Dni));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n");
#nullable restore
#line 60 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Profesores\Details.cshtml"
    break;
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<dd>\r\n    Carrera:\r\n</dd>\r\n\r\n");
#nullable restore
#line 67 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Profesores\Details.cshtml"
 foreach (var item in Model)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Profesores\Details.cshtml"
     foreach (var carrera in item.College)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dd>\r\n            ");
#nullable restore
#line 72 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Profesores\Details.cshtml"
       Write(Html.DisplayFor(modelItem => carrera.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n");
#nullable restore
#line 74 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Profesores\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Profesores\Details.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<dd>\r\n    Materia:\r\n</dd>\r\n\r\n");
#nullable restore
#line 81 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Profesores\Details.cshtml"
 foreach (var item in Model)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Profesores\Details.cshtml"
     foreach (var curso in item.Course)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dd>\r\n            ");
#nullable restore
#line 86 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Profesores\Details.cshtml"
       Write(Html.DisplayFor(modelItem => curso.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n");
#nullable restore
#line 88 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Profesores\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Profesores\Details.cshtml"
     
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProfesorViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
