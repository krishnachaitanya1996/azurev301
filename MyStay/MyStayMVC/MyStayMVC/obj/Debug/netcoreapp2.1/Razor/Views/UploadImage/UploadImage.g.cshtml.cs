#pragma checksum "D:\AZURE 301\ALL SOLUTIONS\VidyaSree_M1045514_MyStay_Clean_Architecture_Final\MyStay\MyStayMVC\MyStayMVC\Views\UploadImage\UploadImage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c82a4709c5c5b06c48e84eb9c4ad252d7ca21516"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UploadImage_UploadImage), @"mvc.1.0.view", @"/Views/UploadImage/UploadImage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UploadImage/UploadImage.cshtml", typeof(AspNetCore.Views_UploadImage_UploadImage))]
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
#line 1 "D:\AZURE 301\ALL SOLUTIONS\VidyaSree_M1045514_MyStay_Clean_Architecture_Final\MyStay\MyStayMVC\MyStayMVC\Views\UploadImage\UploadImage.cshtml"
using Microsoft.WindowsAzure.Storage.Blob;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c82a4709c5c5b06c48e84eb9c4ad252d7ca21516", @"/Views/UploadImage/UploadImage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"863dbab1b8b531b0197e3ae0515987d35ebb1129", @"/Views/_ViewImports.cshtml")]
    public class Views_UploadImage_UploadImage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<IListBlobItem>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(73, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\AZURE 301\ALL SOLUTIONS\VidyaSree_M1045514_MyStay_Clean_Architecture_Final\MyStay\MyStayMVC\MyStayMVC\Views\UploadImage\UploadImage.cshtml"
  
    ViewData["Title"] = "UploadImage";
    ViewBag.Active = "UploadImage";

#line default
#line hidden
            BeginContext(159, 191, true);
            WriteLiteral("\r\n\r\n<div class=\"widget box\">\r\n    <div class=\"widget-header\">\r\n        <h4><i class=\"icon-reorder\"></i> Upload Image to Azure Blob Storage</h4>\r\n    </div>\r\n    <div class=\"widget-content\">\r\n");
            EndContext();
#line 15 "D:\AZURE 301\ALL SOLUTIONS\VidyaSree_M1045514_MyStay_Clean_Architecture_Final\MyStay\MyStayMVC\MyStayMVC\Views\UploadImage\UploadImage.cshtml"
         using (Html.BeginForm("SubmitImage", "UploadImage", FormMethod.Post, new { enctype = "multipart/form-data" }))
        {

#line default
#line hidden
            BeginContext(482, 379, true);
            WriteLiteral(@"            <div class=""row"">
                <div class=""col-md-6"">
                    <input type=""file"" id=""fUpload"" name=""files"" multiple class=""form-control"" />
                </div>
                <div class=""col-md-6"" style=""padding-top:10px;"">
                    <input type=""submit"" id=""btnUpload"" value=""Upload"" />
                </div>
            </div>
");
            EndContext();
#line 25 "D:\AZURE 301\ALL SOLUTIONS\VidyaSree_M1045514_MyStay_Clean_Architecture_Final\MyStay\MyStayMVC\MyStayMVC\Views\UploadImage\UploadImage.cshtml"
        }

#line default
#line hidden
            BeginContext(872, 55, true);
            WriteLiteral("\r\n        <div class=\"row\" style=\"padding-top:10px;\">\r\n");
            EndContext();
#line 28 "D:\AZURE 301\ALL SOLUTIONS\VidyaSree_M1045514_MyStay_Clean_Architecture_Final\MyStay\MyStayMVC\MyStayMVC\Views\UploadImage\UploadImage.cshtml"
             foreach (var image in Model)
            {

#line default
#line hidden
            BeginContext(985, 20, true);
            WriteLiteral("                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1005, "\"", 1033, 1);
#line 30 "D:\AZURE 301\ALL SOLUTIONS\VidyaSree_M1045514_MyStay_Clean_Architecture_Final\MyStay\MyStayMVC\MyStayMVC\Views\UploadImage\UploadImage.cshtml"
WriteAttributeValue("", 1011, image.Uri.AbsoluteUri, 1011, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1034, 28, true);
            WriteLiteral(" Height=\"100\" Width=\"100\">\r\n");
            EndContext();
#line 31 "D:\AZURE 301\ALL SOLUTIONS\VidyaSree_M1045514_MyStay_Clean_Architecture_Final\MyStay\MyStayMVC\MyStayMVC\Views\UploadImage\UploadImage.cshtml"
            }

#line default
#line hidden
            BeginContext(1077, 36, true);
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<IListBlobItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591