namespace Models.Validation
{
    public class Learn12:object
    {
        public Learn12():base()
        {

        }

        // **********
        public string FullName { get; set; }
        // **********


        // **********
        [System.ComponentModel.ReadOnly
            (isReadOnly: true)]

        [System.ComponentModel.DataAnnotations.DisplayFormat
            (ApplyFormatInEditMode = false, DataFormatString = "{0:c}")]
        //[System.ComponentModel.DataAnnotations.DisplayFormat
        //	(ApplyFormatInEditMode = false, DataFormatString = "{0:#,##0 ريال}")]
        //[System.ComponentModel.DataAnnotations.DataType
        //	(System.ComponentModel.DataAnnotations.DataType.Currency)]
        public int Salary { get; set; }
        // **********


        // **********
        [System.ComponentModel.DataAnnotations.DataType
            (System.ComponentModel.DataAnnotations.DataType.Password)]
        public string Password { get; set; }
        // **********


        // **********
        [System.ComponentModel.DataAnnotations.DataType
            (System.ComponentModel.DataAnnotations.DataType.Url)]
        public string HomePage { get; set; }
        // **********


        // **********
        [System.ComponentModel.DataAnnotations.DataType
            (System.ComponentModel.DataAnnotations.DataType.EmailAddress)]
        public string EmailAddress { get; set; }
        // **********

        // **********
        [System.Web.Mvc.AllowHtml]

        [System.ComponentModel.DataAnnotations.DataType
            (System.ComponentModel.DataAnnotations.DataType.MultilineText)]
        public string Description { get; set; }
        // **********


        // **********
        public bool Active { get; set; }
        // **********
    }
}
