using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using System.Text.Json.Serialization;
using System.Xml.Linq;

namespace NileCapitalCruises.Core.Models
{
    [Table("tbl_Master_Itineraries_Types_Contents")]
    [Index(nameof(LanguageId), Name = "IX_tbl_Master_Itineraries_Types_Contents_LanguageId")]
    [Index(nameof(OriginalTableId), Name = "IX_tbl_Master_Itineraries_Types_Contents_ItineraryTypeId")]
    public class ItineraryTypeContent : BaseEntity
    {
        public ItineraryTypeContent()
        {
        }

        [MaxLength(150)]
        public string? ItineraryTypeName { get; set; }
        public bool? ContentLangStatus { get; set; } = false;
        public int? LanguageId { get; set; }

        [ForeignKey("ItineraryType")]
        [Column("ItineraryTypeId")]
        public int? OriginalTableId { get; set; }


        public virtual Language? Language { get; set; }

        [JsonIgnore]
        public virtual ItineraryType? ItineraryType { get; set; }
        public bool? IsDeleted { get; set; } = false;

    }
}
