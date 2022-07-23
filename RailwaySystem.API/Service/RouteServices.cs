using RailwaySystem.API.Model;
using RailwaySystem.API.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RailwaySystem.API.Services
{
    public class RouteServices
    {
        private IRouteRepo _Iroute;
        public RouteServices(IRouteRepo Iroute)
        {
            _Iroute = Iroute;
        }
        public string SaveRoute(Route route)
        {
            return _Iroute.SaveRoute(route);
        }
        public string UpdateRoute(Route route)
        {
            return _Iroute.UpdateRoute(route);
        }
        public Route GetRoute(int route)
        {
            return _Iroute.GetRoute(route);
        }
        public List<Route> GetAllRoutes()
        {
            return _Iroute.GetAllRoutes();
        }
    }
}