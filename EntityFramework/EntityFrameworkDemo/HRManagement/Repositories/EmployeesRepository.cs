using HRManagement.Entities;
using HRManagement.DBContext;

namespace HRManagement.Repositories
{
    public class EmployeeRepository
    {
        private HRDBContext _context;
        public EmployeeRepository(HRDBContext context)
        {
            _context = context;
        }

        public List<Employee> GetAll()
        {
            var employees = _context.Employees.ToList();
            return employees;
        }

        
    }
}
