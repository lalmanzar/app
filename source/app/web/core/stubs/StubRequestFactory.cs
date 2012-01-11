using System.Web;
using app.web.application.catalogbrowing;

namespace app.web.core.stubs
{
    public class StubRequestFactory : ICreateRequests
    {
        public IProvideDetailsToCommands create_request_from(HttpContext a_context)
        {
            return new StubRequest(a_context.Request.Params["request_name"]);
        }

        class StubRequest : IProvideDetailsToCommands
        {
            readonly string _requestName;

            public StubRequest(string request_name)
            {
                _requestName = request_name;
            }

            public InputModel map<InputModel>()
            {
                object item = new Department();
                return (InputModel) item;
            }

            public string request_name
            {
                get { return request_name; }
            }
        }
    }
}

