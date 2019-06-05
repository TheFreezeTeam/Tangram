namespace Tangram.Commands.VaultUnseal
{
  using MediatR;

  /// <summary>
  /// Begins the Vault unseal process
  /// </summary>
  public class VaultUnsealCommand: IRequest<VaultUnsealResponse>
  {
    /// <summary>
    /// The Vault Key use to unseal the vault
    /// </summary>
    public string VaultKey { get; set; }
  }
}
