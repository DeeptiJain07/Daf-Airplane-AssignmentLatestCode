using System;
using System.ComponentModel.DataAnnotations;

namespace DAF.AirplaneTrafficDataModel.Models.TrafficDataManagement
{
    public class FlightDetails
    {
        [Key] public int FlightId { get; set; }
        public string FlightICAO24 { get; set; }
        public string DepartureAirportICAO { get; set; }
        public string ArrivalAirportICAO { get; set; }
        public DateTime? EstimatedDepartureTime { get; set; }
        public DateTime? EstimatedArrivalTime { get; set; }
    }
}