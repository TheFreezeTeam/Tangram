namespace Tangram.Commands.VaultUnseal
{
  using FluentValidation;

  internal class VaultUnsealValidator : AbstractValidator<VaultUnsealCommand>
  {
    public VaultUnsealValidator()
    {
      //45b114b6cd38c6b0c74d39f4b7cf9f5fea652c31359794e3bb8e433beb2a2967be
      RuleFor(aVaultUnsealCommand => aVaultUnsealCommand.VaultKey).Length(66);
    }
  }
}
