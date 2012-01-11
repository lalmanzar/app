using System;
using System.Collections.Generic;
using System.Linq;

namespace app.web.application.catalogbrowing.stubs
{
  public class StubDepartmentRepository:IGetDepartments
  {
    public IEnumerable<Department> get_the_main_departments()
    {
      return Enumerable.Range(1, 100).Select(x => new Department {name = x.ToString("Main Deparment 0")});
    }

      public IEnumerable<Department> get_the_departments_for_this_main_department(string the_main_department_id)
      {
          return Enumerable.Range(1, 100).Select(x => new Department { name = x.ToString("Sub Deparment 0 for "+the_main_department_id) }); 
      }
  }
}