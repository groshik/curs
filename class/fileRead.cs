using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace Curs
{
    class FileRead
    {
        public string GetJSONString(string FileName)
        {
            string JSONString = File.ReadAllText(FileName, Encoding.GetEncoding("Windows-1251"));
            return StringCipher.Decrypt(JSONString, "SuperStudent");
        }
        public void SaveJSONString(string FileName, string JSONString)
        {         
            File.WriteAllText(FileName, StringCipher.Encrypt(JSONString, "SuperStudent"), Encoding.GetEncoding("Windows-1251"));
        }
        public void EncriptFile(string FileName)
        {
            string FileText = File.ReadAllText(FileName, Encoding.GetEncoding("Windows-1251"));
            File.WriteAllText(FileName, StringCipher.Encrypt(FileText, "SuperStudent"), Encoding.GetEncoding("Windows-1251"));
        }

    }
}
