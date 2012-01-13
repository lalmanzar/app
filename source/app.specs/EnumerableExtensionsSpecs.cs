using System.Collections.Generic;
using Machine.Specifications;
using app.utility.extensions;
using developwithpassion.specifications.extensions;
using developwithpassion.specifications.rhinomocks;

namespace app.specs
{
    [Subject(typeof(EnumerableExtensions))]
    public class EnumerableExtensionsSpecs
    {
        public abstract class concern : Observes
        {

        }

        public class when_applying_an_action_to_each_element_of_a_collection : concern
        {
            Establish c = () =>
                              {
                                  collection = new List<StubClass>{fake.an<StubClass>(),fake.an<StubClass>(),fake.an<StubClass>(),fake.an<StubClass>()};
                              };

            Because b = () => EnumerableExtensions.each(collection, x=>x.excecuteSomething());


            It should_execute_the_action_on_every_item = () => {
                                                                   foreach (var item in collection)
                                                                   {
                                                                       item.received(x => x.excecuteSomething());
                                                                   }
            };

            static IEnumerable<StubClass> collection;
        }
    }

    public class StubClass
    {
        public virtual void excecuteSomething()
        {
        }
    }
}