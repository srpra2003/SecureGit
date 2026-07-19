namespace SecureGit.Domain.Objects;

public sealed class Blob {
    public byte[] Content { get; }

    public Blob(byte[] content) {
        Content = content;
    }
}