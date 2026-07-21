namespace SecureGit.Domain.Objects;

public sealed class ObjectId
{
    public string Value { get; }

    public ObjectId(string value)
    {
        Value = value;
    }

    public override string ToString()
    {
        return Value;
    }
}