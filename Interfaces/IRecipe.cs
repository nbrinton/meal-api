using MEalAPI.Entities;

namespace MEalAPI.Interfaces
{
    public interface IRecipe
    {
        public int? PrepTime { get; set; }

        public int? CookTime { get; set; }

        public EMeal Meal { get; set; }

        public List<ERecipeIngredient>? RecipeIngredients { get; set; }

        public List<ERecipeStep>? RecipeSteps { get; set; }
    }
}
