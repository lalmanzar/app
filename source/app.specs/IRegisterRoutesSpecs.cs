using System.Collections.Generic;
using Machine.Specifications;
using app.specs.utility;
using app.web.core;
using developwithpassion.specifications.rhinomocks;

namespace app.specs
{
    [Subject(typeof(RegisterRoutes))]
    public class IRegisterRoutesSpecs
    {
        public abstract class concern : Observes<IRegisterRoutes,RegisterRoutes>
        {

        }

        public class when_registerin_a_rout : concern
        {
            Establish c = () =>
                              {
                                  routes = fake.an<IList<RequestHandler>>();
                                  depends.on(routes);
                              };

            Because b = () => sut.a_report<StubRequestType, StubQuery, StubModel>();
            
            It should_return_the_route_table = () => result.ShouldEqual(route_table);

            static IRegisterRoutes result;
            static IRegisterRoutes route_table;
            static IList<RequestHandler> routes;


            class StubRequestType
            {
            }

            class StubQuery : IFetchA<StubModel>
            {
                public StubModel fetch_using(IProvideDetailsToCommands request)
                {
                    throw new System.NotImplementedException();
                }
            }
            class StubModel
            {
            }
        }
    }
}