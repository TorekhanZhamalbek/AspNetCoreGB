using EmployeeService.Data;
using EmployeeService.Models;

namespace EmployeeService.Services.Impl
{
    public class DepartmentRepository : IDepartmentRepository
    {
        #region Services

        private readonly EmployeeServiceDbContext _context;

        #endregion

        public DepartmentRepository(EmployeeServiceDbContext context)
        {
            _context = context;
        }

        public int Create(Department data)
        {
            _context.Departments.Add(data);
            _context.SaveChanges();
            return data.Id;
        }

        public bool Delete(int id)
        {
            Department department = GetById(id);
            if (department != null)
            {
                _context.Departments.Remove(department);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public IList<Department> GetAll()
        {
            return _context.Departments.ToList();
        }

        public Department GetById(int id)
        {
            return _context.Departments.FirstOrDefault(dep => dep.Id == id);
        }

        public bool Update(Department data)
        {
            Department department = GetById(data.Id);
            if (department != null)
            {
                department.Description = data.Description;
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
