﻿namespace FluentCMS.Web.UI.Components;

public partial class Badge
{
    [Parameter]
    [CSSProperty]
    public Color Color { get; set; } = Color.Default;

    [Parameter]
    public RenderFragment ChildContent { get; set; } = default!;
}
