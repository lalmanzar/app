using System;
using System.Collections;
using System.Collections.Generic;
using app.web.core.requestmatching;

namespace app.web.core
{
  public interface IRegisterRoutes : IEnumerable<IProcessASingleRequest>
  {
    void a_report<RequestType, Query,ReportModel>() where Query:IFetchA<ReportModel>; 
  }

    public class RegisterRoutes : IRegisterRoutes
    {
        IList<RequestHandler> routes;

        public RegisterRoutes(IList<RequestHandler> routes)
        {
            this.routes = routes;
        }

        public void a_report<RequestType, Query, ReportModel>() where Query : IFetchA<ReportModel>
        {
            ISupportAStory feature = null;
            var route = new RequestHandler(IncomingRequest.was.made_for<RequestType>(), feature);
            routes.Add(route);
        }
        


        //TODO: LATER!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        public IEnumerator<IProcessASingleRequest> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}