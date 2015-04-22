# MVC5-HomeWork-Chris
ASP.NET MVC 5 開發實戰 (台北)  第一週作業，使用 『客戶資料 這個資料庫做開發。

##[課程實作進度回報](https://docs.google.com/forms/d/16JAJ2A1Geb-Dl5Bl0TzR0xjGZomTbxBg_YZEcN-e8OY/viewform)

第一周作業：
* 請使用 "客戶資料" 這個資料庫做開發 (如附件檔案)
* 請實作出「客戶資料管理」、「客戶聯絡人管理」與「客戶銀行帳戶管理」等簡易 CRUD 功能 (盡量做各種功能出來)
* 實作一份簡易報表，顯示欄位有「客戶名稱、聯絡人數量、銀行帳戶數量」共三個欄位，用一個表格呈現報表即可。
* 該專案要有一個自訂的 SQL Server 檢視表，並且匯入 EDMX
* 主選單要有連結可以直接連到三個主要功能的列表頁
* 對於 Create 與 Edit 表單要套用欄位驗證 (必填或 Email 格式驗證)
* 刪除資料功能不能真的刪除資料庫中的資料，必須修改資料庫，加上一個「是否已刪除」欄位，資料庫中的該欄位為 bit 類型，0 代表未刪除，1 代表已刪除，且列表頁不得顯示已刪除的資料。
* 實作「客戶聯絡人」的「模型驗證」，同一個客戶下的聯絡人，其 Email 不能重複。
* 實作一個「自訂輸入驗證屬性」可驗證「手機」的電話格式必須為 "\d{4}-\d{6}" 的格式 ( e.g. 0911-111111 )

注意事項：

1. 請在你的 GitHub 建立一個獨立專案，並將本次作業上傳到 GitHub
2. 請到【課程進度實作回報】表單回報作業，並回報 GitHub 專案網址
3. 請針對每個功能做出獨立的版本控管，方便我查看你每個版本改了些甚麼程式碼
4. 請勿將資料庫加入版控，以免版控發生問題 (因為資料庫檔會被VS鎖定)
5. 做不出來沒關係，請在回報進度時寫上你哪幾個功能無法完成！
