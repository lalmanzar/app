namespace app.utility
{
    public class MyLog4Net
    {
         public static IConfigureLog setup()
         {
             return new LoggerCreator();
         }
    }
}