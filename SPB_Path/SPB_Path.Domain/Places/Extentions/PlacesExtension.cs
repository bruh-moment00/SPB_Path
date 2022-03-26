using SPB_Path.Domain.Places.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPB_Path.Tools.Extentions
{
    public static class PlacesExtension
    {
        public static IEnumerable<Place> SortByPriority(this IEnumerable<Place> places)
        {
            return places.OrderBy(p => p.Priority);
        }

        public static IEnumerable<Place> MakePath(this IEnumerable<Place> places, double overallTime)
        {
            IList<Place> path = new List<Place>();
            places = places.SortByPriority();

            int daysRemain = (int)(overallTime / 24);

            double hoursForToday = (overallTime > 24) ? 24 : overallTime;

            while (daysRemain >= 0)
            {
                foreach(Place place in places)
                {
                }
            }

            return path;
        }
    }
}
