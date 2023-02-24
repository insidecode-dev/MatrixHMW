using APICruDTO.DTO;
using APICruDTO.Models;
using APİCruDTO.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;

namespace APICruDTO.OtherClasses
{
    public class Initilization
    {
        public List<Employees> ReturnEmployeesTable(string connectionSTring)
        {
            List<Employees> employees = new List<Employees>();
            using (SqlConnection con = new SqlConnection(connectionSTring))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("select * from Employees", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Employees employee = new Employees()
                            {
                                EmployeeID = reader.GetInt32(0),
                                LastName = reader.GetString(1),
                                FirstName = reader.GetString(2),
                                Title = reader.GetString(3),
                                TitleOfCourtesy = reader.GetString(4),
                                BirthDate = reader.GetDateTime(5),
                                HireDate = reader.GetDateTime(6),
                                Adress = reader.GetString(7),
                                City = reader.GetString(8),
                                Region = reader.IsDBNull(9) ? null : reader.GetString(9),
                                PostalCode = reader.GetString(10),
                                Country = reader.GetString(11),
                                HomePhone = reader.GetString(12),
                                Extension = reader.GetString(13),
                                Photo = $"This is photo of {reader.GetString(2)} {reader.GetString(1)}",
                                Notes = reader.GetString(15),
                                ReportsTo = reader.IsDBNull(16)?null: reader.GetInt32(16),
                                PhotoPath = reader.GetString(17),
                            };

                            employee.territories = ReturnTerritoriesTable(employee.EmployeeID, connectionSTring, "select * from dbo.nm where empID=@param", employee);

                            employees.Add(employee);
                        }
                    }
                }
            }
            return employees;
        }



        public List<Territories> ReturnTerritoriesTable(int ID, string connectionSTring, string commandText, Employees employee)
        {
            List<Territories> territories = new List<Territories>();
            using (SqlConnection con = new SqlConnection(connectionSTring))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(commandText, con))
                {
                    cmd.Parameters.AddWithValue("@param", SqlDbType.Int).Value = ID;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Territories territory = new Territories()
                            {
                                TerritoryID = reader.GetString(1),
                                TerritoryDescription = reader.GetString(2),
                                RegionID = reader.GetInt32(3)
                            };
                            territory.employees = employee;
                            territories.Add(territory);
                        }
                    }
                }
            }
            return territories;
        }


        public List<EmployeeDTO> ReturnEmployeeDTOTable(List<Employees> employees)
        {
            var employeeDTOs = new List<EmployeeDTO>();
            employees.ForEach(employee =>
            {
                var employeeDTO = new EmployeeDTO()
                {
                    FirstName = employee.FirstName,
                    LastName = employee.LastName,
                    HomePhone = employee.HomePhone,
                };

                foreach (var territory in employee.territories)
                {
                    var terrotoryDTO = new TerritoriesDTO()
                    {
                        TerritoryDescription = territory.TerritoryDescription
                    };
                    employeeDTO.territoriesDTO.Add(terrotoryDTO);
                }
                employeeDTOs.Add(employeeDTO);
            });

            return employeeDTOs;
        }
    }
}
