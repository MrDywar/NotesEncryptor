using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NE.Core
{
    public class WFileOperator : IFileOperator
    {
        public bool Exists(string path)
        {
            return File.Exists(path);
        }

        public string Read(string path, Encoding encoding)
        {
            return File.ReadAllText(path, encoding);
        }

        public void Write(string path, string contents, Encoding encoding)
        {
            File.WriteAllText(path, contents, encoding);
        }
    }
}
