using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5HomeWork.Models
{
    [MetadataType(typeof(客戶聯絡人MD))]
    public partial class 客戶聯絡人
    {
    }
    public class 客戶聯絡人MD
    {
        public int Id { get; set; }
        public int 客戶Id { get; set; }
        public string 職稱 { get; set; }
        [Required(ErrorMessage = "連聯絡人名稱為必填欄位")]        
        public string 姓名 { get; set; }
        [EmailAddress(ErrorMessage = "請輸入正確的信箱格式")]
        public string Email { get; set; }
        [RegularExpression(@"\d{4}-\d{6}", ErrorMessage = "請輸入正確的電話格式")]
        public string 手機 { get; set; }
        public string 電話 { get; set; }

        public virtual 客戶資料 客戶資料 { get; set; }
    }
}