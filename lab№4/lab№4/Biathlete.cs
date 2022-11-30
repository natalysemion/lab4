using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    internal class Biathlete
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Country { get; set; }
        public double Shooting { get; set; }
        public int PenaltyLaps { get; set; }
        public Biathlete() { }
        public Biathlete(int id, string name, string country, string gender, double shooting, int penLaps)
        {
            Id = id;
            Name = name;
            Country = country;
            Gender = gender;
            Shooting = shooting;
            PenaltyLaps = penLaps;
        }
    }
}
