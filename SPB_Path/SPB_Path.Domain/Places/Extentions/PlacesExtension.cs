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
        public static IList<Place> SortByPriority(this IList<Place> places)
        {
            return (IList<Place>)places.OrderBy(p => p.Priority);
        }

        public static IList<Place> MakePath(this IList<Place> places, double overallDays)
        {
            IList<Place> path = new List<Place>();
            places = places.SortByPriority();

            double hoursForToday = 24;

            while (overallDays > 0)
            {
                for(int i = 0; i < places.Count; i++)
                {
                    if(places[i] != null)
                    {
                        if (places[i].RequiredTime + 8 <= hoursForToday)
                        {
                            path.Add(places[i]);
                            places[i] = null;
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
