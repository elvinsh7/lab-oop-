using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace icherishahar
{
    class Vehicle
    {
        public Vehicle(string color, int year)
        {
            this.color = color;
            this.year = year;
        }

        public string color { get; set; }
        public int year { get; set; }

    }
}
