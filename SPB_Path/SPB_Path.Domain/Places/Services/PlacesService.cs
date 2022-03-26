using Jane;
using SPB_Path.Domain.Places.Models;
using SPB_Path.Domain.Places.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPB_Path.Domain.Places.Services
{
    public class PlacesService : IPlacesService
    {
        public IResult<IEnumerable<Place>> GetPlacesOrder(IEnumerable<Place> places, float timeYouHave)
        {
            throw new NotImplementedException();
        }
    }
}
