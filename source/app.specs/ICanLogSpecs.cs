using System;
using System.IO;
using Machine.Specifications;
using app.utility;
using developwithpassion.specifications.rhinomocks;
using developwithpassion.specifications.extensions;

namespace app.specs
{
    [Subject(typeof(Log))]
    public class ICanLogSpecs
    {
        public abstract class concern : Observes<ICanLog, Log>
        {
        }

        public class when_logging_an_information : concern
        {
                Establish c = () =>
                                  {
                                      output = new StringWriter();
                                      depends.on(output);
                                      message_generator = depends.on<IGenerateLogMessages>();
                                      exception = new Exception();
                                      message = "ramdom string";
                                      message_generator.setup(x => x.generate(Log.info_header, exception)).Return(message);
                                  };

                Because b = () => sut.Info(exception);

                It should_send_the_correct_messago_to_the_output = () => output.ToString().ShouldEqual(message+output.NewLine);

                
                static Exception exception;
                static TextWriter output;
                static string message;
                static IGenerateLogMessages message_generator;
           
        }

        
    }
}