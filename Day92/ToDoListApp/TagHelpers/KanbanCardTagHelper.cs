using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ToDoListApp;

public class KanbanCardTagHelper : TagHelper
{
    public ToDoTask Task { get; set; } = null;

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = "div";
        output.Attributes.SetAttribute("class", "card mb-2");

        output.PreContent.SetHtmlContent(
            "<div class=\"card-body p-2\">"
            + "<div class=\"card-title\">"
            + Task.Title
            + "</div>"
            );

        if (Task.Status == ETaskStatus.ToDo)
            output.PostContent.AppendHtml("<button class=\"btn btn-warning btn-sm\">Start</button>");
        else if (Task.Status == ETaskStatus.Doing)
            output.PostContent.AppendHtml("<button class=\"btn btn-success btn-sm\">Finish</button>");

        output.PostContent.AppendHtml("<button class=\"btn btn-primary btn-sm mx-2\">View</button>");
        output.PostContent.AppendHtml("</div>");
        output.TagMode = TagMode.StartTagAndEndTag;
        // output.PostContent.SetHtmlContent(
        //     "</div>"
        //     + "<button class=\"btn btn-primary btn-sm\">View</button>"
        //     + "</div>"
        // );

    }
}
