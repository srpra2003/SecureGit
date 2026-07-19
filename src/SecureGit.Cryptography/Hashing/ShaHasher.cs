using System.Security.Cryptography;
using System.Text;

namespace SecureGit.Cryptography.Hashing;

public sealed class Sha256Hasher {
    public string ComputeHash(byte[] data) {
        var hash = SHA256.HashData(data);

        var builder = new StringBuilder(hash.Length * 2);

        foreach(var b in hash) {
            builder.Append(b.ToString("x2"));
        }

        return builder.ToString();
    }
}