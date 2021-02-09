using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using RecipeWebApp.Models;
using RecipeWebApp.Services;
using System.Collections.Generic;

namespace RecipeWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileRecipeService RecipeService;
        public IEnumerable<Recipe> Recipes { get; private set; }

        public IndexModel(ILogger<IndexModel> logger,
            JsonFileRecipeService recipeService)
        {
            _logger = logger;
            RecipeService = recipeService;
        }

        public void OnGet()
        {
            Recipes = RecipeService.GetRecipes();
        }
    }
}
