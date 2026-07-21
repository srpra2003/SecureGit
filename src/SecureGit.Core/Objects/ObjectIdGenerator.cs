using SecureGit.Domain.Objects;
using SecureGit.Cryptography.Hashing;

namespace SecureGit.Core.Objects;

public sealed class ObjectIdGenerator
{
    private readonly Sha256Hasher _hasher = new();

    public ObjectId Generate(byte[] serializedObject)
    {
        var hash =
            _hasher.ComputeHash(serializedObject);

        return new ObjectId(hash);
    }
}