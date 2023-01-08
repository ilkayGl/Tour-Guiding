#pragma checksum "C:\Users\User\Masaustu\Travelsal\TravelsalPresentationUI\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17ca413e7f59dbbe117a03d0379e93c06f9a55f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TravelsalPresentationUI.Pages.Reservation.Areas_Member_Views_Reservation_MyApprovalReservation), @"mvc.1.0.view", @"/Areas/Member/Views/Reservation/MyApprovalReservation.cshtml")]
namespace TravelsalPresentationUI.Pages.Reservation
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
#line 1 "C:\Users\User\Masaustu\Travelsal\TravelsalPresentationUI\Areas\Member\Views\_ViewImports.cshtml"
using TravelsalPresentationUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Masaustu\Travelsal\TravelsalPresentationUI\Areas\Member\Views\_ViewImports.cshtml"
using TravelsalPresentationUI.Areas.Member.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Masaustu\Travelsal\TravelsalPresentationUI\Areas\Member\Views\_ViewImports.cshtml"
using EntitiyLayer.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\User\Masaustu\Travelsal\TravelsalPresentationUI\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17ca413e7f59dbbe117a03d0379e93c06f9a55f1", @"/Areas/Member/Views/Reservation/MyApprovalReservation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73f223ab3499fabcfcb1c696eca68d31a990a77e", @"/Areas/Member/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Member_Views_Reservation_MyApprovalReservation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Reservation>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\User\Masaustu\Travelsal\TravelsalPresentationUI\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml"
  
    ViewData["Title"] = "MyApprovalReservation";
    Layout = "~/Areas/Member/Views/Shared/_MemberLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Onay bekleyen rezervasyonlar</h1>

<table class=""table table-bordered"">
    <tr>
        <th>#</th>
        <th>Lokasyon</th>
        <th>Kişi Sayısı</th>
        <th>Oluşturulma Tarihi</th>
        <th>Rezervasyon Tarihi</th>
        <th>Açıklama</th>
        <th>Durum</th>
    </tr>
");
#nullable restore
#line 21 "C:\Users\User\Masaustu\Travelsal\TravelsalPresentationUI\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>#</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\User\Masaustu\Travelsal\TravelsalPresentationUI\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml"
           Write(item.Destination.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\User\Masaustu\Travelsal\TravelsalPresentationUI\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml"
           Write(item.PersonCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\User\Masaustu\Travelsal\TravelsalPresentationUI\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml"
           Write(item.CreationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\User\Masaustu\Travelsal\TravelsalPresentationUI\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml"
           Write(item.ReservationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\User\Masaustu\Travelsal\TravelsalPresentationUI\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml"
           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\User\Masaustu\Travelsal\TravelsalPresentationUI\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml"
           Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 33 "C:\Users\User\Masaustu\Travelsal\TravelsalPresentationUI\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Reservation>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
