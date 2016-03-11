using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManage.Models.Partial
{
    [MetadataType(typeof(客戶聯絡人MetaData))]
    public partial class 客戶聯絡人
    {
        public class 客戶聯絡人MetaData
        {
            [Required(ErrorMessage = "職稱必填")]
            [MaxLength(50, ErrorMessage = "職稱不得超過50個字元")]
            public string 職稱{ get; set; }

            [Required(ErrorMessage = "姓名必填")]
            [MaxLength(50, ErrorMessage = "姓名不得超過50個字元")]
            public string 姓名{ get; set; }

            [Required(ErrorMessage = "Email必填")]
            [MaxLength(250, ErrorMessage = "Email不得超過250個字元")]
            [EmailAddress]
            public string Email{ get; set; }

            [Required(ErrorMessage = "手機必填")]
            [MaxLength(50, ErrorMessage = "手機不得超過50個字元")]
            public string 手機{ get; set; }

            [Required(ErrorMessage = "電話必填")]
            [MaxLength(50, ErrorMessage = "電話不得超過50個字元")]
            public string 電話{ get; set; }
        }
    }
}
