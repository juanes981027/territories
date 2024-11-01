using FunctionApp4.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionApp4.Domain.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<Employee> GetEmployees();
    }
}
