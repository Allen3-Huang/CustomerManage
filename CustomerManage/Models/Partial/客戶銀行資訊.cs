using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManage.Models.Partial
{
    [MetadataType(typeof(客戶銀行資訊MetaData))]
    public partial class 客戶銀行資訊
    {
        public class 客戶銀行資訊MetaData
        {
            [Required(ErrorMessage = "銀行名稱必填")]
            [MaxLength(50, ErrorMessage = "銀行名稱不得超過50個字元")]
            public string 銀行名稱 { get; set; }
            [Required(ErrorMessage = "帳戶名稱必填")]
            [MaxLength(50, ErrorMessage = "帳戶名稱不得超過50個字元")]
            public string 帳戶名稱 { get; set; }
            [Required(ErrorMessage = "帳戶號碼必填")]
            [MaxLength(50, ErrorMessage = "帳戶號碼不得超過20個字元")]
            public string 帳戶號碼 { get; set; }
        }
    }
}
