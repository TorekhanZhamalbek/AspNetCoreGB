using EmployeeService.Data;
using EmployeeService.Models;

namespace EmployeeService.Services.Impl
{
    public class EmployeeRepository : IEmployeeRepository
    {
        #region Services

        private readonly EmployeeServiceDbContext _context;

        #endregion

        public EmployeeRepository(EmployeeServiceDbContext context)
        {
            _context = context;
        }

        public int Create(Employee data)
        {
            _context.Employees.Add(data);
            _context.SaveChanges();
            return data.Id;
        }

        public bool Delete(int id)
        {
            Employee employee = GetById(id);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public IList<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }

        public Employee GetById(int id)
        {
            return _context.Employees.FirstOrDefault(empl => empl.Id == id);
        }

        public bool Update(Employee data)
        {
            Employee employee = GetById(data.Id);
            if (employee != null)
            {
                employee.EmployeeTypeId = data.Id;
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
