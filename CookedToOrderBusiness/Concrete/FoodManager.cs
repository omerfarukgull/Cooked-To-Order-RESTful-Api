using AutoMapper;
using Entities.DataTransferObjects;
using Entities.Exceptions;
using Entities.Models;
using Entities.RequestParameters;
using Repositories.Abstract;
using Services.Abstract;


namespace Services.Concrete
{
    public class FoodManager : IFoodService
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;
        private readonly ILoggerService _logger;
        public FoodManager(IRepositoryManager manager, IMapper mapper, ILoggerService logger)
        {
            _manager = manager;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<FoodDto> CreateOneBookAsync(FoodDtoForInsertion foodDto)
        {
            var entity = _mapper.Map<Food>(foodDto);
            _manager.Food.Create(entity);
            await _manager.SaveAsync();
            return _mapper.Map<FoodDto>(entity);
        }

        public async Task DeleteOneBookAsync(int id)
        {
            var entity = await GetOneBookByIdAndCheckExists(id);
            _manager.Food.Delete(entity);
            await _manager.SaveAsync();
        }

        public async Task<(IEnumerable<FoodDto> foodDto, MetaData MetaData)> GetAllFoodsAsync(FoodParameters foodParameters)
        {
            if (!foodParameters.ValidPriceRange)
                throw new PriceOutOfRangeBadRequestException();

            var foodsWithMetaData = await _manager.Food.GetAllFoodsAsync(foodParameters);
            var foodsDto = _mapper.Map<IEnumerable<FoodDto>>(foodsWithMetaData);

            return (foodsDto, foodsWithMetaData.MetaData);
        }

        public async Task<FoodDto> GetOneFoodByIdAsync(int id)
        {
            var food = await GetOneBookByIdAndCheckExists(id);

            return _mapper.Map<FoodDto>(food);
        }

        public async Task UpdateOneBookAsync(int id, FoodDtoForUpdate foodDto)
        {
            var entity = await GetOneBookByIdAndCheckExists(id);

            entity = _mapper.Map<Food>(foodDto);
            _manager.Food.Update(entity);
            await _manager.SaveAsync();

        }
        private async Task<Food> GetOneBookByIdAndCheckExists(int id)
        {
            var entity = _manager.Food.Get(f => f.FoodId == id);
            if (entity is null)
                throw new FoodNotFoundException(id);

            return entity;
        }
    }
}
