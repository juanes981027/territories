using FunctionApp4.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionApp4.Application.Services
{
    public class FunctionApp4Service
    {
        public async Task <Employee> GetEmployees ()
        {
            var employee = new Employee();
            employee.VHUR = 7740;
            employee.Name = "Juan Esteban";
            employee.Age = 30;

            
            return employee;
        }
    }
}