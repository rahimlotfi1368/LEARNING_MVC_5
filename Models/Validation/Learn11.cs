namespace Models.Validation
{
	public class Learn11 : object
	{
		public Learn11() : base()
		{
		}

		// **********
		// Note: Deprecate
		//[System.ComponentModel.DisplayName
		//	(displayName: "Confirm Password")]

		//[System.ComponentModel.DataAnnotations.Display
		//	(Name = "Confirm Password")]

		// Learn: Using Resource File
		//[System.ComponentModel.DataAnnotations.Display
		//	(Name = "تکرار گذرواژه")]

		// Learn: Using Resource File
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.DataDictionary),
		//	Name = "ConfirmPassword")]

		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.DataDictionary),
		//	Name = nameof(Resources.DataDictionary.ConfirmPassword))]

		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.Username))]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false,
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = nameof(Resources.Messages.RequiredFieldValidator))]

		[System.Web.Mvc.Remote
			(action: "CheckUsername", controller: "LearningValidation")]

		[System.ComponentModel.DataAnnotations.RegularExpression
			(pattern: Rlx.RegularExpressions.USERNAME)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 20)]
		public string Username { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.Password))]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false,
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = nameof(Resources.Messages.RequiredFieldValidator))]

		[System.ComponentModel.DataAnnotations.RegularExpression
			(pattern: Rlx.RegularExpressions.PASSWORD)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 20)]
		public string Password { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.ConfirmPassword))]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false,
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = nameof(Resources.Messages.RequiredFieldValidator))]

		//[System.ComponentModel.DataAnnotations.Compare
		//	(otherProperty: "Password")]

		[System.ComponentModel.DataAnnotations.Compare
			(otherProperty: nameof(Password))]
		public string ConfirmPassword { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.EmailAddress))]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false,
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = nameof(Resources.Messages.RequiredFieldValidator))]

		[System.ComponentModel.DataAnnotations.RegularExpression
			(pattern: Rlx.RegularExpressions.EMAIL_ADDRESS)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 250)]
		public string EmailAddress { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.ConfirmEmailAddress))]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false,
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = nameof(Resources.Messages.RequiredFieldValidator))]

		//[System.ComponentModel.DataAnnotations.Compare
		//	(otherProperty: "EmailAddress")]

		[System.ComponentModel.DataAnnotations.Compare
			(otherProperty: nameof(EmailAddress))]
		public string ConfirmEmailAddress { get; set; }
		// **********
	}
}
