﻿namespace FluentCMS.Web.Api.Models;

public class LayoutCreateRequest
{
    public string Name { get; set; } = default!;
    public string Body { get; set; } = default!;
    public string Head { get; set; } = default!;
}
