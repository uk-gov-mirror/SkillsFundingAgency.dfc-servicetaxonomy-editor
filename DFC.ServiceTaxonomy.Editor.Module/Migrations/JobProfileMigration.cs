using System.Threading.Tasks;
using OrchardCore.Data.Migration;
using OrchardCore.Recipes.Services;

namespace DFC.ServiceTaxonomy.Editor.Module.Migrations
{
   public class JobProfileMigration : DataMigration
    {
        private readonly IRecipeMigrator _recipeMigrator;

        public JobProfileMigration(IRecipeMigrator recipeMigrator)
        {
            _recipeMigrator = recipeMigrator;
        }

        public async Task<int> CreateAsync()
        {
            await _recipeMigrator.ExecuteAsync("JobProfileMigration.recipe.json", this);

            return 1;
        }

    }
}
