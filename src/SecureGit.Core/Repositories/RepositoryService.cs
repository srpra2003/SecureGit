using SecureGit.Domain.Repositories;
using SecureGit.Infrastructure.Repositories;

namespace SecureGit.Core.Repositories;

public sealed class RepositoryService {
    private readonly RepositoryInitializer _initializer;

    public RepositoryService() {
        _initializer = new RepositoryInitializer();
    }

    public void Initialize(string workingDirectory) {
        var repository = new Repository(workingDirectory);
        _initializer.Initialize(repository);
    }
}