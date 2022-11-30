using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    internal class SearchLINQ
    {
        public static IEnumerable<Biathlete> SearchByGender(string gender, List<Biathlete> input)
        {
            if (!(string.IsNullOrEmpty(gender)))
                return from l in input where l.Gender == gender select l;
            else
                throw new Exception("Field can't be null");
        }
        public static IEnumerable<Biathlete> SearchByCountry(string country, List<Biathlete> input)
        {
            if(!(string.IsNullOrEmpty(country)))
                return from l in input where l.Country == country select l;
            else 
                throw new Exception("Field can't be null");
        }
        public static IEnumerable<Biathlete> SearchByPenaltyLaps(string penalty, List<Biathlete> input)
        {
            int penaltyLaps;
            if(int.TryParse(penalty, out int laps))
            {
                penaltyLaps = laps;
                return from l in input where l.PenaltyLaps <= penaltyLaps select l;
            }
            else
            {
                throw new Exception ("Penalty laps should be an integer");
            }
            
        }
        public static IEnumerable<Biathlete> SearchByShooting(string _shooting, List<Biathlete> input)
        {
            double shooting;
            if (double.TryParse(_shooting, out shooting))
            {
                return from l in input where l.Shooting  >= shooting  select l;
            }
            else
            {
                throw new Exception("Shooting should be a double ");
            }

        }
    }
}
