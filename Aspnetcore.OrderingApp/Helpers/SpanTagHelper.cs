using System;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Aspnetcore.OrderingApp.Helpers
{
    // <span last-updated></span>
    [HtmlTargetElement("span", Attributes = "last-updated")]
    public class DateTagHelper : TagHelper
    {
        public DateTime LastUpdated { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if(LastUpdated < DateTime.Now.AddDays(-3))
            {
                output.Attributes.SetAttribute("class", "text-danger bold pull-right");
            }
        }
    }
}
