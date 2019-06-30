using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliFashion
{
    public class Price
    {
        //{ "ClassName":"Pclass", "CategoryName":"PCateg", "SubClassName":"PSub","ColorName":"Pcolor", "GroupName":"PGroup", "TypeName":"PType","Season":"Pseason"  }
        public string ClassName { get; set; }
        public string CategoryName { get; set; }
        public string SubClassName { get; set; }
        public string ColorName { get; set; }
        public string GroupName { get; set; }
        public string TypeName { get; set; }
        public string Season { get; set; }
    }
}
