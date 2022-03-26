using Jane;
using SPB_Path.Domain.Places.Converters;
using SPB_Path.Domain.Places.Models;
using SPB_Path.Domain.Places.Services.Interfaces;
using SPB_Path.Tools.Extentions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPB_Path.Domain.Places.Services
{
    public class PlacesService : IPlacesService
    {
        public IResult<IEnumerable<PlaceView>> GetPath(IEnumerable<Place> places, float overallTime)
        {
            return Result.Success(places.MakePath(overallTime).ToPlaceViews());
        }
    }
}
