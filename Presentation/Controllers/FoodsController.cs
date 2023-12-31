﻿using Entities.RequestParameters;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Presentation.ActionFilter;
using Services.Abstract;
using Entities.DataTransferObjects;
using Microsoft.AspNetCore.Authorization;

namespace Presentation.Controllers
{
    [ServiceFilter(typeof(LogFiterAttribute))]
    [ApiController]
    [Route("api/foods")]
    public class FoodsController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public FoodsController(IServiceManager manager)
        {
            _manager = manager;
        }

        [Authorize]
        [HttpGet(Name = "GetAllFoodsAsync")]
        public async Task<IActionResult> GetAllFoodsAsync([FromQuery]FoodParameters bookParameters)
        {
            var pagedResult = await _manager.FoodService.GetAllFoodsAsync(bookParameters);

            Response.Headers.Add("X-Pagination",JsonSerializer.Serialize(pagedResult.metaData));
            return Ok(pagedResult.foods);
        }


        [Authorize]
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetOneFoodById([FromRoute(Name = "id")] int id)
        {
            var food = await _manager.FoodService.GetOneFoodByIdAsync(id);
            return Ok(food);
        }


        [Authorize]
        [HttpGet("details")]
        public async Task<IActionResult> GetAllFoodWithDetailsAsync()
        {
            return Ok(await _manager.FoodService.GetAllFoodWithDetailsAsync());
        }

        [Authorize(Roles = "Admin")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [HttpPost]
        public async Task<IActionResult> CreateOneFoodAsync([FromBody] FoodDtoForInsertion foodDto)
        {
            //    if (bookDto is null)
            //        return BadRequest();
            //    if (!ModelState.IsValid)
            //        return UnprocessableEntity(ModelState); Bu kod satırını oluşturdumuz  ValidationFilterAttribute ile action çalışırken kontrol ediyoruz

            var food = await _manager.FoodService.CreateOneFoodAsync(foodDto);
            return StatusCode(201, food);
        }


        [Authorize(Roles = "Admin")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateOneFoodAsync([FromRoute(Name = "id")] int id, [FromBody] FoodDtoForUpdate foodDto)
        {
            await _manager.FoodService.UpdateOneFoodAsync(id, foodDto);
            return NoContent(); //204
        }


        [Authorize(Roles = "Admin")]
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeletOneFoodAsync([FromRoute(Name = "id")]int id)
        {
            await _manager.FoodService.DeleteOneFoodAsync(id);
            return NoContent(); 
        }
    }
}
