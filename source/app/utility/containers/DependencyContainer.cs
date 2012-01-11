using System;

namespace app.utility.containers
{
  public class DependencyContainer : IFetchDependencies
  {
      IFindFactoriesForDependencies factories;

      public DependencyContainer(IFindFactoriesForDependencies factories)
      {
          this.factories = factories;
      }

      public Dependency an<Dependency>()
      {
          var factory = factories.get_factory_that_can_create(typeof(Dependency));
          return (Dependency) factory.create();
      }
  }
}