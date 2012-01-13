//using System.Collections.Generic;
//using Machine.Specifications;
//using app.utility.extensions;
//using developwithpassion.specifications.rhinomocks;
//
//namespace app.specs
//{
//    [Subject(typeof(StringExtensions))]
//    public class StringExtensionsSpecs
//    {
//        public abstract class concern : Observes
//        {
//
//        }
//
//        public class when_formating_a_string : concern
//        {
//            Establish c = () =>
//                              {
//                                  template = fake.an<string>();
//                                  formated_string = fake.an<string>();
//                              };
//
//            Because b = () => template.format_using(parameter1,parameter2);
//
//
//            It should_return_the_expected_string = () =>
//                                                             {
//                                                                 foreach (var item in collection)
//                                                                 {
//                                                                 }
//                                                             };
//
//            static IEnumerable<StubClass> collection;
//            static string template;
//            static string formated_string;
//            static string parameter1;
//        }
//    }
//}