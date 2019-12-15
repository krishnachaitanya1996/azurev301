#pragma checksum "D:\Azure301\CleanArchitecture\MyStay\MyStayMVC\MyStayMVC\Views\Login\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "167d96c123525166d34f7aa25f585ea6754b5af1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Register), @"mvc.1.0.view", @"/Views/Login/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Login/Register.cshtml", typeof(AspNetCore.Views_Login_Register))]
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
#line 1 "D:\Azure301\CleanArchitecture\MyStay\MyStayMVC\MyStayMVC\Views\_ViewImports.cshtml"
using MyStayMVC;

#line default
#line hidden
#line 2 "D:\Azure301\CleanArchitecture\MyStay\MyStayMVC\MyStayMVC\Views\_ViewImports.cshtml"
using MyStayMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"167d96c123525166d34f7aa25f585ea6754b5af1", @"/Views/Login/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"863dbab1b8b531b0197e3ae0515987d35ebb1129", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyStayMVC.Models.RegisteredUsers>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Azure301\CleanArchitecture\MyStay\MyStayMVC\MyStayMVC\Views\Login\Register.cshtml"
  
    ViewBag.Title = "Register";
    Layout = "~/Views/Shared/_LoginLayout.cshtml";

#line default
#line hidden
            BeginContext(133, 61, true);
            WriteLiteral("\r\n<div class=\"login-box\">\r\n    <div class=\"login-box-body\">\r\n");
            EndContext();
#line 9 "D:\Azure301\CleanArchitecture\MyStay\MyStayMVC\MyStayMVC\Views\Login\Register.cshtml"
         if (ViewBag.Message != null)
        {

#line default
#line hidden
            BeginContext(244, 83, true);
            WriteLiteral("            <div class=\"label-danger\" style=\"text-align:center;\">\r\n                ");
            EndContext();
            BeginContext(328, 15, false);
#line 12 "D:\Azure301\CleanArchitecture\MyStay\MyStayMVC\MyStayMVC\Views\Login\Register.cshtml"
           Write(ViewBag.Message);

#line default
#line hidden
            EndContext();
            BeginContext(343, 22, true);
            WriteLiteral("\r\n            </div>\r\n");
            EndContext();
#line 14 "D:\Azure301\CleanArchitecture\MyStay\MyStayMVC\MyStayMVC\Views\Login\Register.cshtml"
        }

#line default
#line hidden
            BeginContext(376, 89, true);
            WriteLiteral("        <div class=\"login-logo\">\r\n            <a href=\"\">MyStay App</a>\r\n        </div>\r\n");
            EndContext();
#line 18 "D:\Azure301\CleanArchitecture\MyStay\MyStayMVC\MyStayMVC\Views\Login\Register.cshtml"
         using (Html.BeginForm("Register", "LogIn", FormMethod.Post, new { @id = "SubmitRegister" }))
        {

#line default
#line hidden
            BeginContext(579, 67, true);
            WriteLiteral("            <div class=\"form-group has-feedback\">\r\n                ");
            EndContext();
            BeginContext(647, 101, false);
#line 21 "D:\Azure301\CleanArchitecture\MyStay\MyStayMVC\MyStayMVC\Views\Login\Register.cshtml"
           Write(Html.TextBoxFor(model => model.FullName, new { @class = "form-control", @placeholder = "Full Name" }));

#line default
#line hidden
            EndContext();
            BeginContext(748, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(767, 93, false);
#line 22 "D:\Azure301\CleanArchitecture\MyStay\MyStayMVC\MyStayMVC\Views\Login\Register.cshtml"
           Write(Html.ValidationMessageFor(model => model.FullName, "", new { @class = "label label-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(860, 89, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group has-feedback\">\r\n                ");
            EndContext();
            BeginContext(950, 94, false);
#line 25 "D:\Azure301\CleanArchitecture\MyStay\MyStayMVC\MyStayMVC\Views\Login\Register.cshtml"
           Write(Html.TextBoxFor(model => model.Email, new { @class = "form-control", @placeholder = "Email" }));

#line default
#line hidden
            EndContext();
            BeginContext(1044, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1063, 90, false);
#line 26 "D:\Azure301\CleanArchitecture\MyStay\MyStayMVC\MyStayMVC\Views\Login\Register.cshtml"
           Write(Html.ValidationMessageFor(model => model.Email, "", new { @class = "label label-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1153, 89, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group has-feedback\">\r\n                ");
            EndContext();
            BeginContext(1243, 109, false);
#line 29 "D:\Azure301\CleanArchitecture\MyStay\MyStayMVC\MyStayMVC\Views\Login\Register.cshtml"
           Write(Html.TextBoxFor(model => model.MobileNumber, new { @class = "form-control", @placeholder = "Mobile Number" }));

#line default
#line hidden
            EndContext();
            BeginContext(1352, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1371, 97, false);
#line 30 "D:\Azure301\CleanArchitecture\MyStay\MyStayMVC\MyStayMVC\Views\Login\Register.cshtml"
           Write(Html.ValidationMessageFor(model => model.MobileNumber, "", new { @class = "label label-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1468, 89, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group has-feedback\">\r\n                ");
            EndContext();
            BeginContext(1558, 107, false);
#line 33 "D:\Azure301\CleanArchitecture\MyStay\MyStayMVC\MyStayMVC\Views\Login\Register.cshtml"
           Write(Html.PasswordFor(model => model.Password, new { @class = "form-control", @placeholder = "Enter password" }));

#line default
#line hidden
            EndContext();
            BeginContext(1665, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1684, 93, false);
#line 34 "D:\Azure301\CleanArchitecture\MyStay\MyStayMVC\MyStayMVC\Views\Login\Register.cshtml"
           Write(Html.ValidationMessageFor(model => model.Password, "", new { @class = "label label-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1777, 317, true);
            WriteLiteral(@"
            </div>
            <div class=""row"">
                <div class=""col-xs-6"">
                    <button type=""submit"" class=""btn btn-primary btn-block btn-flat"">Register</button>
                </div>
                <div class=""col-xs-6"">
                    <button type=""button"" id=""btnCancel""");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2094, "\"", 2149, 3);
            WriteAttributeValue("", 2104, "location.href=\'", 2104, 15, true);
#line 41 "D:\Azure301\CleanArchitecture\MyStay\MyStayMVC\MyStayMVC\Views\Login\Register.cshtml"
WriteAttributeValue("", 2119, Url.Action("Login", "Login"), 2119, 29, false);

#line default
#line hidden
            WriteAttributeValue("", 2148, "\'", 2148, 1, true);
            EndWriteAttribute();
            BeginContext(2150, 104, true);
            WriteLiteral(" class=\"btn btn-danger btn-block btn-flat\">Cancel</button>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 44 "D:\Azure301\CleanArchitecture\MyStay\MyStayMVC\MyStayMVC\Views\Login\Register.cshtml"
        }

#line default
#line hidden
            BeginContext(2265, 22, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyStayMVC.Models.RegisteredUsers> Html { get; private set; }
    }
}
#pragma warning restore 1591