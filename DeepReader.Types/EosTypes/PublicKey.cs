using System.Text.Json.Serialization;
using DeepReader.Types.Fc;
using DeepReader.Types.JsonConverters;

namespace DeepReader.Types.EosTypes;

[JsonConverter(typeof(PublicKeyJsonConverter))]
public class PublicKey : BinaryType
{
    private string _value = string.Empty;

    public static implicit operator PublicKey(string value)
    {
        return new PublicKey { _value = value };
    }

    public static implicit operator string(PublicKey value)
    {
        return value._value;
    }

    public static implicit operator PublicKey(byte[] value)
    {
        return new PublicKey { Binary = value };
    }

    public static implicit operator byte[](PublicKey value)
    {
        return value.Binary;
    }

    public static PublicKey Empty => new();
}