using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CruiseDtos
{
    public class CMSCruiseRequestDto
    {
        public int? CruiseLocationId { get; set; }
        //public string? CruiseUsername { get; set; }
        //public string? CruisePassword { get; set; }
        public string? CruiseNameSys { get; set; }
        public bool? CruiseStatus { get; set; }
        public int? CabinNumbers { get; set; }
        public int? DeckNumbers { get; set; }

        [Required]
        public int? BrandId { get; set; }
        public string? CruisePhoto { get; set; }
        public string? CruiseLogo { get; set; }
        public string? CruiseBanner { get; set; }

        [Required]
        public int? CruiseCategoryId { get; set; }
        public int? CruisePhotoWidth { get; set; }
        public int? CruisePhotoHeight { get; set; }
        public int? CruiseLogoWidth { get; set; }
        public int? CruiseLogoHeight { get; set; }
        public int? CruiseBannerWidth { get; set; }
        public int? CruiseBannerHeight { get; set; }
        public string? CruiseDeckPlan { get; set; }
        public int? CruiseDeckPlanWidth { get; set; }
        public int? CruiseDeckPlanHeight { get; set; }
        public int? CruisePosition { get; set; }
        public string? CruiseLength { get; set; }
        public string? CruiseWidth { get; set; }
        public string? CruiseHeight { get; set; }
        public string? CruiseOopeningYear { get; set; }
        public string? CruiseRenovationYear { get; set; }
        public string? CruiseReservationEmail { get; set; }
        public string? CruiseGeneralEmail { get; set; }
        public string? CruiseCheckIn { get; set; }
        public string? CruiseCheckout { get; set; }
        public string? WsBooking { get; set; }
        public string? WsExpedia { get; set; }
        public string? WsAgouda { get; set; }
        public string? WsFacebook { get; set; }
        public string? WsInstgram { get; set; }
        public string? WsX { get; set; }
        public string? WsSnapChat { get; set; }
        public string? WsTikTok { get; set; }
        public string? WslinkdIn { get; set; }
        public string? WsTripAdvisor { get; set; }
        public string? WsYoutube { get; set; }
        public string? WsGoogle { get; set; }
        public string? WsBrandUrl { get; set; }
        public string? ContactGmName { get; set; }
        public string? ContactGmMobile { get; set; }
        public string? ContactGmEmail { get; set; }
        public string? ContactSalesName { get; set; }
        public string? ContactSalesMobile { get; set; }
        public string? ContactSalesEmail { get; set; }
        public string? ContactReservationName { get; set; }
        public string? ContactReservationMobile { get; set; }
        public string? ContactReservationEmail { get; set; }
        public string? ContactFinanceName { get; set; }
        public string? ContactFininaceMobile { get; set; }
        public string? ContactFininaceEmail { get; set; }
        public string? ContactMarketingName { get; set; }
        public string? ContactMarketingMobile { get; set; }
        public string? ContactMarketingEmail { get; set; }
    }
}
