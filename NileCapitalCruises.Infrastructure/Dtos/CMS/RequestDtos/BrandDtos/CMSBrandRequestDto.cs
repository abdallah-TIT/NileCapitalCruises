using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.BrandDtos
{
    public class CMSBrandRequestDto
    {


        [MaxLength(150)]
        
        public string? BrandNameSys { get; set; }



      

    }
}
