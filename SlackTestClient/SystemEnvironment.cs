public class SystemEnvironment
{
    /// <summary>
    /// 
    /// </summary>
    public static bool IsDebug
    {
        get
        {
#if DEBUG
            return true;
#else
            return false;
#endif
        }
    }
}
