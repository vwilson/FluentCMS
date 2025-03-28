namespace FluentCMS.Web.UI.Components;

public partial class Typography
{
    [Parameter]
    [CSSProperty]
    public TextAlign Align { get; set; } = TextAlign.Default;

    [Parameter]
    [CSSProperty]
    public Color Color { get; set; } = Color.Default;

    [Parameter]
    [CSSProperty]
    public TextSize Size { get; set; } = TextSize.Default;

    [Parameter]
    [CSSProperty]
    public TextWeight Weight { get; set; } = TextWeight.Default;

    [Parameter]
    public RenderFragment ChildContent { get; set; } = default!;
}
