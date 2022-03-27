using SPB_Path.Domain.Places.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPB_Path.Domain.Places.Converters
{
    public static class PlacesConverter
    {
        public static PlaceView ToPlaceView(this Place place)
        {
            PlaceView placeView = new PlaceView
            {
                Name = place.Name,
                RequiredTime = place.RequiredTime,
                Importance = place.Importance
            };

            return placeView;
        }
        public static IEnumerable<PlaceView> ToPlaceViews(this IEnumerable<Place> places)
        {
            IEnumerable<PlaceView> placeViews = places.Select(ToPlaceView);

            return placeViews;
        }
    }
}
