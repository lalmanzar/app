using app.utility;
using app.web.application.catalogbrowing.stubs;
using app.web.core;
using app.web.core.stubs;

namespace app.web.application.catalogbrowing
{
    public class ViewTheDepartmentsInTheMainDepartmentofTheStore : ISupportAStory
    {
        readonly IGetDepartments department_repository;
        readonly IDisplayReports display_engine;

        public ViewTheDepartmentsInTheMainDepartmentofTheStore()
            : this(Stub.with<StubDepartmentRepository>(),
                   Stub.with<StubDisplayEngine>())
        {
        }

        public ViewTheDepartmentsInTheMainDepartmentofTheStore(IGetDepartments departmentRepository, IDisplayReports displayEngine)
        {
            department_repository = departmentRepository;
            display_engine = displayEngine;
        }

        public void process(IProvideDetailsToCommands the_request)
        {
            display_engine.display(department_repository.get_the_departments_for_this_main_department(the_request.parameters["Id"]));
        }
    }
}