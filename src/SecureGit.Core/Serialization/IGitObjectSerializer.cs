using SecureGit.Domain.Objects;

namespace SecureGit.Core.Serialization;

public interface IGitObjectSerializer
{
    byte[] Serialize(GitObject gitObject);
}