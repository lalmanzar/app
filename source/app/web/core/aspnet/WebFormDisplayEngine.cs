namespace app.web.core.aspnet
{
  public class WebFormDisplayEngine : IDisplayReports
  {
      ICreateViews view_factory;

      public WebFormDisplayEngine(ICreateViews viewFactory)
      {
          view_factory = viewFactory;
      }

      public void display<Report>(Report report)
    {
      view_factory.create_view_that_can_render(report);
    }
  }
}