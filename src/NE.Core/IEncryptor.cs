using System;
using System.Collections.Generic;
using System.Text;

namespace NE.Core
{
    public interface IEncryptor
    {
        byte[] Encrypt(string plainText, string key);
        string Decrypt(byte[] cipherText, string key);
    }
}
