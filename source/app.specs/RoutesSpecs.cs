﻿using System;
using System.Collections;
using System.Collections.Generic;
using Machine.Specifications;
using app.specs.utility;
using app.web.core;
using developwithpassion.specifications.rhinomocks;

namespace app.specs
{
  [Subject(typeof(Routes))]
  public class RoutesSpecs
  {
    public abstract class concern : Observes
    {
    }

    public class when_accessing_route_registration : concern
    {
      Establish c = () =>
      {
        fake_routes = new FakeRoutes();
        route_table = ObjectFactory.container.scaffold(spec, fake).an(fake_routes);
      };

      Because b = () =>
        result = Routes.register;

      It should_return_the_route_table = () =>
        result.ShouldEqual(route_table);

      static IRegisterRoutes result;
      static IRegisterRoutes route_table;
      static IRegisterRoutes fake_routes;
    }
  }

    class FakeRoutes : IRegisterRoutes
  {
    IEnumerator IEnumerable.GetEnumerator()
    {
      return GetEnumerator();
    }

    public IEnumerator<IProcessASingleRequest> GetEnumerator()
    {
      yield break;
    }

    public void a_report<RequestType, Query, ReportModel>() where Query : IFetchA<ReportModel>
    {

    }
  }
}