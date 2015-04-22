using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5HomeWork.Models
{
    [MetadataType(typeof(客戶資料MD))]
    public partial class 客戶資料
    {
    }

    public class 客戶資料MD
    {
        public 客戶資料MD()
        {
            this.客戶銀行資訊 = new HashSet<客戶銀行資訊>();
            this.客戶聯絡人 = new HashSet<客戶聯絡人>();
        }
    
        public int Id { get; set; }
        [Required(ErrorMessage = "客戶名稱為必填欄位")]
        public string 客戶名稱 { get; set; }
        public string 統一編號 { get; set; }
        [Required(ErrorMessage = "電話為必填欄位")]
        public string 電話 { get; set; }
        public string 傳真 { get; set; }
        public string 地址 { get; set; }
        [EmailAddress(ErrorMessage = "請輸入正確的信箱格式")]
        public string Email { get; set; }
    
        public virtual ICollection<客戶銀行資訊> 客戶銀行資訊 { get; set; }
        public virtual ICollection<客戶聯絡人> 客戶聯絡人 { get; set; }
    }
}