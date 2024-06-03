using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT3B_Kostky
{
    public class Kostka
    {
        public int Hod { get; set; }    

        public Kostka()
        {
            Random random = new Random();
            Hod = random.Next(1,7);
        }
    }
}
