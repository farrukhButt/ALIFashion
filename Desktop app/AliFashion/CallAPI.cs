using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;
using System.Net;
using System.IO;

namespace AliFashion
{
    class CallAPI
    {
        public double ShelfLife(ShelfLife shelflife)
        {
            //[2:26 PM, 12/19/2018] Ahmad Saleem Gcu: 
            // 
            //{ "ClassName":"SClass", "CategoryName":"SCateg","GroupName":"SGroup", "ShopCode":1,"Season":"SSeason", "SalePrice":1000  }
            var sz = JsonConvert.SerializeObject(shelflife);

            return calllocalApi(sz, "http://127.0.0.1:5000/api/PredictShelfLife");
        }

        public double Price(Price price)
        {
            //{ "ClassName":"Pclass", "CategoryName":"PCateg", "SubClassName":"PSub","ColorName":"Pcolor", "GroupName":"PGroup", "TypeName":"PType","Season":"Pseason"  }
            var sz = JsonConvert.SerializeObject(price);
            return calllocalApi(sz, "http://127.0.0.1:5000/api/PredictPrice");
        }

        public double calllocalApi(string ttp, string url)
        {
            double result = 0.0;
            string URL = url;
            string DATA = ttp;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = DATA.Length;
            using (Stream webStream = request.GetRequestStream())
            using (StreamWriter requestWriter = new StreamWriter(webStream, System.Text.Encoding.ASCII))
            {
                requestWriter.Write(DATA);
            }

            try
            {
                WebResponse webResponse = request.GetResponse();
                using (Stream webStream = webResponse.GetResponseStream() ?? Stream.Null)
                using (StreamReader responseReader = new StreamReader(webStream))
                {
                    string s = responseReader.ReadToEnd();
                    //var s = JsonConvert.DeserializeXNode(response);                    
                    s = s.Substring(s.IndexOf(":") + 1);
                    s = s.Substring(0, s.IndexOf('}'));
                    result = double.Parse(s);                    
                }
            }
            catch (Exception e)
            {
                Console.Out.WriteLine("-----------------");
                Console.Out.WriteLine(e.Message);
            }
            return result;
        }
    }
}
