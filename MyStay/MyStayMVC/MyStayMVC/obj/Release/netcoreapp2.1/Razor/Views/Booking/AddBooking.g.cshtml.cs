#pragma checksum "D:\Azure301\CleanArchitecture\MyStay\MyStayMVC\MyStayMVC\Views\Booking\AddBooking.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7abd2f8dc326cdcdc0f941c1b9e794066027f198"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking_AddBooking), @"mvc.1.0.view", @"/Views/Booking/AddBooking.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Booking/AddBooking.cshtml", typeof(AspNetCore.Views_Booking_AddBooking))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7abd2f8dc326cdcdc0f941c1b9e794066027f198", @"/Views/Booking/AddBooking.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"863dbab1b8b531b0197e3ae0515987d35ebb1129", @"/Views/_ViewImports.cshtml")]
    public class Views_Booking_AddBooking : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyStayMVC.Models.Booking>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Azure301\CleanArchitecture\MyStay\MyStayMVC\MyStayMVC\Views\Booking\AddBooking.cshtml"
  
    ViewData["Title"] = "BookingDetails";
    ViewBag.Active = "Booking";

#line default
#line hidden
            BeginContext(116, 340, true);
            WriteLiteral(@"
<script type=""text/javascript"">
    $(document).ready(function () {
        $(""#StartDate"").datepicker();
        $(""#EndDate"").datepicker();
    });
</script>
<div class=""widget box"">
    <div class=""widget-header"">
        <h4><i class=""icon-reorder""></i> Add Booking Details</h4>
    </div>
    <div class=""widget-content"">
");
            EndContext();
#line 18 "D:\Azure301\CleanArchitecture\MyStay\MyStayMVC\MyStayMVC\Views\Booking\AddBooking.cshtml"
         using (Html.BeginForm("SubmitBookingDetails", "Booking", FormMethod.Post, new { @id = "SubmitBookingDetails" }))
        {

#line default
#line hidden
            BeginContext(590, 209, true);
            WriteLiteral("            <div class=\"row\">\r\n                <label class=\"col-md-2 control-label\">Hotel Name <span class=\"required\">*</span></label>\r\n                <div class=\"form-group  col-md-3\">\r\n                    ");
            EndContext();
            BeginContext(800, 246, false);
#line 23 "D:\Azure301\CleanArchitecture\MyStay\MyStayMVC\MyStayMVC\Views\Booking\AddBooking.cshtml"
               Write(Html.DropDownListFor(model => model.ParentHotelID,
                                            (IEnumerable<SelectListItem>)(ViewBag.lstHotelInfo), "--Select Hotel --",
                                            new {@class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1046, 255, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <label class=\"col-md-2 control-label\">Room Number <span class=\"required\">*</span></label>\r\n                <div class=\"form-group col-md-3\">\r\n                    ");
            EndContext();
            BeginContext(1302, 238, false);
#line 31 "D:\Azure301\CleanArchitecture\MyStay\MyStayMVC\MyStayMVC\Views\Booking\AddBooking.cshtml"
               Write(Html.DropDownListFor(model => model.ParentRoomID,
                                       (IEnumerable<SelectListItem>)(ViewBag.lstRooms), "-- Select Room Number --",
                                        new {@class = "form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(1540, 254, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <label class=\"col-md-2 control-label\">Start Date<span class=\"required\">*</span></label>\r\n                <div class=\"form-group  col-md-2\">\r\n                    ");
            EndContext();
            BeginContext(1795, 133, false);
#line 39 "D:\Azure301\CleanArchitecture\MyStay\MyStayMVC\MyStayMVC\Views\Booking\AddBooking.cshtml"
               Write(Html.TextBoxFor(model => model.StartDate, new { @autocomplete = "off", @class = "form-control", @placeholder = "Select Start Date" }));

#line default
#line hidden
            EndContext();
            BeginContext(1928, 252, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <label class=\"col-md-2 control-label\">End Date<span class=\"required\">*</span></label>\r\n                <div class=\"form-group  col-md-2\">\r\n                    ");
            EndContext();
            BeginContext(2181, 129, false);
#line 45 "D:\Azure301\CleanArchitecture\MyStay\MyStayMVC\MyStayMVC\Views\Booking\AddBooking.cshtml"
               Write(Html.TextBoxFor(model => model.EndDate, new { @autocomplete = "off", @class = "form-control", @placeholder = "Select End Date" }));

#line default
#line hidden
            EndContext();
            BeginContext(2310, 462, true);
            WriteLiteral(@"
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-4""></div>
                <div class=""form-group col-md-1a"">
                    <button type=""submit"" class=""btn btncusSave btn-block btn-flat"">Save</button>
                </div>
                <div class=""form-group col-md-1a"" style=""margin-left:-10px;"">
                    <button type=""button"" class=""btn btncusCancel btn-block btn-flat""");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2772, "\"", 2837, 3);
            WriteAttributeValue("", 2782, "location.href=\'", 2782, 15, true);
#line 54 "D:\Azure301\CleanArchitecture\MyStay\MyStayMVC\MyStayMVC\Views\Booking\AddBooking.cshtml"
WriteAttributeValue("", 2797, Url.Action("BookingDetails","Booking"), 2797, 39, false);

#line default
#line hidden
            WriteAttributeValue("", 2836, "\'", 2836, 1, true);
            EndWriteAttribute();
            BeginContext(2838, 62, true);
            WriteLiteral(">Cancel</button>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 57 "D:\Azure301\CleanArchitecture\MyStay\MyStayMVC\MyStayMVC\Views\Booking\AddBooking.cshtml"
        }

#line default
#line hidden
            BeginContext(2911, 54, true);
            WriteLiteral("    </div>\r\n\r\n</div>\r\n<!-- /Validation Example 1 -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyStayMVC.Models.Booking> Html { get; private set; }
    }
}
#pragma warning restore 1591