using FluentValidation;
using Savitar.WebAssembly.Blockchain.Ethereum.Models;
using Savitar.WebAssembly.Blockchain.Ethereum.Validation;

namespace Savitar.WebAssembly.Blockchain.Ethereum.Validators
{
    public class ERC20ContractValidator : AbstractValidator<ERC20ContractModel>
    {
        public ERC20ContractValidator()
        {
            RuleFor(t => t.Address).IsEthereumAddress();
            RuleFor(t => t.DecimalPlaces).GreaterThan(0).WithMessage("Decimal Places must be greater than 0");
        }
    }
}
