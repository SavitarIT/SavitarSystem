using System;
using System.IO;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using MudBlazor;
using Savitar.Domain.Requests;

namespace Savitar.WebAssembly.Pages.Identity
{
    public partial class Profile
    {
        //private FluentValidationValidator _fluentValidationValidator;
        //private bool Validated => _fluentValidationValidator.Validate(options => { options.IncludeAllRuleSets(); });
        private bool Validate = true;
        private char _firstLetterOfName;
        private readonly UpdateProfileRequest _profileModel = new();

        public string UserId { get; set; }

        private async Task UpdateProfileAsync()
        {
            var response = await _accountManager.UpdateProfileAsync(_profileModel);
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
            await LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            //var state = await _stateProvider.GetAuthenticationStateAsync();
            //var user = state.User;
            //_profileModel.Email = user.GetEmail();
            //_profileModel.FirstName = user.GetFirstName();
            //_profileModel.LastName = user.GetLastName();
            //_profileModel.PhoneNumber = user.GetPhoneNumber();
            //UserId = user.GetUserId();
            //var data = await _accountManager.GetProfilePictureAsync(UserId);
            
            //if (_profileModel.FirstName.Length > 0)
            //{
            //    _firstLetterOfName = _profileModel.FirstName[0];
            //}
        }


        private async Task DeleteAsync()
        {
            //var parameters = new DialogParameters
            //{
            //    {nameof(Shared.Dialogs.DeleteConfirmation.ContentText), $"{string.Format(_localizer["Do you want to delete the profile picture of {0}"], _profileModel.Email)}?"}
            //};
            //var options = new DialogOptions { CloseButton = true, MaxWidth = MaxWidth.Small, FullWidth = true, DisableBackdropClick = true };
            //var dialog = _dialogService.Show<Shared.Dialogs.DeleteConfirmation>(_localizer["Delete"], parameters, options);
            //var result = await dialog.Result;
            //if (!result.Cancelled)
            //{
            //    var request = new UpdateProfilePictureRequest { Data = null, FileName = string.Empty, UploadType = MediaTypeNames.Application.Enums.UploadType.ProfilePicture };
            //    var data = await _accountManager.UpdateProfilePictureAsync(request, UserId);
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