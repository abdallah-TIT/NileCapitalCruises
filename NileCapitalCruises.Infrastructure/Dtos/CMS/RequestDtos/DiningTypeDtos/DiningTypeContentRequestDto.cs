using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.DiningTypeDtos
{
    public class DiningTypeContentRequestDto
    {
        [MaxLength(150)]
        public string? DiningTypeName { get; set; }

      
        public bool? ContentLangStatus { get; set; }
    }
}
