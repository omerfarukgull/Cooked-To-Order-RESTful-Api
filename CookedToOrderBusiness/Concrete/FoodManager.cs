using AutoMapper;
using Entities.DataTransferObjects;
using Entities.Exceptions;
using Entities.Models;
using Entities.RequestParameters;
using Repositories.Abstract;
using Services.Abstract;
using System.Dynamic;

namespace Services.Concrete
{
    public class FoodManager : IFoodService
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;
        private readonly ILoggerService _logger;
        private readonly IDataShaper<FoodDto> _shaper;
        public FoodManager(IRepositoryManager manager, IMapper mapper, ILoggerService logger, IDataShaper<FoodDto> shaper)
        {
            _manager = manager;
            _mapper = mapper;
            _logger = logger;
            _shaper = shaper;
        }

        public async Task<FoodDto> CreateOneFoodAsync(FoodDtoForInsertion foodDto)
        {
            var entity = _mapper.Map<Food>(foodDto);
            _manager.Food.Create(entity);
            await _manager.SaveAsync();
            return _mapper.Map<FoodDto>(entity);
        }

        public async Task DeleteOneFoodAsync(int id)
        {
            var entity = await GetOneFoodByIdAndCheckExists(id);
            _manager.Food.Delete(entity);
            await _manager.SaveAsync();
        }

        public async Task<(IEnumerable<ExpandoObject> foods, MetaData metaData)> GetAllFoodsAsync(FoodParameters foodParameters)
        {
            if (!foodParameters.ValidPriceRange)
                throw new PriceOutOfRangeBadRequestException();

            var foodsWithMetaData = await _manager.Food.GetAllFoodsAsync(foodParameters);
            var foodsDto = _mapper.Map<IEnumerable<FoodDto>>(foodsWithMetaData);
            var shapedData = _shaper.ShapeDate(foodsDto, foodParameters.Fields);

            return (foods : shapedData, metaData : foodsWithMetaData.MetaData);
        }

        public async Task<FoodDto> GetOneFoodByIdAsync(int id)
        {
            var food = await GetOneFoodByIdAndCheckExists(id);

            return _mapper.Map<FoodDto>(food);
        }

        public async Task UpdateOneFoodAsync(int id, FoodDtoForUpdate foodDto)
        {
            var entity = await GetOneFoodByIdAndCheckExists(id);

            entity = _mapper.Map<Food>(foodDto);
            _manager.Food.Update(entity);
            await _manager.SaveAsync();

        }
        private async Task<Food> GetOneFoodByIdAndCheckExists(int id)
        {
            var entity = _manager.Food.Get(f => f.FoodId == id);
            if (entity is null)
                throw new FoodNotFoundException(id);

            return entity;
        }
    }
}
