using System.Threading.Tasks;
using MudBlazor;
using Savitar.Domain.Models.Requests;

namespace Savitar.Web.Client.Pages.Identity
{
    public partial class Security
    {
        private readonly ChangePasswordRequest _passwordModel = new();

        private async Task ChangePasswordAsync()
        {
            var response = await _accountsApi.ChangePasswordAsync(_passwordModel);
            if (response.Succeeded)
            {
                _snackbar.Add("Your password has been updated.", Severity.Success);
                _passwordModel.Password = string.Empty;
                _passwordModel.NewPassword = string.Empty;
                _passwordModel.ConfirmNewPassword = string.Empty;
            }
            else
            {
                foreach (var error in response.Messages)
                {
                    _snackbar.Add(error, Severity.Error);
                }
            }
        }

        private bool _newPasswordVisibility;
        private InputType _newPasswordInput = InputType.Password;
        private string _newPasswordInputIcon = Icons.Material.Filled.VisibilityOff;

        private bool _currentPasswordVisibility;
        private InputType _currentPasswordInput = InputType.Password;
        private string _currentPasswordInputIcon = Icons.Material.Filled.VisibilityOff;

        private void TogglePasswordVisibility(bool newPassword)
        {
            if (newPassword)
            {
                if (_newPasswordVisibility)
                {
                    _newPasswordVisibility = false;
                    _newPasswordInputIcon = Icons.Material.Filled.VisibilityOff;
                    _newPasswordInput = InputType.Password;
                }
                else
                {
                    _newPasswordVisibility = true;
                    _newPasswordInputIcon = Icons.Material.Filled.Visibility;
                    _newPasswordInput = InputType.Text;
                }
            }
            else
            {
                if (_currentPasswordVisibility)
                {
                    _currentPasswordVisibility = false;
                    _currentPasswordInputIcon = Icons.Material.Filled.VisibilityOff;
                    _currentPasswordInput = InputType.Password;
                }
                else
                {
                    _currentPasswordVisibility = true;
                    _currentPasswordInputIcon = Icons.Material.Filled.Visibility;
                    _currentPasswordInput = InputType.Text;
                }
            }
        }
    }
}