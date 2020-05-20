using System;
using System.Collections.Generic;
using System.Text;
using OrchardCore.Entities;
using GetJobProfiles;

namespace GetJobProfiles.Extensions
{
    public static class DefaultIdGeneratorExtensions
    {
        public static string Generate(this DefaultIdGenerator gen)
    {
            return ContentIdController.UseTestValues ? ContentIdController.GetNextCotentId() : gen.GenerateUniqueId();
    }
}
}
