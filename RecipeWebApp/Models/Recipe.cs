using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RecipeWebApp.Models
{
    public class Recipe
    {
        public string Id { get; set; }
        public string Maker { get; set; }

        [JsonPropertyName("img")]
        public string Image { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public string Ingredients { get; set; }
        public string Procedure { get; set; }
        public int[] Ratings { get; set; }
        public override string ToString() => JsonSerializer.Serialize<Recipe>(this);

    }
}
