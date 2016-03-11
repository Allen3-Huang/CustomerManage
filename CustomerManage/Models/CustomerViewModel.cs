using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManage.Models
{
    public class CustomerViewModel
    {
        public string name { get; set; }
        public IList<CustomerManage.Models.客戶資料> Customers { get; set; }
    }
}
