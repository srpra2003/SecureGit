using SecureGit.Domain.Repositories;

namespace SecureGit.Infrastructure.Repositories;

public sealed class RepositoryInitializer {
    public void Initialize(Repository repository) {
        Directory.CreateDirectory(repository.GitDirectory);
        Directory.CreateDirectory(Path.Combine(repository.GitDirectory, "objects"));
        Directory.CreateDirectory(Path.Combine(repository.GitDirectory, "refs"));
        Directory.CreateDirectory(Path.Combine(repository.GitDirectory, "refs", "heads"));
        Directory.CreateDirectory(Path.Combine(repository.GitDirectory, "refs", "tags"));

        File.WriteAllText(
            Path.Combine(repository.GitDirectory, "HEAD"),
            "ref: refs/heads/main");
        File.WriteAllText(
            Path.Combine(repository.GitDirectory, "config"),
            string.Empty);
        File.WriteAllText(
            Path.Combine(repository.GitDirectory, "index"),
            string.Empty
        );
    }
}