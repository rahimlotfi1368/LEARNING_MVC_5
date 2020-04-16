namespace Rlx
{
    public static class RegularExpressions:object
    {
        static RegularExpressions()
        {

        }
		// Note: Wrong Usage!
		//public string EmailAddress =
		//	@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";

		// Note: Wrong Usage!
		//public static string EmailAddress =
		//	@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";

		public const string EMAIL_ADDRESS =
			@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";

		public const string USERNAME = @"[a-zA-Z0-9_]{6,20}";

		public const string PASSWORD = @"[a-zA-Z0-9_]{8,20}";
	}
}
