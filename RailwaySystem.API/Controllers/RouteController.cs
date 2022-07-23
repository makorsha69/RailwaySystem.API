using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RailwaySystem.API.Model;
using RailwaySystem.API.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RailwaySystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RouteController : ControllerBase
    {
        private RouteServices _routeS;
        public RouteController(RouteServices routeS)
        {
            _routeS = routeS;
        }
        [HttpPost("SaveRoute")]
        public IActionResult SaveRoute(Route route)
        {
            return Ok(_routeS.SaveRoute(route));
        }
        [HttpPut("UpdateRoute")]
        public IActionResult UpdateRoute(Route route)
        {
            return Ok(_routeS.UpdateRoute(route));
        }
        [HttpGet("GetRoute")]
        public IActionResult GetRoute(int RouteId)
        {
            return Ok(_routeS.GetRoute(RouteId));
        }

        [HttpGet("GetAllRoutes")]
        public List<Route> GetAllRoutess()
        {
            return _routeS.GetAllRoutes();
        }
    }
}