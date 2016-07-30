using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vehicle.API.Models
{
    public class Vehicle
    {
        // Primary Key
        public int Id { get; set; }

        // User Data
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }
}