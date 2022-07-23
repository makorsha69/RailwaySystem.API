using RailwaySystem.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RailwaySystem.API.Repository
{
    public interface IRouteRepo
    {
        public string SaveRoute(Route route);
        public string UpdateRoute(Route route);
        public string DeactRoute(int RouteId);
        Route GetRoute(int RouteId);
        List<Route> GetAllRoutes();
    }
}