using System.Web;
using Machine.Specifications;
using app.specs.utility;
using app.web.core;
using app.web.core.aspnet;
using developwithpassion.specifications.extensions;
using developwithpassion.specifications.rhinomocks;
using app.web.core.extensions;

namespace app.specs
{
    [Subject(typeof(IncomingRequest))]
    public class IncomingRequestSpecs
    {
        public abstract class concern : Observes
        {
        }


        internal class StubRequest
        {
        }

        public class when_matching_a_request_and_it_is_valid : concern
        {
            Establish c = () =>
                              {
                                  request = fake.an<IProvideDetailsToCommands>();
                                  request.setup(x => x.request_name).Return("StubRequest");
                              };

            Because b = () =>
              result = IncomingRequest.was.made_for<StubRequest>();

            It should_return_that_its_valid = () =>
                               result(request).ShouldEqual(true);

            static RequestCriteria result;
            static IProvideDetailsToCommands request;
        }

        public class when_matching_a_request_and_it_is_not_valid : concern
        {
            Establish c = () =>
            {
                request = fake.an<IProvideDetailsToCommands>();
                request.setup(x => x.request_name).Return("Something");
            };

            Because b = () =>
              result = IncomingRequest.was.made_for<StubRequest>();

            It should_return_that_its_invalid = () =>
                               result(request).ShouldEqual(false);

            static RequestCriteria result;
            static IProvideDetailsToCommands request;
        }
    }

}