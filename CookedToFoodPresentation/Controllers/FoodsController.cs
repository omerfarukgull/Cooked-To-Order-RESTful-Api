using CookedToFoodPresentation.ActionFilter;
using CookedToOrderBusiness.Abstract;
using CookedToOrderEntity.DataTransferObjects;
using Entities.RequestParameters;
using Microsoft.AspNetCore.Mvc;
using Presentation.ActionFilter;

namespace CookedToFoodPresentation.Controllers
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
        [HttpGet]
        public async Task<IActionResult> GetAllFoods([FromQuery]FoodParameters bookParameters)
        {
            var foods = await _manager.FoodService.GetAllFoodsAsync(bookParameters);
            return Ok(foods);
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetOneFoodById([FromRoute(Name = "id")] int id)
        {
            var food = await _manager.FoodService.GetOneFoodByIdAsync(id);
            return Ok(food);
        }
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [HttpPost]
        public async Task<IActionResult> CreateOneFoodAsync([FromBody] FoodDtoForInsertion foodDto)
        {
            //    if (bookDto is null)
            //        return BadRequest();
            //    if (!ModelState.IsValid)
            //        return UnprocessableEntity(ModelState); Bu kod satırını oluşturdumuz  ValidationFilterAttribute ile action çalışırken kontrol ediyoruz

            var food = await _manager.FoodService.CreateOneBookAsync(foodDto);
            return StatusCode(201, food);
        }
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateOneFoodAsync([FromRoute(Name = "id")] int id, [FromBody] FoodDtoForUpdate foodDto)
        {
            await _manager.FoodService.UpdateOneBookAsync(id, foodDto);
            return NoContent(); //204
        }
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeletOneFoodAsync([FromRoute(Name = "id")]int id)
        {
            await _manager.FoodService.DeleteOneBookAsync(id);
            return NoContent(); 
        }
    }
}
