namespace Models.Validation
{
    public class learn09:object
    {
        public learn09():base()
        {

        }

		// **********
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.Web.Mvc.Remote
			(action: "CheckUsername", controller: "LearningValidation", areaName: "")]

		[System.ComponentModel.DataAnnotations.RegularExpression
			(pattern: Rlx.RegularExpressions.USERNAME)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 20)]
		public string Username { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.RegularExpression
			(pattern: Rlx.RegularExpressions.PASSWORD)]

		[System.ComponentModel.DataAnnotations.DataType
			(System.ComponentModel.DataAnnotations.DataType.Password)]
		public string Password { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.Compare
			(otherProperty: nameof(Password))]

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
			(pattern: Rlx.RegularExpressions.EMAIL_ADDRESS)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 250)]
		public string EmailAddress { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.Compare
			(otherProperty: nameof(EmailAddress))]
		public string ConfirmEmailAddress { get; set; }
		// **********
	}
}
