namespace Infrastructure
{
	public class MaxWordsAttribute :
		System.ComponentModel.DataAnnotations.ValidationAttribute
	{
		//public MaxWordsAttribute() : base()
		//{
		//}

		public MaxWordsAttribute(int maxWords) : base()
		{
			MaxWords = maxWords;
		}

		protected virtual int MaxWords { get; set; }

		//protected override System.ComponentModel.DataAnnotations.ValidationResult IsValid
		//	(object value, System.ComponentModel.DataAnnotations.ValidationContext validationContext)
		//{
		//	return base.IsValid(value, validationContext);
		//}

		protected override System.ComponentModel.DataAnnotations.ValidationResult IsValid
			(object value, System.ComponentModel.DataAnnotations.ValidationContext validationContext)
		{
			string errorMessage = string.Empty;

			if (value == null)
			{
				return System.ComponentModel.DataAnnotations.ValidationResult.Success;
			}

			string valueString =
				value.ToString().Trim();

			if (valueString == string.Empty)
			{
				return System.ComponentModel.DataAnnotations.ValidationResult.Success;
			}

			while (valueString.Contains("  "))
			{
				valueString =
					valueString.Replace("  ", " ");
			}

			if (valueString.Split(' ').Length <= MaxWords)
			{
				return System.ComponentModel.DataAnnotations.ValidationResult.Success;
			}

			if (string.IsNullOrWhiteSpace(ErrorMessage) == false)
			{
				// Tanx: Mr. Mohammad Razavifar
				ErrorMessage =
					string.Format(ErrorMessage, validationContext.DisplayName, MaxWords);

				return new System.ComponentModel.DataAnnotations.ValidationResult(ErrorMessage);
			}

			if (ErrorMessageResourceType == null)
			{
				errorMessage = "Too Many Words!";

				return new System.ComponentModel.DataAnnotations.ValidationResult(errorMessage);
			}

			System.Resources.ResourceManager resourceManager =
				new System.Resources.ResourceManager(ErrorMessageResourceType);

			resourceManager.IgnoreCase = true;

			object result =
					resourceManager.GetObject(ErrorMessageResourceName,
					System.Threading.Thread.CurrentThread.CurrentCulture);

			// Tanx: Mr. Mohammad Razavifar
			errorMessage =
				string.Format(result.ToString().Trim(), validationContext.DisplayName, MaxWords);

			return new System.ComponentModel.DataAnnotations.ValidationResult(errorMessage);
		}
	}
}
