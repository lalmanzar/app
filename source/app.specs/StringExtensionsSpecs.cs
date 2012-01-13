using System.Collections.Generic;
using Machine.Specifications;
using app.utility.extensions;
using developwithpassion.specifications.rhinomocks;

namespace app.specs
{
    [Subject(typeof(StringExtensions))]
    public class StringExtensionsSpecs
    {
        public abstract class concern : Observes
        {

        }

        public class when_formating_a_string : concern
        {
            Establish c = () =>
                              {
                                  template = "{0} test {1}";
                                  formated_string = "testing1 test testing2";
                                  parameter1 = "testing1";
                                  parameter2 = "testing2";
                              };

            Because b = () => result = template.format_using(parameter1,parameter2);


            It should_return_the_expected_string = () => result.ShouldEqual(formated_string);

            static IEnumerable<StubClass> collection;
            static string template;
            static string formated_string;
            static string parameter1;
            static string parameter2;
            static string result;
        }
    }
}