using Microsoft.EntityFrameworkCore;

namespace DAF.AirplaneTrafficDataModel.Models.TrafficDataManagement
{
    public class TrafficDataManagementContext : DbContext
    {
        public TrafficDataManagementContext()
        {

        }

        public TrafficDataManagementContext(DbContextOptions<TrafficDataManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AirportDetails> AirportDetails { get; set; }
        public virtual DbSet<FlightDetails> FlightDetails { get; set; }
        public virtual DbSet<CustomerFlightTrackingDetails> CustomerFlightTrackingDetails { get; set; }
    }
}
