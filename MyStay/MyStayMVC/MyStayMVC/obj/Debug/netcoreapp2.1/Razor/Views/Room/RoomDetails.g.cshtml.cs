#pragma checksum "D:\AZURE 301\ALL SOLUTIONS\VidyaSree_M1045514_MyStay_Clean_Architecture_Final\MyStay\MyStayMVC\MyStayMVC\Views\Room\RoomDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e8e3f15752f5b9131ebf07e804114de0e098e7d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Room_RoomDetails), @"mvc.1.0.view", @"/Views/Room/RoomDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Room/RoomDetails.cshtml", typeof(AspNetCore.Views_Room_RoomDetails))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e8e3f15752f5b9131ebf07e804114de0e098e7d", @"/Views/Room/RoomDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"863dbab1b8b531b0197e3ae0515987d35ebb1129", @"/Views/_ViewImports.cshtml")]
    public class Views_Room_RoomDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyStayMVC.Models.RoomDetails>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\AZURE 301\ALL SOLUTIONS\VidyaSree_M1045514_MyStay_Clean_Architecture_Final\MyStay\MyStayMVC\MyStayMVC\Views\Room\RoomDetails.cshtml"
  
    ViewData["Title"] = "RoomDetails";
    ViewBag.Active = "HotelInfo";

#line default
#line hidden
            BeginContext(119, 145, true);
            WriteLiteral("        <div class=\"widget box\">\r\n            <div class=\"widget-header\">\r\n                <h4><i class=\"icon-reorder\"></i> Room Details - Hotel ");
            EndContext();
            BeginContext(265, 39, false);
#line 8 "D:\AZURE 301\ALL SOLUTIONS\VidyaSree_M1045514_MyStay_Clean_Architecture_Final\MyStay\MyStayMVC\MyStayMVC\Views\Room\RoomDetails.cshtml"
                                                                 Write(Html.DisplayFor(model=>model.HotelName));

#line default
#line hidden
            EndContext();
            BeginContext(304, 69, true);
            WriteLiteral("</h4>\r\n            </div>\r\n            <div class=\"widget-content\">\r\n");
            EndContext();
