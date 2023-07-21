using System.Text;
using JsonWebToken;
using Newtonsoft.Json;

namespace Cord.SDK.Application;

internal static class Extensions
{
    public static string WriteToken(this JwsDescriptor descriptor) => new JwtWriter().WriteTokenString(descriptor);

    public static SymmetricJwk ToSigningKey(this string source) =>
        SymmetricJwk.FromByteArray(Encoding.ASCII.GetBytes(source));

    public static string? ToJsonIgnoreNulls<T>(this T? source) where T : class => JsonConvert.SerializeObject(source,
        new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore
        });
}