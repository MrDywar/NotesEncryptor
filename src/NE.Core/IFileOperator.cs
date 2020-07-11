using System;
using System.Collections.Generic;
using System.Text;

namespace NE.Core
{
    public interface IFileOperator
    {
        bool Exists(string path);
        string Read(string path, Encoding encoding);
        void Write(string path, string content, Encoding encoding);
    }
}
