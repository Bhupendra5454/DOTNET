using HRManagement.DBContext;
using HRManagement.Repositories;
using (var context = new HRDBContext())
{

    EmployeeRepository repo = new EmployeeRepository(context);
    var employees = repo.GetAll();
    foreach (var employee in employees)
    {
        Console.WriteLine(employee.FirstName + "  " + employee.LastName + "  " + employee.Contact);
    }

}