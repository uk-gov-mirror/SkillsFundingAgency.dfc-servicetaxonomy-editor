// using System;
// using System.Threading.Tasks;
// using OrchardCore.Recipes.Models;
// using OrchardCore.Recipes.Services;
//
// namespace DFC.ServiceTaxonomy.GraphSync.Recipes.Executors
// {
//     //todo: rename
//     public class LoTRContentStep : IRecipeStepHandler
//     {
//         //"Recipes" is an existing step that allows loading multiple recipes, but they're imported onr by one
//         public const string StepName = "ConcurrentRecipes";
//
//         public LoTRContentStep()
//         {
//         }
//
//         public async Task ExecuteAsync(RecipeExecutionContext context)
//         {
//             if (!string.Equals(context.Name, StepName, StringComparison.OrdinalIgnoreCase))
//                 return;
//
//             RecipesStepModel? model = context.Step.ToObject<RecipesStepModel>();
//             if (model?.Recipes == null)
//                 return;
//
//         }
//
//         //todo: if get working, have groups of recipes that can be imported in parallel
//         public class RecipesStepModel
//         {
//             public string[]? Recipes { get; set; }
//         }
//     }
// }
