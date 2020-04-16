namespace Models.Validation
{
    public class Learn13:object
    {
        public Learn13():base()
        {

        }

        [Infrastructure.MaxWords
            (maxWords: 3,
            ErrorMessageResourceType = typeof(Resources.Messages),
            ErrorMessageResourceName = nameof(Resources.Messages.MaxWordsValidator))]
        public string FullName { get; set; }
    }
}
