#pragma checksum "C:\Users\44592799836\Desktop\site_Thais\Views\Eventos\Eventos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f9e713c16f0b18d7015a81437fef3827bf6f755"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Eventos_Eventos), @"mvc.1.0.view", @"/Views/Eventos/Eventos.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Eventos/Eventos.cshtml", typeof(AspNetCore.Views_Eventos_Eventos))]
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
#line 1 "C:\Users\44592799836\Desktop\site_Thais\Views\_ViewImports.cshtml"
using Role_MVC;

#line default
#line hidden
#line 2 "C:\Users\44592799836\Desktop\site_Thais\Views\_ViewImports.cshtml"
using Role_MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f9e713c16f0b18d7015a81437fef3827bf6f755", @"/Views/Eventos/Eventos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b675b1c91659e3a40aba85095abadd99070d31e", @"/Views/_ViewImports.cshtml")]
    public class Views_Eventos_Eventos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Dinheiro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Cartão de Crédito", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1682, true);
            WriteLiteral(@"<main>
    <h1>ROLÊ TOP</h1>    
    <section id=""logo-area"">
        <img src=""img/logo.jpg"">
        <p>ROLÊ TOP<br/>A sua festa do seu jeito</p>
    </section>
    
    <section id=""banner"">
        <div class=""section-container"">
            <p><strong><br/>
        </hgroup>
        </section>
    </header>
    <div class=""titulo23"">
        <h1>Cadastro</h1>
        <h6>Informações do Evento</h6>
        <br/>
        </div>
        <div class=""inf"">
            <br/>
            <br/>
            <div>
                <label for=""tipo_evento"">Tipo de Evento: </label><br />
                <input id=""tipo_evento"" name=""tipo_evento"" required=""required"" type=""text""
                placeholder=""ex.Casamento"" />
            </div>
            <br/>
            <div>
                <label for=""numero_de_pessoas"">Número de Pessoas: </label><br />
                <input id=""numero_de_pessoas"" name=""numero_de_pessoas"" required=""required"" type=""numbers""
                placeholder=");
            WriteLiteral(@"""ex.200"" />
            </div>
            <br/>
            <div>
                <input type=""checkbox"" name=""serviços"" id=""serviços"" value=""serviços"" />
                <label for=""serviços"">Iluminação</label><br />
            </div>
            <br/>
            <div>
                <input type=""checkbox"" name=""serviços"" id=""serviços"" value=""serviços"" />
                <label for=""serviços"">Equipamento de Som</label><br />
            </div>
            <br />
            
            <div>
                <label for=""Forma de Pagamento"">Forma de Pagamento: </label><br />
                <select id=cbPais>
                    ");
            EndContext();
            BeginContext(1682, 26, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88bd5d4981b24d85af902200aa5fb3fb", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1708, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1730, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5458b7466a7b41d4a1958bc45e508b65", async() => {
                BeginContext(1755, 8, true);
                WriteLiteral("Dinheiro");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1772, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1794, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d94f3049bdde4662a202e0fe2c736192", async() => {
                BeginContext(1828, 6, true);
                WriteLiteral("Cartão");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1843, 1333, true);
            WriteLiteral(@"
                </select>
            </div>
            <br />
            <div>
                <label for=""Observações"">Observações: </label><br />
                <input type=""text"" name=""Observações"" size=""50 caracteres"">
            </div>
            <br />
            <div>
                <label for=""Data do Evento"">Data do Evento: </label><br />
                <input type=""date"" type=""date"">
            </div>
            <br/>
        <div class=""titulo22"">
        <div>
            <h2><a href=""dashboard.html""><input type=""submit"" value=""Enviar"" /></a></h2>
        </div>
        </div>
        <br/>
        <br/>
        <br/>
</div>
        </section>


    </div>
    <section id=""local"">
            <div class=""section-container"">
                <iframe
                    src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3657.8869961505543!2d-46.648477085071065!3d-23.53656648469522!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x94ce5843deade6e3%3A");
            WriteLiteral(@"0x124f377d06c7e71f!2sAlameda+Bar%C3%A3o+de+Limeira%2C+539+-+Campos+El%C3%ADseos%2C+S%C3%A3o+Paulo+-+SP%2C+01202-001!5e0!3m2!1sen!2sbr!4v1550223658410""
                    width=""100%"" height=""20%"" frameborder=""0"" style=""border:0"" allowfullscreen></iframe>
            </div>
        </section>
    </main>");
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
