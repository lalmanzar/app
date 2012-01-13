using app.utility;

namespace app.tasks.startup
{
  public class Startup
  {
    public static void run()
    {
      Start.by.running<ConfigureCoreServices>()
        .followed_by<ConfigureTheFrontController>()
        .followed_by<ConfigureQueries>()
        .end_with<ConfiguringRoutes>();
        MyLog4Net.setup().use_console().Info("asdasd");
    }
  }
}