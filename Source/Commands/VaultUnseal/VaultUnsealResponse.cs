namespace Tangram.Commands.VaultUnseal
{
  /// <summary>
  /// Response object from VaultUnseal
  /// </summary>
  public class VaultUnsealResponse
  {
    /// <summary>
    /// Did we unseal the vault
    /// </summary>
    public bool Success { get; set; }
  }
}
