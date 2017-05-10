using System;
using System.IO;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS_17_Server_Tools
{
    public class Mod
    {
        private string _strModName;
        private string _strModFileName;
        private string _strModAuthor;
        private string _strModVersion;
        private string _strModTitle;
        private string _strModHash;

        public Mod()
        {
            _strModName = string.Empty;
            _strModAuthor = string.Empty;
            _strModVersion = string.Empty;
            _strModTitle = string.Empty;
            _strModHash = string.Empty;
        }

        public string Name
        {
            get
            {
                return _strModName;
            }
        }

        public string FileName
        {
            get
            {
                return _strModFileName;
            }
        }

        public string Author
        {
            get
            {
                return _strModAuthor;
            }
        }

        public string Version
        {
            get
            {
                return _strModVersion;
            }
        }

        public string Title
        {
            get
            {
                return _strModTitle;
            }
        }

        public string Hash
        {
            get
            {
                return _strModHash;
            }
            set
            {
                _strModHash = value;
            }
        }

        public bool IsLocal
        {
            get
            {
                return File.Exists(_strModFileName);
            }
        }

        public string CalcLocalHash()
        {
            string strLocalHash = string.Empty;

            if(File.Exists(_strModFileName))
            {
                FileInfo objLocalMod = new FileInfo(_strModFileName);

                MD5CryptoServiceProvider hasher = new MD5CryptoServiceProvider();

                FileStream fs = new FileStream(_strModFileName, FileMode.Open, FileAccess.Read);

                byte[] aBytesFromFileName = System.Text.Encoding.UTF8.GetBytes(objLocalMod.Name);
                byte[] aBytesFromFileContent = null;

                fs.Read(aBytesFromFileContent, 0, int.Parse(fs.Length.ToString()));

                var aAllBytes = new byte[aBytesFromFileContent.Length + aBytesFromFileName.Length];
                aBytesFromFileContent.CopyTo(aAllBytes, 0);
                aBytesFromFileName.CopyTo(aAllBytes, aBytesFromFileContent.Length);

                byte[] aBytesLocalHash = hasher.ComputeHash(aAllBytes);
                strLocalHash = System.BitConverter.ToString(aBytesLocalHash);
                strLocalHash = strLocalHash.Replace("-", "");
                strLocalHash = strLocalHash.ToLower();
                _strModHash = strLocalHash;
            }
            else
            {
                _strModHash = string.Empty;
            }

            return strLocalHash;
        }
    }
}
