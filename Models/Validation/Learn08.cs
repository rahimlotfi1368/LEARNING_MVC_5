namespace Models.Validation
{
    public class Learn08:object
    {
        public Learn08():base()
        {

        }

		// **********
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.Web.Mvc.Remote
			(action: "CheckUsername", controller: "LearningValidation", areaName: "")]

		[System.ComponentModel.DataAnnotations.RegularExpression
			(pattern: @"[a-zA-Z0-9_]{6,20}")]

		//[System.ComponentModel.DataAnnotations.StringLength
		//	(maximumLength: 20)]
		public string Username { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.RegularExpression
			(pattern: @"[a-zA-Z0-9_]{8,20}")]

		//[System.ComponentModel.DataAnnotations.StringLength
		//	(maximumLength: 20)]

		[System.ComponentModel.DataAnnotations.DataType
			(System.ComponentModel.DataAnnotations.DataType.Password)]
		public string Password { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		// Note: The below code has been deprecated!
		//[System.Web.Mvc.Compare(otherProperty: "Password")]

		//[System.ComponentModel.DataAnnotations.Compare
		//	(otherProperty: "Password")]

		[System.ComponentModel.DataAnnotations.Compare
			(otherProperty: nameof(Password))]

		//[System.ComponentModel.DataAnnotations.RegularExpression
		//	(pattern: @"[a-zA-Z0-9_]{8,20}")]

		//[System.ComponentModel.DataAnnotations.StringLength
		//	(maximumLength: 20)]

		[System.ComponentModel.DataAnnotations.DataType
			(System.ComponentModel.DataAnnotations.DataType.Password)]
		public string ConfirmPassword { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.Web.Mvc.Remote
			(action: "CheckEmailAddress", controller: "LearningValidation", areaName: "")]

		[System.ComponentModel.DataAnnotations.RegularExpression
			(pattern: @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*")]

		// بر خلاف گذرواژه، دستور ذیل باید بماند و حذف نگردد
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 250)]

		//[System.ComponentModel.DataAnnotations.DataType
		//	(System.ComponentModel.DataAnnotations.DataType.EmailAddress)]
		public string EmailAddress { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.Compare
			(otherProperty: nameof(EmailAddress))]

		//[System.ComponentModel.DataAnnotations.RegularExpression
		//	(pattern: @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*")]

		//[System.ComponentModel.DataAnnotations.StringLength
		//	(maximumLength: 250)]

		//[System.ComponentModel.DataAnnotations.DataType
		//	(System.ComponentModel.DataAnnotations.DataType.EmailAddress)]
		public string ConfirmEmailAddress { get; set; }
		// **********
	}
}
