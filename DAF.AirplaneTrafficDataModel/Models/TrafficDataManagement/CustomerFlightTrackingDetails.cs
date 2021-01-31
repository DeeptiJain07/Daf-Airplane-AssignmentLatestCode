using System;
using System.ComponentModel.DataAnnotations;

namespace DAF.AirplaneTrafficDataModel.Models.TrafficDataManagement
{
    public class CustomerFlightTrackingDetails
    {
        [Key] public int Id { get; set; }
        public string FlightNumber { get; set; }
        public DateTime FlightArrivalDate { get; set; }
        public string CustomerEmailAddress { get; set; }
        public bool IsNotificationSent { get; set; }
    }
}