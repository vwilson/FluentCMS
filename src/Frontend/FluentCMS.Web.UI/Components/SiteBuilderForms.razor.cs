namespace FluentCMS.Web.UI;

public partial class SiteBuilderForms
{
    [Inject]
    private ApiClientFactory ApiClient { get; set; } = default!;

    [CascadingParameter]
    private ViewState ViewState { get; set; } = default!;

    [SupplyParameterFromForm(FormName = "DeletePluginForm")]
    private Guid DeletePluginModel { get; set; } = new();

    [SupplyParameterFromForm(FormName = "CreatePluginForm")]
    private PluginCreateRequest CreatePluginModel { get; set; } = new();

    [SupplyParameterFromForm(FormName = "UpdatePluginForm")]
    private PluginUpdateRequest UpdatePluginModel { get; set; } = new();

    [SupplyParameterFromForm(FormName = "UpdatePluginOrdersForm")]
    private PageUpdatePluginOrdersRequest UpdatePluginOrdersModel { get; set; } = new();

    private async Task OnUpdatePluginSubmit()
    {
        await ApiClient.Plugin.UpdateAsync(UpdatePluginModel);
    }

    private async Task OnUpdatePluginOrdersSubmit()
    {
        await ApiClient.Page.UpdatePluginOrdersAsync(UpdatePluginOrdersModel);
    }

    private async Task OnCreatePluginSubmit()
    {
        CreatePluginModel.PageId = ViewState.Page.Id;
        CreatePluginModel.Settings = new Dictionary<string, string> ();
        
        await ApiClient.Plugin.CreateAsync(CreatePluginModel);
    }

    private async Task OnDeletePluginSubmit()
    {
        await ApiClient.Plugin.DeleteAsync(DeletePluginModel);
    }
}
