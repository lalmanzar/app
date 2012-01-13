using System;
using System.IO;
using Machine.Specifications;
using app.utility;
using developwithpassion.specifications.rhinomocks;

namespace app.specs
{
    [Subject(typeof (LoggerCreator))]
    public class IConfigureLogSpecs
    {
        public abstract class concern : Observes<IConfigureLog, LoggerCreator>
        {
        }

        public class when_configuring_our_loger_to_use_the_console_as_output : concern
        {
            Establish c = () => { };

            Because b = () => result = sut.use_console();

            It should_set_the_console_output_as_its_own = () => result.output.ShouldEqual(Console.Out);

            It should_return_the_correct_object = () =>
                                                      {
                                                          result.ShouldNotBeNull();
                                                          result.ShouldBeOfType<ICanLog>();
                                                      };

            static ICanLog result;
        }

        public class when_configuring_our_loger_to_use_a_text_file : concern
        {
            Establish c = () => { };

            Because b = () => result = sut.use_text_file();

            It should_set_the_output_as_a_stream_writer = () => result.output.ShouldBeOfType<StreamWriter>();

            It should_return_the_correct_object = () =>
                                                      {
                                                          result.ShouldNotBeNull();
                                                          result.ShouldBeOfType<ICanLog>();
                                                      };

            static ICanLog result;
        }
    }
}