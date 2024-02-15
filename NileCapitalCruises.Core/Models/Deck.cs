using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace NileCapitalCruises.Core.Models
{
    [Table("tbl_CruiseBooking_Decks")]
    [Index(nameof(CruiseId), Name = "IX_tbl_CruiseBooking_Decks_CruiseId")]
    public class Deck : BaseEntity
    {
        public Deck()
        {
            Cabins = new HashSet<Cabin>();
            
        }
        public int? CruiseId { get; set; }
        public int? DeckPosition { get; set; }
        [MaxLength(150)]
        public string? DeckNameSys { get; set; }
        [MaxLength(250)]
        public string? DeckPhoto { get; set; }
        public int? DeckPhotoWidth { get; set; }
        public int? DeckPhotoHeight { get; set; }

        public virtual Cruise? Cruise { get; set; }
        public bool? IsDeleted { get; set; } = false;
        public virtual ICollection<Cabin> Cabins { get; set; }
    }
}
