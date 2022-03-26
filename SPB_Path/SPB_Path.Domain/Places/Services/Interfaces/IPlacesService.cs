using Jane;
using SPB_Path.Domain.Places.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPB_Path.Domain.Places.Services.Interfaces
{
    public interface IPlacesService
    {
        public IResult<IEnumerable<Place>> GetPlacesOrder(IEnumerable<Place> places, float time);
    }
}
