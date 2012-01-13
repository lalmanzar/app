using System;
using Machine.Specifications;
using app.utility;
using developwithpassion.specifications.rhinomocks;

namespace app.specs
{
    [Subject(typeof (MyLog4Net))]
    public class MyLog4NetSpecs
    {
        public abstract class concern : Observes
        {
        }

        public class when_setting_up_our_log : concern
        {
            Establish c = () => { };

            Because b = () => result = MyLog4Net.setup();

            It should_return_a_logger_configuration = () => result.ShouldBeOfType<IConfigureLog>();

            static IConfigureLog result;
        }
    }
}