using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace ColorPicker
{
    public class FavouriteColor
    {
        public string favColorName { get; set; }
        public string favHexText { get; set; }
        public string favCreatedData { get; set; }
    }
}
