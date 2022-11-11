using EmployeeService.Data;
using EmployeeService.Models;
using EmployeeService.Services.Impl;

namespace EmployeeService.Services
{
    public interface IEmployeeRepository : IRepository<Employee, int>
    {
    }
}
