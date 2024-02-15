using AutoMapper;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CruiseDtos;

namespace NileCapitalCruises.Infrastructure.Data.Specification.CMS.CruiseSpecification
{
    public class CruiseSpecification : BaseSpecification<Cruise>
    {
        private readonly IMapper _mapper;

        //public CruiseSpecification(PaginationSpecParams paginationSpecParams, int companyId) : base(
        //    x => (string.IsNullOrEmpty(paginationSpecParams.Search) || x.CruiseNameSys.ToLower().Contains(paginationSpecParams.Search)) && (x.IsDeleted == false) && (x.CompanyId == companyId))
        //{
        //    ApplyPaging(paginationSpecParams.PageSize * (paginationSpecParams.PageIndex - 1), paginationSpecParams.PageSize);


        //    AddInclude(x => x.CruiseContents.Where(c => c.Language.LanguageAbbreviation == paginationSpecParams.LanguageCode));
        //}

        public CruiseSpecification(PaginationSpecParams paginationSpecParams, int companyId, int? companyUserId) : base(
            x => (string.IsNullOrEmpty(paginationSpecParams.Search) || x.CruiseNameSys.ToLower().Contains(paginationSpecParams.Search)) && x.IsDeleted == false && x.CompanyId == companyId && (!companyUserId.HasValue || x.CompanyUserCruises.Any(ccu => ccu.CompanyUserId == companyUserId && ccu.IsDeleted == false)))
        {
            ApplyPaging(paginationSpecParams.PageSize * (paginationSpecParams.PageIndex - 1), paginationSpecParams.PageSize);


            //AddInclude(x => x.CompanyUserCruises);
            AddInclude(x => x.CruiseContents.Where(c => c.Language.LanguageAbbreviation == paginationSpecParams.LanguageCode));
        }

        public CruiseSpecification(int cruiseId, int companyId) : base(x => x.Id == cruiseId && x.CompanyId == companyId && x.IsDeleted == false)
        {

        }

        public CruiseSpecification(int id, string languageCode, IMapper mapper) : base(x => x.Id == id)
        {
            AddInclude(x => x.CruiseContents.Where(c => c.Language.LanguageAbbreviation == languageCode));
            AddInclude(x => x.CruisePhotos.Where(cp => cp.CruiseId == id));
            AddSelect(x => _mapper.Map<CruisesResponseDto>(x));
        }

        public CruiseSpecification(string cruiseUrl) : base(x => x.CruiseUrl == cruiseUrl)
        {
        }
    }
}
