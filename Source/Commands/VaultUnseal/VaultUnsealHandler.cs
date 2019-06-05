namespace Tangram.Commands.VaultUnseal
{
  using System;
  using System.Threading;
  using System.Threading.Tasks;
  using MediatR;

  internal class VaultUnsealHandler : IRequestHandler<VaultUnsealCommand,VaultUnsealResponse>
  {
    public Task<VaultUnsealResponse> Handle(VaultUnsealCommand aVaultUnsealCommand, CancellationToken aCancellationToken)
    {
      Console.WriteLine($"The Vault Key: {aVaultUnsealCommand.VaultKey}");
      Console.WriteLine("TODO actually unseal the Vault");

      return Task.FromResult(new VaultUnsealResponse { Success = true });
    }

    //Task<Unit> IRequestHandler<VaultUnsealCommand, Unit>.Handle(VaultUnsealCommand aVaultUnsealCommand, CancellationToken aCancellationToken)
    //{
    //  Console.WriteLine($"The Vault Key: {aVaultUnsealCommand.VaultKey}");
    //  Console.WriteLine("TODO actually unseal the Vault");
    //  return Unit.Task;
    //}
  }
}
