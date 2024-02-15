using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.DiningDtos
{
    public class UpdateDiningRequestDto
    {
       

        [MaxLength(150)]
        public string? DiningNameSys { get; set; }
        [MaxLength(150)]
        public string? DiningHours { get; set; }

        
        [MaxLength(250)]
        public string? DressCode { get; set; }
        [MaxLength(250)]
        public string? DiningCuisine { get; set; }
        [MaxLength(250)]
        public string? DiningOpenFor { get; set; }
        [MaxLength(250)]
        public string? DiningMenu { get; set; }
        [MaxLength(250)]
        public string? DiningFolderName { get; set; }
        [MaxLength(250)]
        public string? DiningPhoto { get; set; }

       
      

    }
}
