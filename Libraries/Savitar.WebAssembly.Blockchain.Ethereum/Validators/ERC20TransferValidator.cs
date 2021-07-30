using FluentValidation;
using Savitar.WebAssembly.Blockchain.Ethereum.Models;
using Savitar.WebAssembly.Blockchain.Ethereum.Validation;

namespace Savitar.WebAssembly.Blockchain.Ethereum.Validators
{
    public class ERC20TransferValidator : AbstractValidator<ERC20TransferModel>
    {
        public ERC20TransferValidator()
        {
            RuleFor(t => t.To).IsEthereumAddress();
            RuleFor(t => t.Value).GreaterThan(0).WithMessage("Amount must be greater than 0");
            RuleFor(t => t.ERC20Contract).SetValidator(new ERC20ContractValidator());
        }
    }
}
