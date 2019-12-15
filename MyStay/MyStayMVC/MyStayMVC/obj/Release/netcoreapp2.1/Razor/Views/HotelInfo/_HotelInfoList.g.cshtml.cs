#pragma checksum "D:\Azure301\CleanArchitecture\MyStay\MyStayMVC\MyStayMVC\Views\HotelInfo\_HotelInfoList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acee713f804c4ea7df0169f69e54fe95dac7420c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HotelInfo__HotelInfoList), @"mvc.1.0.view", @"/Views/HotelInfo/_HotelInfoList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HotelInfo/_HotelInfoList.cshtml", typeof(AspNetCore.Views_HotelInfo__HotelInfoList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acee713f804c4ea7df0169f69e54fe95dac7420c", @"/Views/HotelInfo/_HotelInfoList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"863dbab1b8b531b0197e3ae0515987d35ebb1129", @"/Views/_ViewImports.cshtml")]
    public class Views_HotelInfo__HotelInfoList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 32, true);
            WriteLiteral("<div id=\"divHotelInfoDetails\">\r\n");
            EndContext();
#line 2 "D:\Azure301\CleanArchitecture\MyStay\MyStayMVC\MyStayMVC\Views\HotelInfo\_HotelInfoList.cshtml"
     if (Model.lstHotelInfo.Count > 0)
    {

#line default
#line hidden
            BeginContext(79, 332, true);
            WriteLiteral(@"        <table class=""table table-hover table-striped table-responsive"">
            <thead font-weight:bold;"" style=""background-color:#d3d3d36e;"">
                <tr>
                    <th>Hotel Name</th>
                    <th>Address</th>
                    <th>Rooms</th>
                </tr>
            </thead>
");
            EndContext();
#line 12 "D:\Azure301\CleanArchitecture\MyStay\MyStayMVC\MyStayMVC\Views\HotelInfo\_HotelInfoList.cshtml"
             foreach (HotelInfo oHotelInfo in Model.lstHotelInfo)
            {

#line default
#line hidden
            BeginContext(493, 72, true);
            WriteLiteral("                <tr style=\"line-height:14px;\">\r\n                    <td>");
            EndContext();
            BeginContext(566, 15, false);
#line 15 "D:\Azure301\CleanArchitecture\MyStay\MyStayMVC\MyStayMVC\Views\HotelInfo\_HotelInfoList.cshtml"
                   Write(oHotelInfo.Name);

#line default
#line hidden
            EndContext();
            BeginContext(581, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(613, 18, false);
#line 16 "D:\Azure301\CleanArchitecture\MyStay\MyStayMVC\MyStayMVC\Views\HotelInfo\_HotelInfoList.cshtml"
                   Write(oHotelInfo.Address);

#line default
#line hidden
            EndContext();
            BeginContext(631, 59, true);
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 690, "\"", 801, 1);
#line 18 "D:\Azure301\CleanArchitecture\MyStay\MyStayMVC\MyStayMVC\Views\HotelInfo\_HotelInfoList.cshtml"
WriteAttributeValue("", 697, Url.Action("GetRoomDetails", "Room", new { ID = oHotelInfo.ID.ToString(),HotelName = oHotelInfo.Name }), 697, 104, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(802, 124, true);
            WriteLiteral(">\r\n                           Room Details\r\n                        </a>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 23 "D:\Azure301\CleanArchitecture\MyStay\MyStayMVC\MyStayMVC\Views\HotelInfo\_HotelInfoList.cshtml"
            }

#line default
#line hidden
            BeginContext(941, 18, true);
            WriteLiteral("        </table>\r\n");
            EndContext();
#line 25 "D:\Azure301\CleanArchitecture\MyStay\MyStayMVC\MyStayMVC\Views\HotelInfo\_HotelInfoList.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(983, 60, true);
            WriteLiteral("        <div>\r\n            No Hotels found\r\n        </div>\r\n");
            EndContext();
#line 31 "D:\Azure301\CleanArchitecture\MyStay\MyStayMVC\MyStayMVC\Views\HotelInfo\_HotelInfoList.cshtml"
    }

#line default
#line hidden
            BeginContext(1050, 6, true);
            WriteLiteral("</div>");
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
