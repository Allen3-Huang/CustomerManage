using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManage.Models
{
    [MetadataType(typeof(客戶資料MetaData))]
    public partial class 客戶資料
    {
        public class 客戶資料MetaData{
            [Required(ErrorMessage = "客戶名稱必填")]
            [MaxLength(50, ErrorMessage = "客戶名稱不得超過50個字元")]
            public string 客戶名稱 { get; set; }
            [Required(ErrorMessage = "統一編號必填")]
            [MaxLength(8, ErrorMessage = "統一編號不得超過8個字元")]
            public string 統一編號 { get; set; }
            [Required(ErrorMessage = "電話必填")]
            [MaxLength(50, ErrorMessage = "電話不得超過50個字元")]
            [Phone]
            public string 電話 { get; set; }

            [Required(ErrorMessage = "傳真必填")]
            [MaxLength(50, ErrorMessage = "傳真不得超過50個字元")]
            public string 傳真 { get; set; }
            [Required(ErrorMessage = "地址必填")]
            [MaxLength(50, ErrorMessage = "地址不得超過100個字元")]
            public string 地址 { get; set; }
            [Required(ErrorMessage = "Email必填")]
            [MaxLength(50, ErrorMessage = "Email不得超過250個字元")]
            [EmailAddress]
            public string Email { get; set; }
        }
    }
}
