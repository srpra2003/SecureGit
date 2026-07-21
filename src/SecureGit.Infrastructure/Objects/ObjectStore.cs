using SecureGit.Domain.Objects;
using SecureGit.Domain.Repositories;

namespace SecureGit.Infrastructure.Objects;

public sealed class ObjectStore
{
    public void Store(
        Repository repository,
        ObjectId objectId,
        byte[] data)
    {
        var objectDirectory =
            Path.Combine(
                repository.GitDirectory,
                "objects",
                objectId.Value[..2]);

        Directory.CreateDirectory(objectDirectory);

        var objectPath =
            Path.Combine(
                objectDirectory,
                objectId.Value[2..]);

        File.WriteAllBytes(
            objectPath,
            data);
    }
}