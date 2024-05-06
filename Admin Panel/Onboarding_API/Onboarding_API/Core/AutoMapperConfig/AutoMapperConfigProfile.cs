using AutoMapper;
using Onboarding_API.Core.Dtos.FormDTO;
using Onboarding_API.Core.Entities.FormEntities;

namespace Onboarding_API.Core.AutoMapperConfig
{
    public class AutoMapperConfigProfile : Profile
    {
        public AutoMapperConfigProfile()
        {
            //FORMS

            CreateMap<CreateOnBoardFormsDto, OnBoardForm>();
            CreateMap<OnBoardForm, GetOnBoardFormsDto>();
            CreateMap<UpdateOnBoardFormsDto, GetOnBoardFormsDto>();

        }
    }
}
