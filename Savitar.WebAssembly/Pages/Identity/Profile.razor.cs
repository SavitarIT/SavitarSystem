using System;
using System.Net.Http.Json;
using System.Threading.Tasks;
using MudBlazor;
using Savitar.Domain.Models.Requests;

namespace Savitar.Web.Client.Pages.Identity
{
    public partial class Profile
    {
        private UpdateProfileRequest _model;

        private async Task UpdateProfileAsync()
        {
            var response = await _accountsApi.UpdateProfileAsync(_model);
            if (response.Succeeded)
            {
                //await _authStateProvider.Logout();
                _snackbar.Add("Your profile has been updated.", Severity.Success);
                //_navigationManager.NavigateTo("/");
            }
            else
            {
                foreach (var message in response.Messages)
                {
                    _snackbar.Add(message, Severity.Error);
                }
            }
        }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                _model = await _httpClient.GetFromJsonAsync<UpdateProfileRequest>($"api/sysadmin/users/0");
            }
            catch (Exception ex)
            {
                _snackbar.Add(ex.Message, Severity.Error);
            }
        }
    }
}