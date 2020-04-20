namespace Rlx.Enums
{

    public enum ButtonType
    {
        submit,
        button,
        reset,
        menu,
    }

    public enum ButtonStyle
    {
        Default,
        Primary,
        Secondary,
        Success,
        Info,
        Warning,
        Danger
    }

    public enum ButtonSize
    {
        Large,
        Small,
        ExtraSmall,
        Normal
    }

    //Created by Dariush Tasdigi
    public enum DisplayValueType : int
    {
        Undefined = 0,

        Number,
        Percent,
        Currency,

        Date,
        DateTime,

        Raw,
        Url,
        EmailAddress,
    }


}