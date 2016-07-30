using System.Data.Entity;

namespace Vehicle.API.Data
{
    // 1. Setup class that inherits from DbContext
    public class VehicleDataContext : DbContext
    {
        // 2. Setup constructor 
        public VehicleDataContext() : base("Vehicle")
        {

        }

        // 3. Descibe our tables
        public IDbSet<Models.Vehicle> Vehicles { get; set; }

    }
}