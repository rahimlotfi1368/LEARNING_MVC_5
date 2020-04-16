namespace Models.Validation
{
    public class Learn07
    {
        public Learn07():base()
        {

        }

		// **********
		// دستور ذیل اگر فقط دقیقا به همین شکل نوشته شود، هیچ کاربردی ندارد
		//[System.ComponentModel.DataAnnotations.Required]

		// Note: در صورتی که برای سن، اعداد اعشاری ولی در محدوده درست باشد،
		// صرفا در سمت سرور خطا ایجاد می‌شود
		//[System.ComponentModel.DataAnnotations.Range(25, 35)]

		[System.ComponentModel.DataAnnotations.Range
			(type: typeof(int), minimum: "25", maximum: "35")]
		public int Age { get; set; }
		// **********

		// **********
		// دستور ذیل اگر فقط دقیقا به همین شکل نوشته شود، هیچ کاربردی ندارد
		//[System.ComponentModel.DataAnnotations.Required]

		[System.ComponentModel.DataAnnotations.Range
			(type: typeof(decimal), minimum: "0", maximum: "50")]
		public decimal Price { get; set; }
		// **********

		// **********
		//[System.ComponentModel.DataAnnotations.Required]

		// Note: Does not work!
		//[System.ComponentModel.DataAnnotations.Range
		//	(type: typeof(string), minimum: "aa", maximum: "dd")]
		//public string ProductCode { get; set; }
		// **********
	}
}
