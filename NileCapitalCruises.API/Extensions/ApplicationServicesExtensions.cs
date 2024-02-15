using NileCapitalCruises.API.Errors;
using NileCapitalCruises.Core.IRepositories;
using NileCapitalCruises.Infrastructure.Data.Repositories;
using NileCapitalCruises.Infrastructure.Helpers.Utils;
using NileCapitalCruises.Infrastructure.IServices;
using NileCapitalCruises.Infrastructure.IServices.BookingEngine;
using NileCapitalCruises.Infrastructure.IServices.CMS;
using NileCapitalCruises.Infrastructure.Services;
using NileCapitalCruises.Infrastructure.Services.BookingEngine;
using NileCapitalCruises.Infrastructure.Services.CMS;
using Microsoft.AspNetCore.Mvc;

namespace NileCapitalCruises.API.Extensions
{
    public static class ApplicationServicesExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {

            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<ICompanyUserRepo, CompanyUserRepo>();

            services.AddScoped<ILanguageService, LanguageService>();
            services.AddScoped<IFacilityService, FacilityService>();
            services.AddScoped<ICompanyUserService, CompanyUserService>();
            services.AddScoped<IOperationDateService, OperationDateService>();

            services.AddScoped<ICruiseService, CruiseService>();
            services.AddScoped<BEIOperationDateService, BEOperationDateService>();
            services.AddScoped<IBrandService, BrandService>();
            services.AddScoped<IAmenityService, AmenityService>();
            services.AddScoped<ICabinService, CabinService>();
            services.AddScoped<ICruiseFacilityService, CruiseFacilityService>();
            services.AddScoped<ICabinAmenityService, CabinAmenityService>();
            services.AddScoped<ICompanyService, CompanyService>();
            services.AddScoped<ICityService, CityService>();
            services.AddScoped<CMSIItineraryService, CMSItineraryService>();
            services.AddScoped<IWeekDayService, WeekDayService>();
            services.AddScoped<CMSIDurationService, CMSDurationService>();
            services.AddScoped<IItineraryTypeService, ItineraryTypeService>();
            services.AddScoped<BEIItineraryTypeService, BEItineraryTypeService>();
            services.AddScoped<BEIItineraryService, BEItineraryService>();
            services.AddScoped<BEICabinTypeCruiseService, BECabinTypeCruiseService>();
            services.AddScoped<IDiningTypeService, DiningTypeService>();
            services.AddScoped<IDiningService, DiningService>();
            services.AddScoped<ICompanyUserCruiseService, CompanyUserCruiseService>();
            services.AddScoped<ICruiseCategoryService, CruiseCategoryService>();
            services.AddScoped<ICabinTypeService, CabinTypeService>();
            services.AddScoped<IAuthinticateService, AuthinticateService>();
            services.AddScoped<ICabinTypeCruiseService, CabinTypeCruiseService>();

            services.AddHttpContextAccessor();


            services.AddScoped(typeof(IHandleContents<>), typeof(HandleContents<>));

            services.AddScoped(typeof(IGenericRepo<>), typeof(GenericRepo<>));

            //services.AddCors(options => {
            //    options.AddPolicy("AllowSpecificOrigin", builder => builder.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader());
            //});

            services.AddCors(options => {
                options.AddPolicy("AllowAnyOrigin", builder => builder
                    .AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.InvalidModelStateResponseFactory = actionContext =>
                {
                    var errors = actionContext.ModelState.Where(e => e.Value.Errors.Count > 0)
                        .SelectMany(x => x.Value.Errors)
                        .Select(x => x.ErrorMessage).ToArray();
                    var errorResponse = new ApiValidationErrorResponse { Errors = errors };
                    return new BadRequestObjectResult(errorResponse);
                };
            });


            return services;
        }
    }
}
