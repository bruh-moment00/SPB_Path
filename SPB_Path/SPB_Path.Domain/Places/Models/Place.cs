using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPB_Path.Domain.Places.Models
{
    public class Place
    {
        public Place(string name, float requiredTime, int importance)
        {
            Name = name;
            RequiredTime = requiredTime;
            Importance = importance;
            Priority = Importance / RequiredTime;
        }
        string Name { get; set; }
        float RequiredTime { get; set; }
        int Importance { get; set; }
        float Priority { get; }
    }
}
