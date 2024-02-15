
using NileCapitalCruises.Core.ApiModels;
using NileCapitalCruises.Core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace NileCapitalCruises.Infrastructure.Data
{
    public partial class NileCapitalCruisesWSDBContext : IdentityDbContext<ApplicationUser, IdentityRole<int>, int>
    {
        public NileCapitalCruisesWSDBContext()
        {
        }

        public NileCapitalCruisesWSDBContext(DbContextOptions<NileCapitalCruisesWSDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspstateTempApplication> AspstateTempApplications { get; set; } = null!;
        public virtual DbSet<AspstateTempSession> AspstateTempSessions { get; set; } = null!;

        public virtual DbSet<Language> Languages { get; set; } = null!;

        public virtual DbSet<Company> Companies { get; set; } = null!;
        public virtual DbSet<CompanyContent> CompanyContents { get; set; } = null!;
        public virtual DbSet<Cruise> Cruises { get; set; } = null!;
        public virtual DbSet<CruiseContent> CruiseContents { get; set; } = null!;
        public virtual DbSet<CompanyUser> CompanyUsers { get; set; } = null!;
        public virtual DbSet<CompanyUserCruise> CompanyUserCruises { get; set; } = null!;

        public virtual DbSet<ItineraryType> ItineraryTypes { get; set; } = null!;
        public virtual DbSet<ItineraryTypeContent> ItineraryTypeContents { get; set; } = null!;

        public virtual DbSet<CabinType> CabinTypes { get; set; } = null!;
        public virtual DbSet<CabinTypeContent> CabinTypeContents { get; set; } = null!;

        public virtual DbSet<CabinPhoto> CabinPhotos { get; set; } = null!;
        public virtual DbSet<CruisePhoto> CruisePhotos { get; set; } = null!;
        public virtual DbSet<City> Cities { get; set; } = null!;
        public virtual DbSet<CityContent> CityContents { get; set; } = null!;

        public virtual DbSet<Itinerary> Itineraries { get; set; } = null!;
        public virtual DbSet<ItineraryContent> ItineraryContents { get; set; } = null!;


        public virtual DbSet<WeekDay> WeekDay { get; set; } = null!;
        public virtual DbSet<WeekDayContent> WeekDayContents { get; set; } = null!;

        public virtual DbSet<CruiseCategory> CruiseCategories { get; set; } = null!;
        public virtual DbSet<CruiseCategoryContent> CruiseCategoryContents { get; set; } = null!;
        public virtual DbSet<Brand> Brands { get; set; } = null!;
        public virtual DbSet<BrandContent> BrandContents { get; set; } = null!;

       


        public virtual DbSet<Amenity> Amenities { get; set; } = null!;
        public virtual DbSet<AmenityContent> AmenityContents { get; set; } = null!;

        public virtual DbSet<CabinAmenity> CabinAmenityies { get; set; } = null!;


        public virtual DbSet<Deck> Decks { get; set; } = null!;
        public virtual DbSet<DeckContent> DeckContents { get; set; } = null!;

        public virtual DbSet<Destination> Destination { get; set; } = null!;
        public virtual DbSet<DestinationContent> DestinationContents { get; set; } = null!;

        public virtual DbSet<Country> Countries { get; set; } = null!;
        public virtual DbSet<CountryContent> CountryContents { get; set; } = null!;


        public virtual DbSet<Dining> Dinings { get; set; } = null!;
        public virtual DbSet<DiningPhoto> DiningPhotos { get; set; } = null!;
        public virtual DbSet<CabinTypeCruisePhoto> CabinTypeCruisePhotos { get; set; } = null!;


        public virtual DbSet<DiningType> DiningTypes { get; set; } = null!;
        public virtual DbSet<DiningTypeContent> DiningTypeContents { get; set; } = null!;

        public virtual DbSet<OperationDate> OperationDates { get; set; } = null!;
        public virtual DbSet<Duration> Durations { get; set; } = null!;


     
        public virtual DbSet<Facility> Facilities { get; set; } = null!;
        public virtual DbSet<FacilityContent> FacilityContents { get; set; } = null!;
        public virtual DbSet<CruiseFacility> CruiseFacilities { get; set; } = null!;

        public virtual DbSet<CabinStatus> CabinStatuses { get; set; } = null!;
        public virtual DbSet<CabinStatusContent> CabinStatusContents { get; set; } = null!;

        public virtual DbSet<CabinTypeCruiseOperationDate> CabinTypeCruiseOperationDates { get; set; } = null!;

        public virtual DbSet<Season> Seasons { get; set; } = null!;
        public virtual DbSet<SeasonContent> SeasonContents { get; set; } = null!;

        

        public virtual DbSet<Period> Periods { get; set; } = null!;
        public virtual DbSet<PeriodContent> PeriodContents { get; set; } = null!;

        

        public virtual DbSet<Rate> Rates { get; set; } = null!;
        public virtual DbSet<RateContent> RateContents { get; set; } = null!;
        public virtual DbSet<CabinTypeCruisePeriodRate> CabinTypeCruisePeriodRates { get; set; } = null!;


        public virtual DbSet<ItineraryDay> ItineraryDays { get; set; } = null!;
        public virtual DbSet<ItineraryDayContent> ItineraryDayContents { get; set; } = null!;
        public virtual DbSet<ItineraryPhoto> ItineraryPhotos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile("appsettings.json")
                            .Build();

                string connectionString = configuration.GetConnectionString("AppDbConnection");
                optionsBuilder.UseLazyLoadingProxies().UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<AspstateTempApplication>(entity =>
            {
                entity.HasKey(e => e.AppId)
                    .HasName("PK__ASPState__8E2CF7F99C8E2398");

                entity.ToTable("ASPStateTempApplications");

                entity.HasIndex(e => e.AppName, "Index_AppName");

                entity.Property(e => e.AppId).ValueGeneratedNever();

                entity.Property(e => e.AppName)
                    .HasMaxLength(280)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<AspstateTempSession>(entity =>
            {
                entity.HasKey(e => e.SessionId)
                    .HasName("PK__ASPState__C9F492909AA164B4");

                entity.ToTable("ASPStateTempSessions");

                entity.HasIndex(e => e.Expires, "Index_Expires");

                entity.Property(e => e.SessionId).HasMaxLength(88);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Expires).HasColumnType("datetime");

                entity.Property(e => e.LockDate).HasColumnType("datetime");

                entity.Property(e => e.LockDateLocal).HasColumnType("datetime");

                entity.Property(e => e.SessionItemLong).HasColumnType("image");

                entity.Property(e => e.SessionItemShort).HasMaxLength(7000);
            });




            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
