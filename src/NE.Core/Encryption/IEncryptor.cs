namespace NE.Core.Encryption
{
    public interface IEncryptor
    {
        byte[] Encrypt(string plainText, string key);
        string Decrypt(byte[] cipherText, string key);
    }
}
