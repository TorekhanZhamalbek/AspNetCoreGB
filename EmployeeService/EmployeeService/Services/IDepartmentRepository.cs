using EmployeeService.Data;
using EmployeeService.Models;
using EmployeeService.Services.Impl;

namespace EmployeeService.Services
{
    public interface IDepartmentRepository : IRepository<Department, int>
    {
    }
}
