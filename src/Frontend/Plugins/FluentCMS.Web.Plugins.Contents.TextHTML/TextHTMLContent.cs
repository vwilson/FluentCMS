namespace FluentCMS.Web.Plugins.Contents.TextHTML;

public class TextHTMLContent : IContent
{
    public Guid Id { get; set; }
    public string Content { get; set; } = String.Empty;
    public bool IsRichText { get; set; } = false;
}