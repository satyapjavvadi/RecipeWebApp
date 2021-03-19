using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeWebApp.Models;
using RecipeWebApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeWebApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        public RecipesController(JsonFileRecipeService recipeService)
        {
            this.recipeService = recipeService;
        }

        public JsonFileRecipeService recipeService { get; }

        [HttpGet]
        public IEnumerable<Recipe> Get()
        {
            return recipeService.GetRecipes();
        }

        //[HttpPatch] "[FromBody]"
        [Route("Rate")]
        [HttpGet]
        public ActionResult Get(
            [FromQuery] string RecipeId, 
            [FromQuery] int Rating)
        {
            recipeService.AddRating(RecipeId, Rating);
            return Ok();
        }
    }
}
