using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NileCapitalCruises.Core.Models
{
    [Table("tbl_CruiseBooking_Cruises")]

    public class Cruise : BaseEntity
    {
        public Cruise()
        {
            Cabins = new HashSet<Cabin>();
            CruiseContents = new HashSet<CruiseContent>();
            CompanyUserCruises = new HashSet<CompanyUserCruise>();
            CruisePhotos = new HashSet<CruisePhoto>();
            CruiseDecks = new HashSet<Deck>();
            Dinings = new HashSet<Dining>();
            OperationDates = new HashSet<OperationDate>();
            CruiseFacilities = new HashSet<CruiseFacility>();
            Seasons = new HashSet<Season>();
            Periods = new HashSet<Period>();
            
            
            CabinTypeCruises = new HashSet<CabinTypeCruise>();
        }


        

        [MaxLength(150)]
        public string? CruiseNameSys { get; set; }
        public bool? CruiseStatus { get; set; }
        public int? CabinNumbers { get; set; }
        public int? DeckNumbers { get; set; }

        public int? CruiseCategoryId { get; set; }

        [MaxLength(150)]
        public string? CruiseUrl { get; set; }

        [MaxLength(150)]
        public string? CruisePhoto { get; set; }

        [MaxLength(150)]
        public string? CruiseLogo { get; set; }

        [MaxLength(150)]
        public string? CruiseBanner { get; set; }
        
        public int? CruisePhotoWidth { get; set; }
        public int? CruisePhotoHeight { get; set; }
        public int? CruiseLogoWidth { get; set; }
        public int? CruiseLogoHeight { get; set; }
        public int? CruiseBannerWidth { get; set; }
        public int? CruiseBannerHeight { get; set; }

        [MaxLength(150)]
        public string? CruiseDeckPlan { get; set; }
        public int? CruiseDeckPlanWidth { get; set; }
        public int? CruiseDeckPlanHeight { get; set; }
        public int? CruisePosition { get; set; }

        [MaxLength(150)]
        public string? CruiseLength { get; set; }
        [MaxLength(150)]
        public string? CruiseWidth { get; set; }
        [MaxLength(150)]
        public string? CruiseHeight { get; set; }
        [MaxLength(150)]
        public string? CruiseOopeningYear { get; set; }
        [MaxLength(150)]
        public string? CruiseRenovationYear { get; set; }
        [MaxLength(150)]
        public string? CruiseReservationEmail { get; set; }
        [MaxLength(150)]
        public string? CruiseGeneralEmail { get; set; }
        [MaxLength(150)]
        public string? CruiseCheckIn { get; set; }
        [MaxLength(150)]
        public string? CruiseCheckout { get; set; }
        [MaxLength(150)]
        public string? WsBooking { get; set; }
        [MaxLength(150)]
        public string? WsExpedia { get; set; }
        [MaxLength(150)]
        public string? WsAgouda { get; set; }
        [MaxLength(150)]
        public string? WsFacebook { get; set; }
        [MaxLength(150)]
        public string? WsInstgram { get; set; }
        [MaxLength(150)]
        public string? WsX { get; set; }
        [MaxLength(150)]
        public string? WsSnapChat { get; set; }
        [MaxLength(150)]
        public string? WsTikTok { get; set; }
        [MaxLength(150)]
        public string? WslinkdIn { get; set; }
        [MaxLength(150)]
        public string? WsTripAdvisor { get; set; }
        [MaxLength(150)]
        public string? WsYoutube { get; set; }
        [MaxLength(150)]
        public string? WsGoogle { get; set; }
        [MaxLength(150)]
        public string? WsBrandUrl { get; set; }
        [MaxLength(150)]
        public string? ContactGmName { get; set; }
        [MaxLength(150)]
        public string? ContactGmMobile { get; set; }
        [MaxLength(150)]
        public string? ContactGmEmail { get; set; }
        [MaxLength(150)]
        public string? ContactSalesName { get; set; }
        [MaxLength(150)]
        public string? ContactSalesMobile { get; set; }
        [MaxLength(150)]
        public string? ContactSalesEmail { get; set; }
        [MaxLength(150)]
        public string? ContactReservationName { get; set; }
        [MaxLength(150)]
        public string? ContactReservationMobile { get; set; }
        [MaxLength(150)]
        public string? ContactReservationEmail { get; set; }
        [MaxLength(150)]
        public string? ContactFinanceName { get; set; }
        [MaxLength(150)]
        public string? ContactFininaceMobile { get; set; }
        [MaxLength(150)]
        public string? ContactFininaceEmail { get; set; }
        [MaxLength(150)]
        public string? ContactMarketingName { get; set; }
        [MaxLength(150)]
        public string? ContactMarketingMobile { get; set; }
        [MaxLength(150)]
        public string? ContactMarketingEmail { get; set; }

        public int? CompanyId { get; set; }
        public int? BrandId { get; set; }

        public bool? IsDeleted { get; set; } = false;

        public virtual Company? Company { get; set; }

        [InverseProperty("Cruise")]
        public virtual ICollection<CompanyUserCruise> CompanyUserCruises { get; set; }

        [InverseProperty("Cruise")]
        public virtual ICollection<CabinTypeCruise> CabinTypeCruises { get; set; }

        public virtual CruiseCategory? CruiseCategory { get; set; }
        public virtual Brand? Brand { get; set; }
        public virtual ICollection<Cabin> Cabins { get; set; }
        public virtual ICollection<CruiseContent> CruiseContents { get; set; }

        public virtual ICollection<CruisePhoto> CruisePhotos { get; set; }
        public virtual ICollection<Deck> CruiseDecks { get; set; }

        public virtual ICollection<Dining> Dinings { get; set; }

        public virtual ICollection<OperationDate> OperationDates { get; set; }

        [InverseProperty("Cruise")]
        public virtual ICollection<CruiseFacility> CruiseFacilities { get; set; }
        public virtual ICollection<Season> Seasons { get; set; }
        public virtual ICollection<Period> Periods { get; set; }
       
    }
}
