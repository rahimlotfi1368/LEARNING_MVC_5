namespace Models.Validation
{
    public class Learn05:object
    {
        public Learn05():base()
        {

        }
		// **********
		public int Age { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		//[System.ComponentModel.DataAnnotations.MaxLength
		//	(length: 20)]

		//[System.ComponentModel.DataAnnotations.MinLength
		//	(length: 3)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 50, MinimumLength = 5)]
		public string FullName { get; set; }
		// **********
	}
}
