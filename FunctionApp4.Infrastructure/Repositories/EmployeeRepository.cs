using FunctionApp4.Domain.Interfaces;
using FunctionApp4.Domain.Models;

namespace FunctionApp4.Infrastructure.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public async Task<Employee> GetEmployees()
        {
            var employee = new Employee();
            employee.VHUR = 7740;
            employee.Name = "Juan Esteban";
            employee.Age = 30;


            return employee;
        }
    }
}
