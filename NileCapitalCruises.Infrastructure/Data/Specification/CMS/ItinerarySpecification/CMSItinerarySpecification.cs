﻿using AutoMapper;
using NileCapitalCruises.Core.Models;
using NileCapitalCruises.Infrastructure.Dtos.CMS.ResponseDtos.CruiseDtos;

namespace NileCapitalCruises.Infrastructure.Data.Specification.CMS.ItinerarySpecification
{
    public class CMSItinerarySpecification : BaseSpecification<Itinerary>
    {
        private readonly IMapper _mapper;



        public CMSItinerarySpecification(PaginationSpecParams paginationSpecParams, int cruiseId) : base(
            x => (string.IsNullOrEmpty(paginationSpecParams.Search) || x.ItineraryNameSys.ToLower().Contains(paginationSpecParams.Search)) && x.IsDeleted == false && x.CruiseId == cruiseId)
        {
            ApplyPaging(paginationSpecParams.PageSize * (paginationSpecParams.PageIndex - 1), paginationSpecParams.PageSize);


            AddInclude(x => x.ItineraryContents.Where(c => c.Language.LanguageAbbreviation == paginationSpecParams.LanguageCode));
            AddInclude(x => x.Duration);
            AddInclude(x => x.Company.CompanyContents.Where(c => c.Language.LanguageAbbreviation == paginationSpecParams.LanguageCode));
            AddInclude(x => x.Cruise.CruiseContents.Where(c => c.Language.LanguageAbbreviation == paginationSpecParams.LanguageCode));
            AddInclude(x => x.ItineraryType.ItineraryTypeContents.Where(c => c.Language.LanguageAbbreviation == paginationSpecParams.LanguageCode));
            AddInclude(x => x.WeekDay.WeekDayContents.Where(c => c.Language.LanguageAbbreviation == paginationSpecParams.LanguageCode));
            AddInclude(x => x.CityFrom.CityContents.Where(c => c.Language.LanguageAbbreviation == paginationSpecParams.LanguageCode));
            AddInclude(x => x.CityTo.CityContents.Where(c => c.Language.LanguageAbbreviation == paginationSpecParams.LanguageCode));
        }

        public CMSItinerarySpecification(int itineraryId, int companyId) : base(x => x.Id == itineraryId && x.CompanyId == companyId && x.IsDeleted == false)
        {

        }

        public CMSItinerarySpecification(int itineraryId) : base(x => x.Id == itineraryId && x.IsDeleted == false)
        {

        }
    }
}
