using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NileCapitalCruises.Core.Models
{
    [Table("tbl_Master_Languages")]
    public class Language : BaseEntity
    {
        public Language()
        {
           
        }

        [MaxLength(150)]
        public string? LanguageName { get; set; }

        [MaxLength(150)]
        public string? LanguageFlag { get; set; } = "Empty String please change it";

        [MaxLength(10)]
        public string? LanguageAbbreviation { get; set; }

        public bool? Status { get; set; } = false;

        [MaxLength(250)]
        public string? LanguageClass { get; set; } = "Empty String please change it";

        public bool? IsDeleted { get; set; } = false;


    }
}
