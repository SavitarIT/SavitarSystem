using System;
using System.Net.Http.Json;
using System.Threading.Tasks;
using MudBlazor;
using Savitar.Domain.Requests;

namespace Savitar.WebAssembly.Pages.Identity
{
    public partial class Profile
    {
        private UpdateProfileRequest _model;

        private async Task UpdateProfileAsync()
        {
            var response = await _accountsApi.UpdateProfileAsync(_model);
            if (response.Succeeded)
            {
                //await _authenticationManager.Logout();
                //_snackBar.Add(_localizer["Your Profile has been updated. Please Login to Continue."], Severity.Success);
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
                _model = await _httpClient.GetFromJsonAsync<UpdateProfileRequest>($"api/sysadmin/users/{Guid.Empty}");
            }
            catch (Exception ex)
            {
                _snackbar.Add(ex.Message, Severity.Error);
            }
        }

        private async Task DeleteAsync()
        {
            //var parameters = new DialogParameters
            //{
            //    {nameof(Shared.Dialogs.DeleteConfirmation.ContentText), $"{string.Format(_localizer["Do you want to delete the profile picture of {0}"], _model.Email)}?"}
            //};
            //var options = new DialogOptions { CloseButton = true, MaxWidth = MaxWidth.Small, FullWidth = true, DisableBackdropClick = true };
            //var dialog = _dialogService.Show<Shared.Dialogs.DeleteConfirmation>(_localizer["Delete"], parameters, options);
            //var result = await dialog.Result;
            //if (!result.Cancelled)
            //{
            //    var request = new UpdateProfilePictureRequest { Data = null, FileName = string.Empty, UploadType = MediaTypeNames.Application.Enums.UploadType.ProfilePicture };
            //    var data = await _accountsApi.UpdateProfilePictureAsync(request, UserId);
            //    if (data.Succeeded)
            //    {
            //        await _localStorage.RemoveItemAsync(StorageConstants.Local.UserImageURL);
            //        ImageDataUrl = string.Empty;
            //        _snackBar.Add(_localizer["Profile picture deleted."], Severity.Success);
            //        _navigationManager.NavigateTo("/account", true);
            //    }
            //    else
            //    {
            //        foreach (var error in data.Messages)
            //        {
            //            _snackBar.Add(error, Severity.Error);
            //        }
            //    }
            //}
        }
    }
}