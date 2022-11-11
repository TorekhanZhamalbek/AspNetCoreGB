using EmployeeService.Data;
using EmployeeService.Models.Dto;
using EmployeeService.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DictionariesController : ControllerBase
    {

        #region Services 

        private readonly IEmployeeTypeRepository _employeeTypeRepository;

        #endregion

        #region Constructors

        public DictionariesController(IEmployeeTypeRepository employeeTypeRepository)
        {
            _employeeTypeRepository = employeeTypeRepository;
        }

        #endregion

        #region Public Methods

        [HttpGet("employee-types/all")]
        public ActionResult<IList<EmployeeTypeDto>> GetAllEmployeeTypes()
        {
            return Ok(_employeeTypeRepository.GetAll().Select( et =>
                new EmployeeTypeDto
                {
                    Id = et.Id,
                    Description = et.Description
                }
                ).ToList());
        }


        [HttpPost("employee-types/create")]
        public ActionResult<int> CreateEmployeeType([FromQuery] string description)
        {
            return Ok(_employeeTypeRepository.Create(new EmployeeType
            {
                Description = description
            }));
        }

        [HttpDelete("employee-types/delete")]
        public ActionResult<bool> DeleteEmployeeType([FromQuery] int id)
        {
            return Ok(_employeeTypeRepository.Delete(id));
        }

        #endregion

        //TODO: Доработать самостоятельно

    }
}
