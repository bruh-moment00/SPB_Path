using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SPB_Path.Domain.Places.Models;
using SPB_Path.Domain.Places.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPB_Path.API.Controllers
{
    [Route("api/path")]
    [ApiController]
    public class PlacesController : ControllerBase
    {
        private readonly IPlacesService _placesService;
        public PlacesController(IPlacesService placesService)
        {
            _placesService = placesService;
        }
        
        [HttpGet]
        public IEnumerable<PlaceView> GetOptimalPath([FromBody]IEnumerable<Place> places, float overallTime)
        {
            return _placesService.GetPath(places, overallTime).Value;
        }
    }
}
