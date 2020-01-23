using System;
using System.Collections.Generic;
using System.Threading.Tasks;
// using Microsoft.Extensions.DependencyInjection;
// using OrchardCore.ContentManagement;
using OrchardCore.ContentManagement.Metadata.Models;
using OrchardCore.Flows.Models;

namespace DFC.ServiceTaxonomy.GraphSync.GraphSyncers
{
    public class BagPartGraphSyncer : IContentPartGraphSyncer
    {
        public string? PartName => nameof(BagPart);
        private readonly IServiceProvider _serviceProvider;

        public BagPartGraphSyncer(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public Task AddSyncComponents(
            dynamic graphLookupContent,
            IDictionary<string, object> nodeProperties,
            IDictionary<(string destNodeLabel, string destIdPropertyName, string relationshipType), IEnumerable<string>> nodeRelationships,
            ContentTypePartDefinition contentTypePartDefinition)
        {
            // foreach (ContentItem contentItem in graphLookupContent.ContentItems)
            // {
            //     IGraphSyncer graphSyncer = _serviceProvider.GetService<IGraphSyncer>();
            //     graphSyncer.SyncToGraph(contentItem);
            //     //todo: need to create relationship to each node created (embedded content item had a graph sync)
            //     // get SyncToGraph to return
            // }
            // return Task.CompletedTask;
            throw new NotImplementedException();
        }
    }
}
