using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCrawlDataFromWebsite
{
    public class ProductInfo
    {
        public string ProductName { set; get; }
        public string ProductPrice { set; get; }
        public string ProductOldPrice { set; get; }
        public string Discount { set; get; }
        public string ProductLink { set; get; }
    }
}
