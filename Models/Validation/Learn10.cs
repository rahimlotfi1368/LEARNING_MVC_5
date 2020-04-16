namespace Models.Validation
{
	public class Learn10 : object
	{
		public Learn10() : base()
		{
		}

		// **********
		// Learn (1): ErrorMessage
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false,
			ErrorMessage = "You did not specify Username!")]

		[System.Web.Mvc.Remote
			(action: "CheckUsername", controller: "LearningValidation")]

		[System.ComponentModel.DataAnnotations.RegularExpression
			(pattern: Rlx.RegularExpressions.USERNAME)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 20)]
		public string Username { get; set; }
		// **********

		// **********
		// Learn (2): {0}
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false,
			ErrorMessage = "You did not specify {0}!")]

		[System.ComponentModel.DataAnnotations.RegularExpression
			(pattern: Rlx.RegularExpressions.PASSWORD)]

		[System.ComponentModel.DataAnnotations.DataType
			(System.ComponentModel.DataAnnotations.DataType.Password)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 20)]
		public string Password { get; set; }
		// **********

		// **********
		// Learn (3): DisplayName
		// Learn (4): Display
		//[System.ComponentModel.DisplayName
		//	(displayName: "Confirm Password")]

		[System.ComponentModel.DataAnnotations.Display
			(Name = "Confirm Password")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false,
			ErrorMessage = "{0} is required!")]

		[System.ComponentModel.DataAnnotations.Compare
			(otherProperty: nameof(Password))]
		public string ConfirmPassword { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(Name = "Email Address")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false,
			ErrorMessage = "{0} is required!")]

		[System.Web.Mvc.Remote
			(action: "CheckEmailAddress", controller: "LearningValidation")]

		[System.ComponentModel.DataAnnotations.RegularExpression
			(pattern: Rlx.RegularExpressions.EMAIL_ADDRESS,
			ErrorMessage = "{0} is not valid!")]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 250)]
		public string EmailAddress { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(Name = "Confirm Email Address")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false,
			ErrorMessage = "{0} is required!")]

		[System.ComponentModel.DataAnnotations.Compare
			(otherProperty: nameof(EmailAddress))]
		public string ConfirmEmailAddress { get; set; }
		// **********
	}
}
