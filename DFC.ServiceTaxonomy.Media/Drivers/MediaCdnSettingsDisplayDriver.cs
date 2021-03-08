using System;
using System.Collections.Generic;
using System.Text;
using OrchardCore.DisplayManagement.Entities;
using OrchardCore.Settings;

using System.Threading.Tasks;


using OrchardCore.DisplayManagement.Handlers;
using OrchardCore.DisplayManagement.Views;

namespace DFC.ServiceTaxonomy.Media.Drivers
{
    public class MediaCdnSettingsDisplayDriver : SectionDisplayDriver<ISite, MediaCdnSettings>
    {
        public const string GroupId = "admin";

        public override IDisplayResult Display(ISite model)
        {
            return base.Display(model);
        }

        public override async Task<IDisplayResult> EditAsync(MediaCdnSettings settings, BuildEditorContext context)
        {
            return await Task.FromResult(Initialize<MediaCdnViewModel>("AdminSettings_Edit", model =>
            {
                model.DisplayMediaCdnLocation = settings.DisplayMediaCdnLocation;
            }).Location("Content:4").OnGroup(GroupId));
        }
    }
}
