using Entities.RequestParameters;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Presentation.ActionFilter;
using Services.Abstract;
using Entities.DataTransferObjects;

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
        [HttpGet]
        public async Task<IActionResult> GetAllFoodsAsync([FromQuery]FoodParameters bookParameters)
        {
            var pagedResult = await _manager.FoodService.GetAllFoodsAsync(bookParameters);

            Response.Headers.Add("X-Pagination",JsonSerializer.Serialize(pagedResult.metaData));
            return Ok(pagedResult.foods);
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
