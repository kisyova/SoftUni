using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_GenericList
{

    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Enum |
        AttributeTargets.Method, AllowMultiple = false)]

    class Version : Attribute
    {

        public Version(byte minor, byte major)
        {
            this.Minor = minor;
            this.Major = major;
        }

        public byte Minor { get; private set; }
        public byte Major { get; private set; }

    }
}
