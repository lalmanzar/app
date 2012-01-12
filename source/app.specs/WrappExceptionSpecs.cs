using System;
using Machine.Specifications;
using app.utility.containers;
using app.web.core;
using app.web.core.exceptionwrapper;
using developwithpassion.specifications.rhinomocks;
using developwithpassion.specifications.extensions;

namespace app.specs
{
    [Subject(typeof (WrappException<bool>))]
    public class WrappExceptionSpecs
    {
        public abstract class concern : Observes<IWrappException<bool>,
                                            WrappException<bool>>
        {
        }

        public class when_wrapping_a_func_that_can_throw_exception : concern
        {
            class and_it_throws_the_exception
            {
                Establish c = () =>
                                  {
                                      exception = new Exception();
                                      action = fake.an<Func<bool>>();
                                      funcexception = fake.an<Func<Exception>>();

                                      funcexception.setup(x => x()).Return(exception);
                                      action.setup(x => x()).Throw(exception);
                                  };

                Because b = () =>
                                {
                                    sut.action = action;
                                    spec.catch_exception(() => sut.create_exception_using(funcexception));
                                };

                It should_throw_the_correct_exception = () => spec.exception_thrown.ShouldEqual(exception);

                static IProvideDetailsToCommands the_request;
                static ISupportAStory application_feature;
                static Exception exception;
                static Func<Exception> funcexception;
                static Func<bool> action;
            }

            class and_it_not_throws_the_exception
            {
                Establish c = () =>
                {
                    exception = new Exception();
                    action = fake.an<Func<bool>>();
                    funcexception = fake.an<Func<Exception>>();

                    depends.on<ItemCreationExceptionFactory>();
                };

                Because b = () =>
                {
                    sut.action = action;
                    spec.catch_exception(() => sut.create_exception_using(funcexception));
                };

                It should_not_throw_a_exception = () => spec.exception_thrown.ShouldBeNull();

                static IProvideDetailsToCommands the_request;
                static ISupportAStory application_feature;
                static Type testType;
                static Exception exception;

                static Func<Exception> funcexception;
                static Func<bool> action;
            }

        }
    }
}