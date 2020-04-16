namespace Models.Validation
{
    public class Learn04:object
    {
        public Learn04():base()
        {

        }

		// **********
		public int Age { get; set; }
		// **********

		// **********
		//[System.ComponentModel.DataAnnotations.Required]
		//[System.ComponentModel.DataAnnotations.Required()]
		//[System.ComponentModel.DataAnnotations.RequiredAttribute]
		//[System.ComponentModel.DataAnnotations.RequiredAttribute()]
		//Required Not nullable but Allow Empty-Strings and with AllowEmptyStrings=false makes this property Not EmptyStrings
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		public string FullName { get; set; }
		// **********
	}
}
