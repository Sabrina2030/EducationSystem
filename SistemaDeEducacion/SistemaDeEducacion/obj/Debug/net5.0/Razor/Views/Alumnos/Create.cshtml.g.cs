#pragma checksum "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Alumnos\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c24840a2d5331d50ab58a9f48a5b24901c7b42f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Alumnos_Create), @"mvc.1.0.view", @"/Views/Alumnos/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c24840a2d5331d50ab58a9f48a5b24901c7b42f", @"/Views/Alumnos/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"975b9075ec801c2f802cffd22888095d0f54f424", @"/Views/_ViewImports.cshtml")]
    public class Views_Alumnos_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AlumnosViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<p>Alta alumno:</p>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c24840a2d5331d50ab58a9f48a5b24901c7b42f3713", async() => {
                WriteLiteral("\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 8 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Alumnos\Create.cshtml"
   Write(Html.LabelFor(model => model.Name, new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 10 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Alumnos\Create.cshtml"
       Write(Html.EditorFor(model => model.Name, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 11 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Alumnos\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 15 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Alumnos\Create.cshtml"
   Write(Html.LabelFor(model => model.LastName, new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Alumnos\Create.cshtml"
       Write(Html.EditorFor(model => model.LastName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 18 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Alumnos\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.LastName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 22 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Alumnos\Create.cshtml"
   Write(Html.LabelFor(model => model.Dni, new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Alumnos\Create.cshtml"
       Write(Html.EditorFor(model => model.Dni, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 25 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Alumnos\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.Dni, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 29 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Alumnos\Create.cshtml"
   Write(Html.LabelFor(model => model.DateOfBirth, new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 31 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Alumnos\Create.cshtml"
       Write(Html.EditorFor(model => model.DateOfBirth, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 32 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Alumnos\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.DateOfBirth, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 36 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Alumnos\Create.cshtml"
   Write(Html.LabelFor(model => model.Address, new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 38 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Alumnos\Create.cshtml"
       Write(Html.EditorFor(model => model.Address, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 39 "C:\Users\Sabrina Rodriguez\source\repos\SistemaDeEducacion\SistemaDeEducacion\SistemaDeEducacion\Views\Alumnos\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.Address, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        </div>
    </div>
    <div class=""form-check"">
        <input class=""form-check-input"" type=""radio"" name=""SexoId"" id=""exampleRadios1"" value=""1"" checked>
        <label class=""form-check-label"" for=""exampleRadios1"">
            Femenino
        </label>
    </div>
    <div class=""form-check"">
        <input class=""form-check-input"" type=""radio"" name=""SexoId"" id=""exampleRadios2"" value=""2"">
        <label class=""form-check-label"" for=""exampleRadios2"">
            Masculino
        </label>
    </div>
    
   <button type=""submit"" value=""Create"" class=""btn btn-primary"">Submit</button>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n    \r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AlumnosViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591