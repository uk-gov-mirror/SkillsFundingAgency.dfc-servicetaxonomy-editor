using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OrchardCore.ContentManagement.Metadata.Models;
using OrchardCore.Flows.Models;

namespace DFC.ServiceTaxonomy.GraphSync.GraphSyncers
{
    public class BagPartGraphSyncer : IContentPartGraphSyncer
    {
        public string? PartName => nameof(BagPart);

        public Task AddSyncComponents(
            dynamic graphLookupContent,
            IDictionary<string, object> nodeProperties,
            IDictionary<(string destNodeLabel, string destIdPropertyName, string relationshipType), IEnumerable<string>> nodeRelationships,
            ContentTypePartDefinition contentTypePartDefinition)
        {
            throw new NotImplementedException();
        }
    }
}
