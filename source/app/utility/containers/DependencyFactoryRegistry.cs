using System;
using System.Collections.Generic;
using System.Linq;
using app.web.core.exceptionwrapper;

namespace app.utility.containers
{
  public class DependencyFactoryRegistry : IFindFactoriesForDependencies
  {
    IEnumerable<ICreateASingleDependency> factories;
    MissingDependencyFactory missing_dependency_factory;

    public DependencyFactoryRegistry(IEnumerable<ICreateASingleDependency> factories, MissingDependencyFactory missing_dependency_factory)
    {
      this.factories = factories;
      this.missing_dependency_factory = missing_dependency_factory;
    }

    public ICreateASingleDependency get_factory_that_can_create(Type type)
    {

        return CanThrowException.when(() => { return factories.First(x => x.can_create(type)); }).create_exception_using(()=> missing_dependency_factory(type));
        
//      try
//      {
//        
//      }
//      catch (Exception e)
//      {
//        throw missing_dependency_factory(type);
//      }
    }
  }
}