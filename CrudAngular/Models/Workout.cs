using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class Workout
    {
        public int Id { get; set; }

        public DateTimeOffset Date { get; set; }

        public int DistanceInMeters { get; set; }

        public long TimeInSeconds { get; set; }
    }
}
