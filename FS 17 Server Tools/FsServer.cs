using System;
using System.Net;
using System.IO;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS_17_Server_Tools
{
    public class FsServer
    {
        private string _strGameVersion;
        private string _strMatchServer;
        private string _strServerName;
        private string _strWebApiCode;
        private string _strUserName;
        private string _strPassword;
        private Uri _objWebServerAddress;
        private string _strMapName;
        private int _intMoney;
        private int _intMapSize;
        private int _intMaxPlayers;
        private int _intCurrentPlayers;
        private FileInfo _objMapFile;
        private FS_17_Server_Tools.Field[] _aFields;
        private FS_17_Server_Tools.Mod[] _aMods;

        public FsServer()
        {
            _strGameVersion = string.Empty;
            _strMatchServer = string.Empty;
            _strServerName = string.Empty;
            _strWebApiCode = string.Empty;
            _strUserName = string.Empty;
            _strPassword = string.Empty;
            _objWebServerAddress = new Uri("http://127.0.0.1");
            _strMapName = string.Empty;
            _intMoney = 0;
            _intMapSize = 0;
            _intMaxPlayers = 0;
            _intCurrentPlayers = 0;
            _objMapFile = null;
            _aFields = null;
            _aMods = null;
        }

        public Uri WebServerUri
        {
            get
            {
                return _objWebServerAddress;
            }
        }

        public int WebServerPort
        {
            get
            {
                return _objWebServerAddress.Port;
            }
            set
            {
                UriBuilder builder = new UriBuilder(_objWebServerAddress);
                builder.Port = value;
                _objWebServerAddress = builder.Uri;
            }
        }

        public string WebServerHostName
        {
            get
            {
                return _objWebServerAddress.DnsSafeHost;
            }
            set
            {
                UriBuilder builder = new UriBuilder(_objWebServerAddress);
                builder.Host = value;
                _objWebServerAddress = builder.Uri;
            }
        }

        public string WebServerProtocol
        {
            get
            {
                return _objWebServerAddress.Scheme;
            }
            set
            {
                UriBuilder builder = new UriBuilder(_objWebServerAddress);
                builder.Scheme = value;
                _objWebServerAddress = builder.Uri;
            }
        }

        public string GameVersion
        {
            get
            {
                return _strGameVersion;
            }
        }

        public int MaxPlayers
        {
            get
            {
                return _intMaxPlayers;
            }
        }

        public int CurrentPlayers
        {
            get
            {
                return _intCurrentPlayers;
            }
        }

        public string MapName
        {
            get
            {
                return _strMapName;
            }
        }

        public int MapSize
        {
            get
            {
                return _intMapSize;
            }
        }

        public int Money
        {
            get
            {
                return _intMoney;
            }
        }

        public int NumberOfFields
        {
            get
            {
                return this._aFields.Length;
            }
        }

        public int NumberOfMods
        {
            get
            {
                return this._aMods.Length;
            }
        }

        public string WebApiCode
        {
            get
            {
                return _strWebApiCode;
            }
            set
            {
                _strWebApiCode = value;
            }
        }

        public string UserName
        {
            get
            {
                return _strUserName;
            }
            set
            {
                _strUserName = value;
            }
        }

        public string Password
        {
            get
            {
                return _strPassword;
            }
            set
            {
                _strPassword = value;
            }
        }

        public FileInfo MapFile
        {
            get
            {
                return _objMapFile;
            }
            set
            {
                _objMapFile = value;
            }
        }

        //public Image? MapImage(int intSize)
        //{
        //    if (_objMapFile.Exists)
        //    {
        //        Image objImageData = Image.FromFile(_objMapFile.FullName);


        //        return objImageData;
        //    }

        //    return null;
        //}

        public bool SyncInfoWithServer()
        {
            bool bSuccess = false;

            return bSuccess;
        }

        public bool TestConnectionInfo()
        {
            bool bSuccess = false;



            WebRequest wr = WebRequest.Create(_objWebServerAddress);
            HttpWebResponse response = (HttpWebResponse)wr.GetResponse();

            if(response.StatusCode == HttpStatusCode.OK)
            {
                bSuccess = true;
            }

            return bSuccess;
        }

        public bool SaveToFile(FileInfo objServerXmlFile)
        {
            bool bSuccess = false;

            return bSuccess;
        }
    }
}
