using GetJobProfiles.Models.Recipe.Fields;

namespace GetJobProfiles.Models.Recipe.Parts
{
    public class HowToBecomePart
    {
        public TabField HowToBecome { get; set; }
        public HtmlField HtbBodies { get; set; }
        //todo: populate this field from the job profiles spreadsheet, dynamictitleprefix column. will need to map to predefined values in oc
        public TextField HtbTitleOptions { get; set; }
        // public HtmlField HtbOtherRequirements { get; set; }
        public HtmlField HtbCareerTips { get; set; }
        public HtmlField HtbFurtherInformation { get; set; }
        public ContentPicker HtbRegistrations { get; set; }
    }
}
