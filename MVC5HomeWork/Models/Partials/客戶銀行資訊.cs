using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5HomeWork.Models
{
    [MetadataType(typeof(客戶銀行資訊MD))]
    public partial class 客戶銀行資訊
    {
    }

    public class 客戶銀行資訊MD
    {
        public int Id { get; set; }
        public int 客戶Id { get; set; }
        [Required(ErrorMessage = "銀行名稱為必填欄位")]
        public string 銀行名稱 { get; set; }
        [Required(ErrorMessage = "銀行代碼為必填欄位")]        
        public int 銀行代碼 { get; set; }
        [Required(ErrorMessage = "分行代碼為必填欄位")]        
        public Nullable<int> 分行代碼 { get; set; }
        [Required(ErrorMessage = "帳戶名稱為必填欄位")]        
        public string 帳戶名稱 { get; set; }
        [Required(ErrorMessage = "帳戶號碼為必填欄位")] 
        public string 帳戶號碼 { get; set; }

        public virtual 客戶資料 客戶資料 { get; set; }
    }
}