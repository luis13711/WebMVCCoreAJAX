#pragma checksum "C:\Users\LuisCorrea\Documents\proyectos_net\proyectos_c#\web\WebMVCCoreAJAX\WebMVCCoreAJAX\Views\Demo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c7063fce6c05626c48403c3578cd346c3b49c0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Demo_Index), @"mvc.1.0.view", @"/Views/Demo/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Demo/Index.cshtml", typeof(AspNetCore.Views_Demo_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c7063fce6c05626c48403c3578cd346c3b49c0f", @"/Views/Demo/Index.cshtml")]
    public class Views_Demo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("ng-controller", new global::Microsoft.AspNetCore.Html.HtmlString("mainController"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 61, true);
            WriteLiteral("\r\n\r\n\r\n<!DOCTYPE html>\r\n\r\n<html  ng-app=\'angularRoutingApp\'>\r\n");
            EndContext();
            BeginContext(61, 3074, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a7cecf43a2a44d382d2acfbee16994b", async() => {
                BeginContext(67, 87, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Index</title>\r\n");
                EndContext();
                BeginContext(252, 2876, true);
                WriteLiteral(@"    <script src=""js/jquery-2.2.3.min.js""></script>
    <script type=""text/javascript"">
        $(document).ready(function () {

            $('#buttonLibro2').click(function () {
                var nombre = $('#nombre').val();
                var apellido = $('#apellido').val();
                $.ajax({
                    type: 'GET',
                    url: '/demo/create2/' + nombre + '&' + apellido,
                    success: function (result) {
                        $('#resultlibro').html(result);
                    }
                });
            });

            $('#buttonLibro').click(function () {
                var name = $('#name').val();
                $.ajax({
                    type: 'GET',
                    url: '/demo/create/' + name,
                    success: function (result) {
                        $('#resultlibro').html(result);
                    }
                });
            });

            $('#buttonDemo1').click(function () {
        ");
                WriteLiteral(@"        $.ajax({
                    type: 'GET',
                    url: '/demo/demo1',
                    success: function (result) {
                        $('#result1').html(result);
                    }
                });
            });

            $('#buttonDemo2').click(function () {
                var fullName = $('#fullName').val();
                $.ajax({
                    type: 'GET',
                    url: '/demo/demo2/' + fullName,
                    success: function (result) {
                        $('#result2').html(result);
                    }
                });
            });

            $('#buttonDemo3').click(function () {
                $.ajax({
                    type: 'GET',
                    url: '/demo/demo3',
                    success: function (result) {
                        var s = 'Id: ' + result.id;
                        s += '<br>Name: ' + result.name;
                        s += '<br>Price: ' + result.price;
        ");
                WriteLiteral(@"                $('#result3').html(s);
                    }
                });
            });

            $('#buttonDemo4').click(function () {
                $.ajax({
                    type: 'GET',
                    url: '/demo/demo4',
                    success: function (result) {
                        var s = '';
                        for (var i = 0; i < result.length; i++) {
                            s += '<br>Id: ' + result[i].id;
                            s += '<br>Name: ' + result[i].name;
                            s += '<br>Price: ' + result[i].price;
                            s += '<br>------------------';
                        }
                        $('#result4').html(s);
                    }
                });
            });

        });
    </script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3135, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3137, 3168, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89b5293a97f04f479230d52ef205d845", async() => {
                BeginContext(3174, 3124, true);
                WriteLiteral(@"

    <fieldset>
        <legend>Crear Libro AngularJS</legend>
        Nombre <input type=""text"" id=""nombre1"" /> <br />
        Apellido <input type=""text"" id=""apellido1"" />
        <input type=""button"" value=""Ingresar"" id=""buttonLibro3""  ng-click=""obtenerGet()"" />
        <br />
        <span id=""resultlibro3""></span>
    </fieldset>

    <fieldset>
        <legend>Crear Libro</legend>
        Nombre <input type=""text"" id=""nombre"" /> <br />
        Apellido <input type=""text"" id=""apellido"" />
        <input type=""button"" value=""Ingresar"" id=""buttonLibro2"" />
        <br />
        <span id=""resultlibro""></span>
    </fieldset>

    <fieldset>
        <legend>Crear Libro</legend>
        Nombre <input type=""text"" id=""name"" />
        <input type=""button"" value=""Nombre 1"" id=""buttonLibro"" />
        <br />
        <span id=""resultlibro""></span>
    </fieldset>


    <fieldset>
        <legend>Demo 1</legend>
        <input type=""button"" value=""Demo 1"" id=""buttonDemo1"" />
      ");
                WriteLiteral(@"  <br />
        <span id=""result1""></span>
    </fieldset>

    <fieldset>
        <legend>Demo 2</legend>
        Full Name <input type=""text"" id=""fullName"" />
        <input type=""button"" value=""Demo 2"" id=""buttonDemo2"" />
        <br />
        <span id=""result2""></span>
    </fieldset>

    <fieldset>
        <legend>Demo 3</legend>
        <input type=""button"" value=""Demo 3"" id=""buttonDemo3"" />
        <br />
        <span id=""result3""></span>
    </fieldset>

    <fieldset>
        <legend>Demo 4</legend>
        <input type=""button"" value=""Demo 4"" id=""buttonDemo4"" />
        <br />
        <span id=""result4""></span>
    </fieldset>


    <script src=""//cdnjs.cloudflare.com/ajax/libs/angular.js/1.2.7/angular.min.js""></script>
    <script src=""//cdnjs.cloudflare.com/ajax/libs/angular.js/1.2.3/angular-route.js""></script>
    <script type=""text/javascript"">
        // Creación del módulo
        var angularRoutingApp = angular.module('angularRoutingApp', []);

        var ");
                WriteLiteral(@"urlServicio = ""http://www.programandoconrupert.com/ws/servicio-gatos.php"";

        angularRoutingApp.controller(""mainController"", [""$scope"", ""$http"", function ($scope, $http) {
            $scope.gatos = [];
            $scope.obtenerGet = function () {
                //alert('Funciona');
                var nombre = document.getElementById('nombre1').value;
                var apellido = document.getElementById('apellido1').value;
                $http({
                    method: ""GET"",
                    url: '/demo/create2/' + nombre + '&' + apellido
                    //url: '/demo/demo1'
                }).then(function correcto(respuesta) {
                    //$scope.gatos = respuesta.data;
                    var resultlibro3 = document.getElementById('resultlibro3');
                    resultlibro3.innerHTML = respuesta.data;
                },
                    function error(respuesta) {
                        alert(respuesta.statusText);
                    });
     ");
                WriteLiteral("       };\r\n        }]);\r\n\r\n        \r\n    </script>\r\n");
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
            BeginContext(6305, 13, true);
            WriteLiteral("\r\n</html>\r\n\r\n");
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
