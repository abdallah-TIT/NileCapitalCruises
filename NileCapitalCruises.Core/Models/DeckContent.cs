using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace NileCapitalCruises.Core.Models
{
    [Table("tbl_CruiseBooking_Decks_Contents")]
    [Index(nameof(LanguageId), Name = "IX_tbl_CruiseBooking_Decks_Content_LangId")]
    [Index(nameof(OriginalTableId), Name = "IX_tbl_CruiseBooking_Decks_Content_DeckId")]
    public class DeckContent : BaseEntity
    {
        [ForeignKey("Deck")]
        [Column("DeckId")]
        public int? OriginalTableId { get; set; }
        public int? LanguageId { get; set; }
        public bool? ContentLangStatus { get; set; }
        [MaxLength(150)]
        public string? DeckName { get; set; }
        public bool? IsDeleted { get; set; } = false;
        public virtual Language? Language { get; set; }
    }
}
