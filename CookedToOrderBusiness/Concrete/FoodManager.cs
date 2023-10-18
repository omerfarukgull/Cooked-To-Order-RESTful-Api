﻿using AutoMapper;
using CookedToOrderBusiness.Abstract;
using CookedToOrderData.Abstract;
using CookedToOrderEntity.DataTransferObjects;
using CookedToOrderEntity.Exceptions;
using CookedToOrderEntity.Models;
using Entities.RequestParameters;
using Services.Abstract;

namespace CookedToOrderBusiness.Concrete
{
    public class FoodManager : IFoodService
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;
        private readonly ILoggerService _logger;
        public FoodManager(IRepositoryManager manager, IMapper mapper,ILoggerService logger)
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
            var entity =await GetOneBookByIdAndCheckExists(id);
            _manager.Food.Delete(entity);
            await _manager.SaveAsync();
        }

        public async Task<IEnumerable<FoodDto>> GetAllFoodsAsync(FoodParameters foodParameters)
        {
            var foods = await _manager.Food.GetAllFoodsAsync(foodParameters);
            return _mapper.Map<IEnumerable<FoodDto>>(foods);
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
            var entity =  _manager.Food.Get(f => f.FoodId == id);
            if (entity is null)
                throw new FoodNotFoundException(id);

            return entity;
        }
    }
}
