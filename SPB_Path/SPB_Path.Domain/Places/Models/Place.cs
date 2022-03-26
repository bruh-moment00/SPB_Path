using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPB_Path.Domain.Places.Models
{
    public class Place
    {
        public Place(string name, double requiredTime, int importance)
        {
            Name = name;
            RequiredTime = requiredTime;
            Importance = importance;
            Priority = Importance / RequiredTime;
        }
        public string Name { get; set; }
        public double RequiredTime { get; set; }
        public int Importance { get; set; }
        public double Priority { get; }
    }
}
