#pragma checksum "D:\AZURE 301\ALL SOLUTIONS\VidyaSree_M1045514_MyStay_Clean_Architecture_Final\MyStay\MyStayMVC\MyStayMVC\Views\HotelInfo\HotelDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31f21677c39e8de8d650cddc3a8c902b2a068065"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HotelInfo_HotelDetails), @"mvc.1.0.view", @"/Views/HotelInfo/HotelDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HotelInfo/HotelDetails.cshtml", typeof(AspNetCore.Views_HotelInfo_HotelDetails))]
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
#line 1 "D:\AZURE 301\ALL SOLUTIONS\VidyaSree_M1045514_MyStay_Clean_Architecture_Final\MyStay\MyStayMVC\MyStayMVC\Views\_ViewImports.cshtml"
using MyStayMVC;

#line default
#line hidden
#line 2 "D:\AZURE 301\ALL SOLUTIONS\VidyaSree_M1045514_MyStay_Clean_Architecture_Final\MyStay\MyStayMVC\MyStayMVC\Views\_ViewImports.cshtml"
using MyStayMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31f21677c39e8de8d650cddc3a8c902b2a068065", @"/Views/HotelInfo/HotelDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"863dbab1b8b531b0197e3ae0515987d35ebb1129", @"/Views/_ViewImports.cshtml")]
    public class Views_HotelInfo_HotelDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyStayMVC.Models.HotelInfo>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\AZURE 301\ALL SOLUTIONS\VidyaSree_M1045514_MyStay_Clean_Architecture_Final\MyStay\MyStayMVC\MyStayMVC\Views\HotelInfo\HotelDetails.cshtml"
  
    ViewData["Title"] = "HotelDetails";
    ViewBag.Active = "HotelInfo";

#line default
#line hidden
            BeginContext(118, 168, true);
            WriteLiteral("\r\n<div class=\"widget box\">\r\n    <div class=\"widget-header\">\r\n        <h4><i class=\"icon-reorder\"></i> Hotel Details</h4>\r\n    </div>\r\n    <div class=\"widget-content\">\r\n");
            EndContext();
#line 12 "D:\AZURE 301\ALL SOLUTIONS\VidyaSree_M1045514_MyStay_Clean_Architecture_Final\MyStay\MyStayMVC\MyStayMVC\Views\HotelInfo\HotelDetails.cshtml"
         using (Html.BeginForm(new { @id = "SubmitHotelDetails" }))
        {

#line default
#line hidden
            BeginContext(366, 103, true);
            WriteLiteral("            <div class=\"row\">\r\n                <div class=\"form-group  col-md-3\">\r\n                    ");
            EndContext();
            BeginContext(470, 104, false);
#line 16 "D:\AZURE 301\ALL SOLUTIONS\VidyaSree_M1045514_MyStay_Clean_Architecture_Final\MyStay\MyStayMVC\MyStayMVC\Views\HotelInfo\HotelDetails.cshtml"
               Write(Html.TextBoxFor(model => model.Name, new { @class = "form-control", @placeholder = "Enter Hotel Name" }));

#line default
#line hidden
            EndContext();
            BeginContext(574, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(597, 46, false);
#line 17 "D:\AZURE 301\ALL SOLUTIONS\VidyaSree_M1045514_MyStay_Clean_Architecture_Final\MyStay\MyStayMVC\MyStayMVC\Views\HotelInfo\HotelDetails.cshtml"
               Write(Html.ValidationMessageFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(643, 97, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group col-md-3\">\r\n                    ");
            EndContext();
            BeginContext(741, 110, false);
#line 20 "D:\AZURE 301\ALL SOLUTIONS\VidyaSree_M1045514_MyStay_Clean_Architecture_Final\MyStay\MyStayMVC\MyStayMVC\Views\HotelInfo\HotelDetails.cshtml"
               Write(Html.TextBoxFor(model => model.Address, new { @class = "form-control", @placeholder = "Enter Hotel Address" }));

#line default
#line hidden
            EndContext();
            BeginContext(851, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(874, 92, false);
#line 21 "D:\AZURE 301\ALL SOLUTIONS\VidyaSree_M1045514_MyStay_Clean_Architecture_Final\MyStay\MyStayMVC\MyStayMVC\Views\HotelInfo\HotelDetails.cshtml"
               Write(Html.ValidationMessageFor(model => model.Address, "", new { @class = "label label-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(966, 548, true);
            WriteLiteral(@"
                </div>
                <div class=""form-group col-md-1a"">
                    <input type=""submit"" name=""search"" value=""Search"" formaction=""HotelDetails"" formmethod=""post"" class=""btn btncusCancel btn-block btn-flat"" />
                </div>
                <div class=""form-group col-md-1a"" style=""margin-left:-10px;"">
                    <input type=""submit"" name=""save"" value=""Add"" formaction=""SubmitHotelDetails"" formmethod=""post"" class=""btn btncusSave btn-block btn-flat"" />
                </div>
            </div>
");
            EndContext();
#line 30 "D:\AZURE 301\ALL SOLUTIONS\VidyaSree_M1045514_MyStay_Clean_Architecture_Final\MyStay\MyStayMVC\MyStayMVC\Views\HotelInfo\HotelDetails.cshtml"
        }

#line default
#line hidden
            BeginContext(1525, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(1534, 55, false);
#line 31 "D:\AZURE 301\ALL SOLUTIONS\VidyaSree_M1045514_MyStay_Clean_Architecture_Final\MyStay\MyStayMVC\MyStayMVC\Views\HotelInfo\HotelDetails.cshtml"
   Write(Html.Partial("~/Views/HotelInfo/_HotelInfoList.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(1589, 56, true);
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n<!-- /Validation Example 1 -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyStayMVC.Models.HotelInfo> Html { get; private set; }
    }
}
#pragma warning restore 1591
