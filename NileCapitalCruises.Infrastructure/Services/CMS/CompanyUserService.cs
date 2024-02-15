using AutoMapper;
using NileCapitalCruises.Core.ApiModels;
using NileCapitalCruises.Core.Authentication;
using NileCapitalCruises.Core.IRepositories;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS;
using NileCapitalCruises.Infrastructure.Dtos.CMS.RequestDtos.CompanyUserDtos;
using NileCapitalCruises.Infrastructure.Helpers.ApiResponses;
using NileCapitalCruises.Infrastructure.Helpers.Utils;
using NileCapitalCruises.Infrastructure.IServices;
using NileCapitalCruises.Infrastructure.IServices.CMS;
using Microsoft.AspNetCore.Identity;
using System.Transactions;
using Microsoft.Extensions.Configuration;
using NileCapitalCruises.Infrastructure.Data.Specification.CMS.CompanyUserSpecification;


namespace NileCapitalCruises.Infrastructure.Services.CMS
{
    public class CompanyUserService : ICompanyUserService
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole<int>> roleManager;
        private readonly ITokenService _tokenService;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;

        private readonly IGenericRepo<CompanyUser> _companyUserRepo;


        public CompanyUserService(
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole<int>> roleManager,
            IConfiguration configuration,
            ITokenService tokenService,
            IGenericRepo<CompanyUser> companyUserRepo,
             IMapper mapper
            )
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            _tokenService = tokenService;
            _configuration = configuration;
            _companyUserRepo = companyUserRepo;
            _mapper = mapper;
           
        }

        //public async Task<IResponse> CreateCompanyUserAdmin(CompanyUserRequestDto requestDto)
        //{
        //    using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
        //    {
        //        try
        //        {
        //            // For Creating Idenity User related to the current CompanyUser
        //            var userExists = await userManager.FindByNameAsync(requestDto.Username);
        //            if (userExists != null)
        //                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemAlreadyExist }, StatusCodeAndErrorsMessagesStandard.BadRequest);

        //            ApplicationUser user = new ApplicationUser()
        //            {
        //                Email = requestDto.Email,
        //                SecurityStamp = Guid.NewGuid().ToString(),
        //                UserName = requestDto.Username
        //            };
        //            var result = await userManager.CreateAsync(user, requestDto.Password);
        //            if (!result.Succeeded)
        //                return FailResponse.Error(result.Errors.Select(error => error.Description).ToList(), StatusCodeAndErrorsMessagesStandard.BadRequest);

        //            // Get the created user with the Id
        //            var createdUser = await userManager.FindByNameAsync(user.UserName);


        //            // Check and create roles if they don't exist
        //            if (!await roleManager.RoleExistsAsync(UserRoles.CompanyAdmin))
        //                await roleManager.CreateAsync(new IdentityRole<int>(UserRoles.CompanyAdmin));

        //            if (!await roleManager.RoleExistsAsync(UserRoles.CompanyUser))
        //                await roleManager.CreateAsync(new IdentityRole<int>(UserRoles.CompanyUser));

        //            // Assign CompanyAdmin role to the user
        //            if (await roleManager.RoleExistsAsync(UserRoles.CompanyAdmin))
        //            {
        //                await userManager.AddToRoleAsync(user, UserRoles.CompanyAdmin);
        //            }

        //            //For Creating CompanyUser related to the current Idenity User

        //            var request = _mapper.Map<CompanyUser>(requestDto);

        //            // Assign the Id from the Identity User to the UserId property in CompanyUser
        //            request.UserId = createdUser.Id;


        //            var newItem = await _companyUserRepo.CreateEntityAsync(request);
        //            if (newItem == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotCreated }, StatusCodeAndErrorsMessagesStandard.BadRequest);

        //            newItem.CompanyUserUrl = HandleUrlsName.CreateUrlByName(newItem.CompanyUserName);

        //            await _companyUserRepo.SaveChangesAsync();


        //            scope.Complete();
        //            return BaseSuccessResponse.Success(StatusCodeAndErrorsMessagesStandard.Created);
        //        }
        //        catch (Exception ex)
        //        {
        //            //return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotCreated }, StatusCodeAndErrorsMessagesStandard.InternalServerError);

        //            var errorMessages = new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotCreated };
        //            errorMessages.Add(ex.Message);
        //            return FailResponse.Error(errorMessages, StatusCodeAndErrorsMessagesStandard.InternalServerError);

        //        }
        //    }

            
        //}

        public async Task<IResponse> CreateCompanyUser(CompanyUserRequestDto requestDto)
        {
            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    // For Creating Idenity User related to the current CompanyUser
                    var userExists = await userManager.FindByNameAsync(requestDto.Username);
                    if (userExists != null)
                        return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemAlreadyExist }, StatusCodeAndErrorsMessagesStandard.BadRequest);

                    ApplicationUser user = new ApplicationUser()
                    {
                        Email = requestDto.Email,
                        SecurityStamp = Guid.NewGuid().ToString(),
                        UserName = requestDto.Username
                    };
                    var result = await userManager.CreateAsync(user, requestDto.Password);
                    if (!result.Succeeded)
                        return FailResponse.Error(result.Errors.Select(error => error.Description).ToList(), StatusCodeAndErrorsMessagesStandard.BadRequest);

                    // Get the created user with the Id
                    var createdUser = await userManager.FindByNameAsync(user.UserName);


                    // Check and create roles if they don't exist
                    if (!await roleManager.RoleExistsAsync(UserRoles.CompanyAdmin))
                        await roleManager.CreateAsync(new IdentityRole<int>(UserRoles.CompanyAdmin));

                    if (!await roleManager.RoleExistsAsync(UserRoles.CompanyUser))
                        await roleManager.CreateAsync(new IdentityRole<int>(UserRoles.CompanyUser));

                    //For Creating CompanyUser related to the current Idenity User

                    var request = _mapper.Map<CompanyUser>(requestDto);

                    // Assign the Id from the Identity User to the UserId property in CompanyUser
                    request.UserId = createdUser.Id;


                    var newItem = await _companyUserRepo.CreateEntityAsync(request);
                    if (newItem == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotCreated }, StatusCodeAndErrorsMessagesStandard.BadRequest);

                    newItem.CompanyUserUrl = HandleUrlsName.CreateUrlByName(newItem.CompanyUserName);

                    await _companyUserRepo.SaveChangesAsync();


                    scope.Complete();
                    return BaseSuccessResponse.Success(StatusCodeAndErrorsMessagesStandard.Created);
                }
                catch (Exception ex)
                {
                    //return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotCreated }, StatusCodeAndErrorsMessagesStandard.InternalServerError);

                    var errorMessages = new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotCreated };
                    errorMessages.Add(ex.Message);
                    return FailResponse.Error(errorMessages, StatusCodeAndErrorsMessagesStandard.InternalServerError);

                }
            }


        }

        
        public async Task<IResponse> AssignRole(RoleRequestDto assignRoleDto)
        {
            var spec = new CompanyUserSpecification(assignRoleDto.CompanyId, assignRoleDto.CompanyUserId);
            var item = await _companyUserRepo.GetEntityWithSpecAsync(spec);
            if (item == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);

            var user = await this.userManager.FindByIdAsync(item.UserId.ToString());
            if (user == null)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemAlreadyExist }, StatusCodeAndErrorsMessagesStandard.BadRequest);

            }

            if (!await this.roleManager.RoleExistsAsync(assignRoleDto.RoleName))
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoRole }, StatusCodeAndErrorsMessagesStandard.BadRequest);


            var result = await this.userManager.AddToRoleAsync(user, assignRoleDto.RoleName);

            if (result.Succeeded)
            {
                return BaseSuccessResponse.Success(StatusCodeAndErrorsMessagesStandard.NoContent);
            }
            return FailResponse.Error(result.Errors.Select(error => error.Description).ToList(), StatusCodeAndErrorsMessagesStandard.BadRequest);

        }

        public async Task<IResponse> RemoveRole(RoleRequestDto removeRoleDto)
        {
            var spec = new CompanyUserSpecification(removeRoleDto.CompanyId, removeRoleDto.CompanyUserId);
            var item = await _companyUserRepo.GetEntityWithSpecAsync(spec);
            if (item == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);

            var user = await this.userManager.FindByIdAsync(item.UserId.ToString());
            if (user == null)
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemAlreadyExist }, StatusCodeAndErrorsMessagesStandard.BadRequest);

            }

            if (!await this.roleManager.RoleExistsAsync(removeRoleDto.RoleName))
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoRole }, StatusCodeAndErrorsMessagesStandard.BadRequest);


            if (!await this.userManager.IsInRoleAsync(user, removeRoleDto.RoleName))
            {
                return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoHaveRole }, StatusCodeAndErrorsMessagesStandard.BadRequest);

            }

            var result = await this.userManager.RemoveFromRoleAsync(user, removeRoleDto.RoleName);

            if (result.Succeeded)
            {
                return BaseSuccessResponse.Success(StatusCodeAndErrorsMessagesStandard.NoContent);
            }
            return FailResponse.Error(result.Errors.Select(error => error.Description).ToList(), StatusCodeAndErrorsMessagesStandard.BadRequest);

        }

        public async Task<IResponse> GetCompanyUsers(PaginationSpecParams paginationSpecParams, int companyId)
        {
            var spec = new CompanyUserSpecification(paginationSpecParams, companyId);
            var countSpec = new CompanyUserWithFiltersForCountSpecification(paginationSpecParams, companyId);
            var totalItems = await _companyUserRepo.CountAsync(countSpec);
            var items = await _companyUserRepo.ListAsync(spec);
            if (items.Count() <= 0) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);

           

            var data = _mapper.Map<IReadOnlyList<CompanyUserResponseDto>>(items);

            await Task.WhenAll(data.Select(async item =>
            {
                var user = await this.userManager.FindByIdAsync(item.UserId.ToString());
                if (user != null)
                {
                    item.Roles = await this.userManager.GetRolesAsync(user);
                }
            }));



            return SuccessPaginationResponse<CompanyUserResponseDto>.Success(
                    data != null,
                    StatusCodeAndErrorsMessagesStandard.OK,
                    data,
                    paginationSpecParams.PageIndex,
                    paginationSpecParams.PageSize,
                    totalItems
                );
        }

        public async Task<IResponse> GetCompanyUser(int companyId, int companyUserId)
        {
            var spec = new CompanyUserSpecification(companyId, companyUserId);
            var item = await _companyUserRepo.GetEntityWithSpecAsync(spec);
            if (item == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);
            var itemDto = _mapper.Map<CompanyUserResponseDto>(item);

            var user = await this.userManager.FindByIdAsync(itemDto.UserId.ToString());
            itemDto.Roles = await this.userManager.GetRolesAsync(user);
           
            return SuccessSingleResponse<CompanyUserResponseDto>.Success(itemDto, StatusCodeAndErrorsMessagesStandard.OK);
        }

        public async Task<IResponse> UpdateCompanyUser(int companyId, int companyUserId , CompanyUserUpdateRequestDto requestDto)
        {

            try
            {
                var spec = new CompanyUserSpecification(companyId, companyUserId);
                var existingItem = await _companyUserRepo.GetEntityWithSpecAsync(spec);
                if (existingItem == null) return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.NoItem }, StatusCodeAndErrorsMessagesStandard.NotFound);

                var user = await this.userManager.FindByIdAsync(existingItem.UserId.ToString());
                user.Email = requestDto.Email;

                _mapper.Map(requestDto, existingItem);

                _companyUserRepo.UpdateEntity(existingItem);
                await _companyUserRepo.SaveChangesAsync();

                var updatedDto = _mapper.Map<CompanyUserResponseDto>(existingItem);

                return SuccessSingleResponse<CompanyUserResponseDto>.Success(updatedDto, StatusCodeAndErrorsMessagesStandard.OK);
            }
            catch (Exception ex)
            {
                var errorMessages = new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotUpdated };
                errorMessages.Add(ex.Message);
                return FailResponse.Error(errorMessages, StatusCodeAndErrorsMessagesStandard.BadRequest);

                //return FailResponse.Error(new List<string> { StatusCodeAndErrorsMessagesStandard.ItemNotUpdated }, StatusCodeAndErrorsMessagesStandard.BadRequest);
            }
        }


        public async Task<bool> IsAvailableAsync(int companyUserId, int companyId)
        {
            var spec = new CompanyUserSpecification(companyUserId, companyId);
            return await _companyUserRepo.AnyAsync(spec);
        }


    }
}
