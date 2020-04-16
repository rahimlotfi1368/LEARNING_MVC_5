namespace ViewModels.MultiLanguageViewModels
{
    public class FormInformationMultiLanguageViewModels:object
    {
        public FormInformationMultiLanguageViewModels():base()
        {

        }

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.Username))]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false,
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = nameof(Resources.Messages.RequiredFieldValidator))]

		//[System.Web.Mvc.Remote
		//	(action: "CheckUsername", controller: "Home", areaName: "MultiLanguage")]

		[System.ComponentModel.DataAnnotations.RegularExpression
			(pattern: Rlx.RegularExpressions.USERNAME)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 20)]
		public string Username { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.DataType
			(System.ComponentModel.DataAnnotations.DataType.Password)]

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
		[System.ComponentModel.DataAnnotations.DataType
			(System.ComponentModel.DataAnnotations.DataType.Password)]

		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.ConfirmPassword))]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false,
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = nameof(Resources.Messages.RequiredFieldValidator))]

		[System.ComponentModel.DataAnnotations.Compare
			(otherProperty: "Password")]
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

		[System.ComponentModel.DataAnnotations.Compare
			(otherProperty: "EmailAddress")]
		public string ConfirmEmailAddress { get; set; }
		// **********

		// **********
		[System.Web.Mvc.AllowHtml]

		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.Description))]

		[System.ComponentModel.DataAnnotations.DataType
			(System.ComponentModel.DataAnnotations.DataType.MultilineText)]
		public string Description { get; set; }
		// **********

	}
}
