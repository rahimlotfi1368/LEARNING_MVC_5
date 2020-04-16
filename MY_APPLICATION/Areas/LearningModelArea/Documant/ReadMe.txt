فرض کنیم که کلاس نقش دارای فیلد های 
id , IsActive , Name
می باشد که از طریق یک فرم مقداردهی می شود
ممکن است هکر بیاید در این فرم با استفاده از 
inspect element
یک چک باکس برای 
IsActive
درست کرد و آن را فعال کرده
در حالی که این فیلد توسط ادمین باید برسی شود و بعد از آن فعال کند
برای جلوگیری از این عمل ما از
Bind
استفاده می کنیم

[System.Web.Mvc.HttpPost]
[System.Web.Mvc.ValidateAntiForgeryToken]
	public virtual System.Web.Mvc.ActionResult Create	
		 ([System.Web.Mvc.Bind(Include = "Id , Name")] Models.Role role)
	{
		return (null);
	}

در کد بالا فقط فیلد های 
id , name
بایند می شود

[System.Web.Mvc.HttpPost]
[System.Web.Mvc.ValidateAntiForgeryToken]
	public virtual System.Web.Mvc.ActionResult Create	
		 ([System.Web.Mvc.Bind(Exclude = "IsActive")] Models.Role role)
	{
		return (null);
	}

در کد بالا غیر فیلد  
IsActive
الباقی بایند می شود