using APİCruDTO.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace APICruDTO.Models
{
    public class Employees
    {
        public Employees()
        {
            territories = new List<Territories>();
        }
        public int EmployeeID { get; set; }
        public string LastName { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string TitleOfCourtesy { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get;set; }  
        public string Adress { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Region { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string HomePhone { get; set; } = string.Empty;
        public string Extension { get; set; } = string.Empty;
        public string Photo { get; set; } 
        public string Notes { get; set; } = string.Empty;
        public int? ReportsTo { get; set; } = 0;
        public string PhotoPath { get; set; } = string.Empty;
        public ICollection<Territories> territories { get; set; }  
    }
}
