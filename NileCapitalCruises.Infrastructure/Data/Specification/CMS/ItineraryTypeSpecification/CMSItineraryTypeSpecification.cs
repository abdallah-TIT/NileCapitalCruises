using AutoMapper;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CruiseDtos;

namespace NileCapitalCruises.Infrastructure.Data.Specification.CMS.ItineraryTypeSpecification
{
    public class CMSItineraryTypeSpecification : BaseSpecification<ItineraryType>
    {
        private readonly IMapper _mapper;

        public CMSItineraryTypeSpecification(PaginationSpecParams paginationSpecParams) : base(
            x => (string.IsNullOrEmpty(paginationSpecParams.Search) || x.ItineraryTypeNameSys.ToLower().Contains(paginationSpecParams.Search)) && x.IsDeleted == false
            )
        {
            ApplyPaging(paginationSpecParams.PageSize * (paginationSpecParams.PageIndex - 1), paginationSpecParams.PageSize);
            AddInclude(x => x.ItineraryTypeContents.Where(c => c.Language.LanguageAbbreviation == paginationSpecParams.LanguageCode));

        }


        public CMSItineraryTypeSpecification(int itineraryTypesId) : base(x => x.Id == itineraryTypesId && x.IsDeleted == false)
        {

        }

        //public CruiseSpecification(string cruiseUrl) : base(x => x.CruiseUrl == cruiseUrl)
        //{
        //}
    }
}
