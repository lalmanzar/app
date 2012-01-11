using System.Collections.Generic;
using System.Web;

namespace app.web.core.stubs
{
  public class StubRequestFactory : ICreateRequests
  {
    public IProvideDetailsToCommands create_request_from(HttpContext a_context)
    {
      return new StubRequest();
    }

    class StubRequest : IProvideDetailsToCommands
    {
       public  IDictionary<string, string> parameters { get; set; }
    }
  }
}