using AutoMapper;
using CookedToOrderEntity.DataTransferObjects;
using CookedToOrderEntity.Models;

namespace CookedToOrderWebApi.Utilities.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<FoodDtoForUpdate, Food>();
            CreateMap<Food, FoodDto>();
            CreateMap<FoodDtoForManipulation, Food>();
        }
    }
}
