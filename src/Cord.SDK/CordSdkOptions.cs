namespace Cord.SDK;

public sealed class CordSdkOptions
{
    public string ApplicationId { get; set; } = null!;
    public string Secret { get; set; } = null!;
    public int ClientTokenExpiration { get; set; } = 60;
    public int ServerTokenExpiration { get; set; } = 1440;
}