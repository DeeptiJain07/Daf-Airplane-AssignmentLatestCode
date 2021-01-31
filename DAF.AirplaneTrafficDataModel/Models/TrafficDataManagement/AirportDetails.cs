using System.ComponentModel.DataAnnotations;

namespace DAF.AirplaneTrafficDataModel.Models.TrafficDataManagement
{
    public class AirportDetails
    {
        [Key] public int AirportId { get; set; }
        public string ICAOCode { get; set; }
        public string AirportName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}