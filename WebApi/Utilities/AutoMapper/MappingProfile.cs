using AutoMapper;
using Entities.DataTransferObjects;
using Entities.Models;

namespace Entities.Utilities.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<FoodDtoForUpdate, Food>();
            CreateMap<Food, FoodDto>();
            CreateMap<FoodDtoForManipulation, Food>();
            CreateMap<UserForRegistrationDto, User>();
        }
    }
}
