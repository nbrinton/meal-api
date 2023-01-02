using MEalAPI.Entities;

namespace MEalAPI.Interfaces
{
    public interface IRecipe
    {
        public int? PrepTime { get; set; }

        public int? CookTime { get; set; }

        public Meal Meal { get; set; }

        public List<RecipeIngredient>? RecipeIngredients { get; set; }

        public List<RecipeStep>? RecipeSteps { get; set; }
    }
}
