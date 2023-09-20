namespace Cord.SDK.Exceptions;

public sealed class UnSupportedJsonConvertionException : Exception
{
    public UnSupportedJsonConvertionException(string type) : base($"The typeof '{type}' is not supported.")
    {
    }
}