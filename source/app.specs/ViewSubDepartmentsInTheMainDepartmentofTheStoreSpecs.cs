using System;
using System.Collections.Generic;
using Machine.Specifications;
using app.web.application.catalogbrowing;
using app.web.core;
using developwithpassion.specifications.extensions;
using developwithpassion.specifications.rhinomocks;

namespace app.specs
{
    [Subject(typeof (ViewSubDepartmentsInTheMainDepartmentofTheStore))]
    public class ViewSubDepartmentsInTheMainDepartmentofTheStoreSpecs
    {
        public abstract class concern : Observes<ISupportAStory,
                                            ViewSubDepartmentsInTheMainDepartmentofTheStore>
        {
        }

        public class when_run : concern 
        {
            Establish c = () =>
                              {
                                  display_engine = depends.on<IDisplayReports>();
                                  department_repository = depends.on<IGetDepartments>();
                                  the_sub_departments = new List<Department> {new Department()};
                                  the_request = fake.an<IProvideDetailsToCommands>();
                                  the_request.parameters = new Dictionary<string,string> {{"Id",Guid.NewGuid().ToString()}};
                                  department_repository.setup(x => x.get_the_departments_for_this_main_department(the_request.parameters["Id"])).Return(the_sub_departments);
                              };

            Because b = () =>
                        sut.process(the_request);


            It should_display_the_sub_departments = () =>
                                                     display_engine.received(x => x.display(the_sub_departments));


            static IProvideDetailsToCommands the_request;
            static IGetDepartments department_repository;
            static IDisplayReports display_engine;
            static IEnumerable<Department> the_sub_departments;
        }
    }
}