#line 11 "D:\AZURE 301\ALL SOLUTIONS\VidyaSree_M1045514_MyStay_Clean_Architecture_Final\MyStay\MyStayMVC\MyStayMVC\Views\Room\RoomDetails.cshtml"
                 using (Html.BeginForm("SubmitRoomDetails", "Room", FormMethod.Post, new { @id = "SubmitRoomDetails" }))
                {
                    

#line default
#line hidden
            BeginContext(535, 44, false);
#line 13 "D:\AZURE 301\ALL SOLUTIONS\VidyaSree_M1045514_MyStay_Clean_Architecture_Final\MyStay\MyStayMVC\MyStayMVC\Views\Room\RoomDetails.cshtml"
               Write(Html.HiddenFor(model => model.ParentHotelID));

#line default
#line hidden
            EndContext();
#line 13 "D:\AZURE 301\ALL SOLUTIONS\VidyaSree_M1045514_MyStay_Clean_Architecture_Final\MyStay\MyStayMVC\MyStayMVC\Views\Room\RoomDetails.cshtml"
                                                                 ;  

#line default
#line hidden
            BeginContext(584, 115, true);
            WriteLiteral("                <div class=\"row\">\r\n                    <div class=\"form-group  col-md-3\">\r\n                        ");
            EndContext();
            BeginContext(700, 111, false);
#line 16 "D:\AZURE 301\ALL SOLUTIONS\VidyaSree_M1045514_MyStay_Clean_Architecture_Final\MyStay\MyStayMVC\MyStayMVC\Views\Room\RoomDetails.cshtml"
                   Write(Html.TextBoxFor(model => model.RoomNumber, new { @class = "form-control", @placeholder = "Enter Room Number" }));

#line default
#line hidden
            EndContext();
            BeginContext(811, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(838, 95, false);
#line 17 "D:\AZURE 301\ALL SOLUTIONS\VidyaSree_M1045514_MyStay_Clean_Architecture_Final\MyStay\MyStayMVC\MyStayMVC\Views\Room\RoomDetails.cshtml"
                   Write(Html.ValidationMessageFor(model => model.RoomNumber, "", new { @class = "label label-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(933, 109, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group col-md-3\">\r\n                        ");
            EndContext();
            BeginContext(1043, 431, false);
#line 20 "D:\AZURE 301\ALL SOLUTIONS\VidyaSree_M1045514_MyStay_Clean_Architecture_Final\MyStay\MyStayMVC\MyStayMVC\Views\Room\RoomDetails.cshtml"
                   Write(Html.DropDownListFor(model=>model.RoomType,new SelectList(new List<SelectListItem> {
                                             new SelectListItem { Text = "Luxury", Value = "Luxury"},
                                             new SelectListItem { Text = "Non-Luxury", Value = "Non-Luxury"}
                       },"Value","Text"),"-- Select Room Type --",
                       new { @class = "form-control col-md-3" }));

#line default
#line hidden
            EndContext();
            BeginContext(1474, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1501, 93, false);
#line 25 "D:\AZURE 301\ALL SOLUTIONS\VidyaSree_M1045514_MyStay_Clean_Architecture_Final\MyStay\MyStayMVC\MyStayMVC\Views\Room\RoomDetails.cshtml"
                   Write(Html.ValidationMessageFor(model => model.RoomType, "", new { @class = "label label-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1594, 110, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group  col-md-3\">\r\n                        ");
            EndContext();
            BeginContext(1705, 115, false);
#line 28 "D:\AZURE 301\ALL SOLUTIONS\VidyaSree_M1045514_MyStay_Clean_Architecture_Final\MyStay\MyStayMVC\MyStayMVC\Views\Room\RoomDetails.cshtml"
                   Write(Html.TextBoxFor(model => model.NumberofBeds, new {@class = "form-control", @placeholder = "Enter Number of Beds" }));

#line default
#line hidden
            EndContext();
            BeginContext(1820, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1847, 97, false);
#line 29 "D:\AZURE 301\ALL SOLUTIONS\VidyaSree_M1045514_MyStay_Clean_Architecture_Final\MyStay\MyStayMVC\MyStayMVC\Views\Room\RoomDetails.cshtml"
                   Write(Html.ValidationMessageFor(model => model.NumberofBeds, "", new { @class = "label label-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1944, 169, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"row\">\r\n                    <div class=\"form-group  col-md-3\">\r\n                        ");
            EndContext();
            BeginContext(2114, 581, false);
#line 34 "D:\AZURE 301\ALL SOLUTIONS\VidyaSree_M1045514_MyStay_Clean_Architecture_Final\MyStay\MyStayMVC\MyStayMVC\Views\Room\RoomDetails.cshtml"
                   Write(Html.DropDownListFor(model=>model.Service, new SelectList(new List<SelectListItem> {
                                           new SelectListItem { Text = "All-Day Breakfast", Value = "All-Day Breakfast"},
                                           new SelectListItem { Text = "Pick-up/Drop-off", Value = "Pick-up/Drop-off"},
                                           new SelectListItem { Text = "Luggage Forwarding", Value = "Luggage Forwarding"},
                     },"Value","Text"),"-- Select Service --",
                     new { @class = "form-control col-md-3" }));

#line default
#line hidden
            EndContext();
            BeginContext(2695, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(2722, 92, false);
#line 40 "D:\AZURE 301\ALL SOLUTIONS\VidyaSree_M1045514_MyStay_Clean_Architecture_Final\MyStay\MyStayMVC\MyStayMVC\Views\Room\RoomDetails.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Service, "", new { @class = "label label-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2814, 110, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group  col-md-3\">\r\n                        ");
            EndContext();
            BeginContext(2925, 99, false);
#line 43 "D:\AZURE 301\ALL SOLUTIONS\VidyaSree_M1045514_MyStay_Clean_Architecture_Final\MyStay\MyStayMVC\MyStayMVC\Views\Room\RoomDetails.cshtml"
                   Write(Html.TextBoxFor(model => model.Price, new {@class = "form-control", @placeholder = "Enter Price" }));

#line default
#line hidden
            EndContext();
            BeginContext(3024, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(3051, 90, false);
#line 44 "D:\AZURE 301\ALL SOLUTIONS\VidyaSree_M1045514_MyStay_Clean_Architecture_Final\MyStay\MyStayMVC\MyStayMVC\Views\Room\RoomDetails.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Price, "", new { @class = "label label-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3141, 389, true);
            WriteLiteral(@"
                    </div>
                    <div class=""form-group col-md-1a"">
                        <button type=""submit"" class=""btn btncusSave btn-block btn-flat"">Save</button>
                    </div>
                    <div class=""form-group col-md-1a"" style=""margin-left:-10px;"">
                        <button type=""button"" class=""btn btncusCancel btn-block btn-flat""");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3530, "\"", 3595, 3);
            WriteAttributeValue("", 3540, "location.href=\'", 3540, 15, true);
#line 50 "D:\AZURE 301\ALL SOLUTIONS\VidyaSree_M1045514_MyStay_Clean_Architecture_Final\MyStay\MyStayMVC\MyStayMVC\Views\Room\RoomDetails.cshtml"
WriteAttributeValue("", 3555, Url.Action("HotelDetails","HotelInfo"), 3555, 39, false);

#line default
#line hidden
            WriteAttributeValue("", 3594, "\'", 3594, 1, true);
            EndWriteAttribute();
            BeginContext(3596, 70, true);
            WriteLiteral(">Cancel</button>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 53 "D:\AZURE 301\ALL SOLUTIONS\VidyaSree_M1045514_MyStay_Clean_Architecture_Final\MyStay\MyStayMVC\MyStayMVC\Views\Room\RoomDetails.cshtml"
                }

#line default
#line hidden
            BeginContext(3685, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(3706, 112, false);
#line 54 "D:\AZURE 301\ALL SOLUTIONS\VidyaSree_M1045514_MyStay_Clean_Architecture_Final\MyStay\MyStayMVC\MyStayMVC\Views\Room\RoomDetails.cshtml"
               Write(Html.Partial("~/Views/Room/_RoomDetailsList.cshtml", (List<MyStayMVC.Models.RoomDetails>)(Model.lstRoomDetails)));

#line default
#line hidden
            EndContext();
            BeginContext(3818, 98, true);
            WriteLiteral("\r\n            </div>\r\n            \r\n        </div>\r\n        <!-- /Validation Example 1 -->\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyStayMVC.Models.RoomDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591