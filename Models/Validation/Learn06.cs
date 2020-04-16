namespace Models.Validation
{
    public class Learn06:object
    {
        public Learn06():base()
        {

        }

		// **********
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 250)]

		[System.ComponentModel.DataAnnotations.RegularExpression
			(pattern: @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*")]
		public string EmailAddress { get; set; }
		// **********
	}
}
