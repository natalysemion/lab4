using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;

namespace lab_4
{
    internal class Helper
    {
        public static string path = "D:\\2 курс\\oop\\lab4\\lab4data.json";
        public static List<Biathlete> biathletes = new List<Biathlete>();
        public static List<Biathlete> linqSorted = new List<Biathlete>();
        public static List<Biathlete> LinqSortedBiathletes { get => linqSorted; set => linqSorted = value; }

        public static void AddBiathlete(Biathlete biathlete)
        {
            bool b = true;
            //MessageBox.Show(biathletes.Count() + " ");
            int k = biathletes.Count();
            //MessageBox.Show("k = "+k.ToString());
            for (var i = 0; i < k; i++)
            {
                if (biathletes[i].Id == biathlete.Id)
                {
                    b = false;
                    MessageBox.Show("Biathlete with entered ID already exists " + biathletes.Count());
                    break;
                }
                
            }
            if (b) biathletes.Add(biathlete);
        }

        public static bool DeleteBiathleteByName(string name)
        {
            bool b = false;
            for(int i = 0; i < biathletes.Count; i++)
            {
                if(biathletes[i].Name == name)
                {
                    biathletes.RemoveAt(i);
                    b = true;
                }
            }
            return b;
        }
        public static Biathlete SearchId(string id)
        {
            Biathlete biathlete = null;
            int _id;
            int.TryParse(id, out _id);
            for(int i = 0; i < biathletes.Count; i++)
            {
                if (biathletes[i].Id == _id)
                {
                    return biathletes[i];
                }
            }
            MessageBox.Show("Didn't find");
            return null;
        }
        public static void ChangeBiathleteById(Biathlete biathlete)
        {
            bool b = false;
                     
            for(int i = 0; i < biathletes.Count; i++)
            {
                if(biathletes[i].Id == biathlete.Id)
                {
                    biathletes[i].Name = biathlete.Name;
                    biathletes[i].Gender = biathlete.Gender;
                    biathletes[i].Shooting = biathlete.Shooting;
                    biathletes[i].Country = biathlete.Country;
                    biathletes[i].PenaltyLaps = biathlete.PenaltyLaps;
                    b = true;
                    break;
                }
            }
            if(!b)
            {
                MessageBox.Show("Biathlete with this id doesn't exist");
            }
        }
        public static Biathlete CheckInput(string id, string name, string gender, string country, string shooting, string penalty)
        {
            int _id;
            int laps;
            double _shooting;
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(gender))
            {
                throw new Exception("Empty field are not allowed");
            }
            else if (!int.TryParse(id, out _id))
            {
                throw new Exception("Id must be type of int");
            }
            else if (!int.TryParse(penalty, out laps))
            {
                throw new Exception("Penalty laps must be type of int");
            }
            else if (!double.TryParse(shooting, out _shooting))
            {
                throw new Exception("Shooting must be type of double");
            }

            else
            {
                return new Biathlete(_id, name, country, gender, _shooting, laps);
            }
            
        }
    }
}
