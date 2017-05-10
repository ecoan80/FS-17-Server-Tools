using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS_17_Server_Tools
{
    public class Field
    {
        private string _strFieldName;
        private int _intFieldNumber;
        private bool _bOwned;
        private float _fArea;
        private int _intPrice;
        private Point _objLocation;

        public Field()
        {
            _strFieldName = string.Empty;
            _intFieldNumber = -1;
            _bOwned = false;
            _fArea = 0.0f;
            _intPrice = -1;
            _objLocation = new Point(0.0d, 0.0d);
        }

        public string Name
        {
            get
            {
                return _strFieldName;
            }
            set
            {
                _strFieldName = value;
            }
        }

        public int Number
        {
            get
            {
                return _intFieldNumber;
            }
            set
            {
                _intFieldNumber = value;
            }
        }

        public bool Owned
        {
            get
            {
                return _bOwned;
            }
            set
            {
                _bOwned = value;
            }
        }

        public float Area
        {
            get
            {
                return _fArea;
            }
            set
            {
                _fArea = value;
            }
        }

        public int Price
        {
            get
            {
                return _intPrice;
            }
            set
            {
                _intPrice = value;
            }
        }

        public Point Location
        {
            get
            {
                return _objLocation;
            }
            set
            {
                _objLocation = value;
            }
        }

        public double XLocation
        {
            get
            {
                return _objLocation.X;
            }
            set
            {
                _objLocation.X = value;
            }
        }

        public double YLocation
        {
            get
            {
                return _objLocation.Y;
            }
            set
            {
                _objLocation.Y = value;
            }
        }
    }
}
