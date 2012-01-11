using System;
using System.Collections.Generic;

namespace app.web.application.catalogbrowing
{
    public interface IGetDepartments
    {
        IEnumerable<Department> get_the_main_departments();
        IEnumerable<Department> get_the_departments_for_this_main_department(string the_main_department_id);
    }
}