using System.Text;
using SecureGit.Domain.Objects;
using SecureGit.Core.Serialization;

namespace SecureGit.Core.Objects;

public sealed class BlobSerializer : IGitObjectSerializer
{
    public byte[] Serialize(GitObject gitObject)
    {
        var blob = (Blob)gitObject;

        var header =
            $"blob {blob.Content.Length}\0";

        var headerBytes =
            Encoding.UTF8.GetBytes(header);

        var result =
            new byte[
                headerBytes.Length +
                blob.Content.Length];

        Buffer.BlockCopy(
            headerBytes,
            0,
            result,
            0,
            headerBytes.Length);

        Buffer.BlockCopy(
            blob.Content,
            0,
            result,
            headerBytes.Length,
            blob.Content.Length);

        return result;
    }
}