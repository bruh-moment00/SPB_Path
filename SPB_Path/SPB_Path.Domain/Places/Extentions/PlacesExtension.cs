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
            return places.OrderByDescending(p => p.Priority);
        }

        public static IEnumerable<Place> MakePath(this IEnumerable<Place> places, double overallDays)
        {
            IList<Place> path = new List<Place>();
            places = places.SortByPriority();

            IList<Place> placesRemain = places.ToList();

            while (overallDays > 0)
            {
                double hoursForToday = 24;

                for (int i = 0; i < placesRemain.Count; i++)
                {
                    if(placesRemain[i] != null)
                    {
                        if (placesRemain[i].RequiredTime + 8 <= hoursForToday)
                        {
                            path.Add(placesRemain[i]);
                            hoursForToday -= placesRemain[i].RequiredTime;
                            placesRemain[i] = null;
                        }
                    }
                }

                path.Add(new Place("Сон", 8, 0));
                overallDays--;
            }

            return path;
        }
    }
}
