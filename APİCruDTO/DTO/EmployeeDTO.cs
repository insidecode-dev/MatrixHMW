using APİCruDTO.Models;
using System.Collections;
using System.Collections.Generic;

namespace APICruDTO.DTO
{
    public class EmployeeDTO
    {
        public EmployeeDTO()
        {
            territoriesDTO = new List<TerritoriesDTO>();
        }
        public string LastName { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string HomePhone { get; set; } = string.Empty;
        public ICollection<TerritoriesDTO> territoriesDTO { get; set; }
    }
}
