using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliFashion
{
    public class ShelfLife
    {
        //{ "ClassName":"SClass", "CategoryName":"SCateg","GroupName":"SGroup", "ShopCode":1,"Season":"SSeason", "SalePrice":1000  }
        public string ClassName { get; set; }
        public string CategoryName { get; set; }
        public string GroupName { get; set; }
        public int ShopCode { get; set; }
        public string Season { get; set; }
        public int SalePrice { get; set; }
    }
}
