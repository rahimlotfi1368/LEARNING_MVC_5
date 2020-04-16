namespace Rlx
{
    public static class Utility
    {
        static Utility()
        {

        }
        public static string ToBootstrapSize(Rlx.Enums.ButtonSize size)
        {
            string bootstrapSize = string.Empty;
            switch (size)
            {
                case Enums.ButtonSize.Large:
                    bootstrapSize = "lg";
                    break;
                case Enums.ButtonSize.Small:
                    bootstrapSize = "sm";
                    break;
                case Enums.ButtonSize.ExtraSmall:
                    bootstrapSize = "xs";
                    break;
            }
            return bootstrapSize;
        }
    }
}
