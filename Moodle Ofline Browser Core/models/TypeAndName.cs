using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle_Ofline_Browser_Core.models
{
    public struct TypeAndName
    {
        public TypeAndName(Type Type, string propertyName)
        {
            this.Type = Type;
            this.propertyName = propertyName;
        }
        public Type Type { get; }
        public string propertyName { get; }
    }
}
