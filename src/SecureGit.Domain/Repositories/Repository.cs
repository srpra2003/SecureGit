namespace SecureGit.Domain.Repositories;

public sealed class Repository {
    public string WorkingDirectory { get; }

    public string GitDirectory => Path.Combine(WorkingDirectory, ".securegit");

    public Repository(string workingDirectory) {
        WorkingDirectory = workingDirectory;
    }
}