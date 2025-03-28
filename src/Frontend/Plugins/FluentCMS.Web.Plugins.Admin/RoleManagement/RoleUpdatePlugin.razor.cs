namespace FluentCMS.Web.Plugins.Admin.RoleManagement;

public partial class RoleUpdatePlugin
{
    public const string FORM_NAME = "RoleUpdateForm";

    [SupplyParameterFromQuery(Name = "id")]
    private Guid Id { get; set; }

    private RoleUpdateRequest? Model { get; set; }

    private List<Policy>? Policies { get; set; }

    private RoleDetailResponse? Role { get; set; }

    protected override async Task OnInitializedAsync()
    {
        if (Policies is null)
        {
            var policiesResponse = await ApiClient.Role.GetPoliciesAsync();
            Policies = policiesResponse?.Data?.ToList() ?? [];
        }

        if (Role is null)
        {
            var roleResponse = await ApiClient.Role.GetByIdAsync(Id);
            Role = roleResponse.Data;
            Model = Mapper.Map<RoleUpdateRequest>(Role);

            Model.Policies = Policies.Select(x => new Policy
            {
                Area = x.Area,
                Actions = Role?.Policies?.FirstOrDefault(y => y.Area == x.Area)?.Actions ?? []
            }).ToArray();
        }
    }

    private async Task OnSubmit()
    {
        await ApiClient.Role.UpdateAsync(Model);
        NavigateBack();
    }
}
