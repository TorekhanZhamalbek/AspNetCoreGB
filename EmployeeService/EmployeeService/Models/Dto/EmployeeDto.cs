namespace EmployeeService.Models.Dto
{
    public class EmployeeDto
    {
        public int Id { get; set; }

        public Guid DepartmentId { get; set; }

        public int EmployeeTypeId { get; set; }

        public string FirstName { get; set; }

        public string Surname { get; set; }

        public string Patronymic { get; set; }

        public decimal Salary { get; set; }
    }
}
