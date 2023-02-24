using APICruDTO.DTO;
using APICruDTO.Models;
using APICruDTO.OtherClasses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace APICruDTO.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        //private static readonly string[] Summaries = new[]
        //{
        //    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        //};

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<EmployeeDTO> Get()
        {
            Initilization initilization = new Initilization();

            var employees = initilization.ReturnEmployeesTable("Data Source=DESKTOP-TOURGOO\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");
            var employeeDTOs = initilization.ReturnEmployeeDTOTable(employees);

            return employeeDTOs;
        }

        //[HttpPost]
        //public IEnumerable<EmployeeDTO> Post([FromForm] PostEmployeeDTO employeeDTO)
        //{
        //    Initilization initilization = new Initilization();
        //    using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-TOURGOO\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True"))
        //    {
        //        con.Open();
        //        using (SqlCommand cmd = new SqlCommand("AddNewEmployee", con))
        //        {
        //            cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //            cmd.Parameters.Clear();
        //            List<SqlParameter> sqlParameter = new List<SqlParameter>()
        //            {
        //                new SqlParameter("@LastName", employeeDTO.LastName),
        //                new SqlParameter("@FirstName", employeeDTO.FirstName),
        //                new SqlParameter("@Title", employeeDTO.Title),
        //                new SqlParameter("@TitleOfCourtesy", employeeDTO.TitleOfCourtesy),
        //                new SqlParameter("@BirthDate", DateTime.Parse(employeeDTO.BirthDate.ToString())),
        //                new SqlParameter("@HireDate", DateTime.Parse(employeeDTO.HireDate.ToString())),
        //                new SqlParameter("@Address", employeeDTO.Adress),
        //                new SqlParameter("@City", employeeDTO.City),
        //                new SqlParameter("@Region", employeeDTO.Region),
        //                new SqlParameter("@PostalCode", employeeDTO.PostalCode),
        //                new SqlParameter("@Country", employeeDTO.Country),
        //                new SqlParameter("@HomePhone", employeeDTO.HomePhone),
        //                new SqlParameter("@Extension", employeeDTO.Extension),
        //                new SqlParameter("@Photo", employeeDTO.Photo),
        //                new SqlParameter("@Notes", employeeDTO.Notes),
        //                new SqlParameter("@PhotoPath", employeeDTO.PhotoPath),
        //            };

        //            foreach (SqlParameter p in sqlParameter)
        //            {
        //                p.Direction = ParameterDirection.Input;
        //                cmd.Parameters.Add(p);
        //            }
        //            cmd.ExecuteNonQuery();
        //        }
        //    }

        //    var employees = initilization.ReturnEmployeesTable("Data Source=DESKTOP-TOURGOO\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");
        //    var employeeDTOs = initilization.ReturnEmployeeDTOTable(employees);

        //    return employeeDTOs;
        //}
    }
}
