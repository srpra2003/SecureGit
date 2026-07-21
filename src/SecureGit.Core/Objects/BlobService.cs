using SecureGit.Domain.Objects;
using SecureGit.Domain.Repositories;
using SecureGit.Infrastructure.Objects;

namespace SecureGit.Core.Objects;

public sealed class BlobService
{
    private readonly BlobSerializer _serializer =
        new();

    private readonly ObjectIdGenerator _generator =
        new();

    private readonly ObjectStore _store =
        new();

    public ObjectId Store(
        Repository repository,
        Blob blob)
    {
        var serialized =
            _serializer.Serialize(blob);

        var objectId =
            _generator.Generate(serialized);

        _store.Store(
            repository,
            objectId,
            serialized);

        return objectId;
    }
}