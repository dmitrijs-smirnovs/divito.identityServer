#pragma checksum "C:\Users\Poorchild\source\repos\webapi-identity-server-master\src\MXP.IdentityServer\Views\Consent\_ScopeListItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "786a147a1795ede2f87499e1666bb7dac98679d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Consent__ScopeListItem), @"mvc.1.0.view", @"/Views/Consent/_ScopeListItem.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Consent/_ScopeListItem.cshtml", typeof(AspNetCore.Views_Consent__ScopeListItem))]
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
#line 1 "C:\Users\Poorchild\source\repos\webapi-identity-server-master\src\MXP.IdentityServer\Views\_ViewImports.cshtml"
using MXP.IdentityServer;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"786a147a1795ede2f87499e1666bb7dac98679d7", @"/Views/Consent/_ScopeListItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acccf017d37f95cccdf4a8ec7a0a22cd05228b14", @"/Views/_ViewImports.cshtml")]
    public class Views_Consent__ScopeListItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MXP.IdentityServer.Consent.ScopeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 151, true);
            WriteLiteral("<li class=\"list-group-item\">\n    <label>\n        <input class=\"consent-scopecheck\"\n               type=\"checkbox\"\n               name=\"ScopesConsented\"");
            EndContext();
            BeginWriteAttribute("id", "\n               id=\"", 200, "\"", 238, 2);
            WriteAttributeValue("", 220, "scopes_", 220, 7, true);
#line 7 "C:\Users\Poorchild\source\repos\webapi-identity-server-master\src\MXP.IdentityServer\Views\Consent\_ScopeListItem.cshtml"
WriteAttributeValue("", 227, Model.Name, 227, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("value", "\n               value=\"", 239, "\"", 273, 1);
#line 8 "C:\Users\Poorchild\source\repos\webapi-identity-server-master\src\MXP.IdentityServer\Views\Consent\_ScopeListItem.cshtml"
WriteAttributeValue("", 262, Model.Name, 262, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("checked", "\n               checked=\"", 274, "\"", 313, 1);
#line 9 "C:\Users\Poorchild\source\repos\webapi-identity-server-master\src\MXP.IdentityServer\Views\Consent\_ScopeListItem.cshtml"
WriteAttributeValue("", 299, Model.Checked, 299, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("disabled", "\n               disabled=\"", 314, "\"", 355, 1);
#line 10 "C:\Users\Poorchild\source\repos\webapi-identity-server-master\src\MXP.IdentityServer\Views\Consent\_ScopeListItem.cshtml"
WriteAttributeValue("", 340, Model.Required, 340, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(356, 4, true);
            WriteLiteral(" />\n");
            EndContext();
#line 11 "C:\Users\Poorchild\source\repos\webapi-identity-server-master\src\MXP.IdentityServer\Views\Consent\_ScopeListItem.cshtml"
         if (Model.Required)
        {

#line default
#line hidden
            BeginContext(399, 74, true);
            WriteLiteral("            <input type=\"hidden\"\n                   name=\"ScopesConsented\"");
            EndContext();
            BeginWriteAttribute("value", "\n                   value=\"", 473, "\"", 511, 1);
#line 15 "C:\Users\Poorchild\source\repos\webapi-identity-server-master\src\MXP.IdentityServer\Views\Consent\_ScopeListItem.cshtml"
WriteAttributeValue("", 500, Model.Name, 500, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(512, 4, true);
            WriteLiteral(" />\n");
            EndContext();
#line 16 "C:\Users\Poorchild\source\repos\webapi-identity-server-master\src\MXP.IdentityServer\Views\Consent\_ScopeListItem.cshtml"
        }

#line default
#line hidden
            BeginContext(526, 16, true);
            WriteLiteral("        <strong>");
            EndContext();
            BeginContext(543, 17, false);
#line 17 "C:\Users\Poorchild\source\repos\webapi-identity-server-master\src\MXP.IdentityServer\Views\Consent\_ScopeListItem.cshtml"
           Write(Model.DisplayName);

#line default
#line hidden
            EndContext();
            BeginContext(560, 10, true);
            WriteLiteral("</strong>\n");
            EndContext();
#line 18 "C:\Users\Poorchild\source\repos\webapi-identity-server-master\src\MXP.IdentityServer\Views\Consent\_ScopeListItem.cshtml"
         if (Model.Emphasize)
        {

#line default
#line hidden
            BeginContext(610, 71, true);
            WriteLiteral("            <span class=\"glyphicon glyphicon-exclamation-sign\"></span>\n");
            EndContext();
#line 21 "C:\Users\Poorchild\source\repos\webapi-identity-server-master\src\MXP.IdentityServer\Views\Consent\_ScopeListItem.cshtml"
        }

#line default
#line hidden
            BeginContext(691, 13, true);
            WriteLiteral("    </label>\n");
            EndContext();
#line 23 "C:\Users\Poorchild\source\repos\webapi-identity-server-master\src\MXP.IdentityServer\Views\Consent\_ScopeListItem.cshtml"
     if (Model.Required)
    {

#line default
#line hidden
            BeginContext(735, 41, true);
            WriteLiteral("        <span><em>(required)</em></span>\n");
            EndContext();
#line 26 "C:\Users\Poorchild\source\repos\webapi-identity-server-master\src\MXP.IdentityServer\Views\Consent\_ScopeListItem.cshtml"
    }

#line default
#line hidden
            BeginContext(782, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 27 "C:\Users\Poorchild\source\repos\webapi-identity-server-master\src\MXP.IdentityServer\Views\Consent\_ScopeListItem.cshtml"
     if (Model.Description != null)
    {

#line default
#line hidden
            BeginContext(824, 60, true);
            WriteLiteral("        <div class=\"consent-description\">\n            <label");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 884, "\"", 908, 2);
            WriteAttributeValue("", 890, "scopes_", 890, 7, true);
#line 30 "C:\Users\Poorchild\source\repos\webapi-identity-server-master\src\MXP.IdentityServer\Views\Consent\_ScopeListItem.cshtml"
WriteAttributeValue("", 897, Model.Name, 897, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(909, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(911, 17, false);
#line 30 "C:\Users\Poorchild\source\repos\webapi-identity-server-master\src\MXP.IdentityServer\Views\Consent\_ScopeListItem.cshtml"
                                       Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(928, 24, true);
            WriteLiteral("</label>\n        </div>\n");
            EndContext();
#line 32 "C:\Users\Poorchild\source\repos\webapi-identity-server-master\src\MXP.IdentityServer\Views\Consent\_ScopeListItem.cshtml"
    }

#line default
#line hidden
            BeginContext(958, 5, true);
            WriteLiteral("</li>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MXP.IdentityServer.Consent.ScopeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
