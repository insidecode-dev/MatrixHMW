using APICruDTO.Models;

namespace APİCruDTO.Models
{
    public class Territories
    {
        public Territories()
        {
            employees = new Employees();
        }
        public string TerritoryID { get; set; } =
        string.Empty;
        public string TerritoryDescription { get; set; } = string.Empty;
        public int RegionID { get; set; } =0;
        public Employees employees { get; set; }
    }
}
