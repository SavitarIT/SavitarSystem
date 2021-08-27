namespace Savitar.Web.Client
{

    public class EnvironmentInfo
    {
        public static bool IsDebug()
        {
#if DEBUG
            return true;
#else
            return false;
#endif
        }
    }
}
