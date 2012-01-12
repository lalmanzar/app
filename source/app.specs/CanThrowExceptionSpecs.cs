using System;
using Machine.Specifications;
using app.utility.containers;
using app.web.core.exceptionwrapper;
using developwithpassion.specifications.extensions;
using developwithpassion.specifications.rhinomocks;

namespace app.specs
{
    [Subject(typeof (CanThrowException))]
    public class CanThrowExceptionSpecs
    {
        public abstract class concern : Observes
        {
        }

        public class when_wrapping_a_func : concern
        {
            Establish c = () =>
                              {
                                  action = () => true;
                                  builder = fake.an<IWrappException<bool>>();

                                  container = fake.an<IFetchDependencies>();

                                  ContainerFacadeResolver resolver = () => container;
                                  spec.change(() => Container.facade_resolver).to(resolver);

                                  container.setup(x => x.an<IWrappException<bool>>()).Return(builder);
                              };

            Because b = () =>
                        result = CanThrowException.when(action);

            It should_return_the_wrapper = () => result.ShouldEqual(builder);

            It should_set_the_action = () => builder.action.ShouldEqual(action);


            static Func<bool> action;
            static IWrappException<bool> result;
            static IWrappException<bool> builder;
            static IFetchDependencies container;
        }
    }
}