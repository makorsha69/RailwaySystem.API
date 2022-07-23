using Microsoft.EntityFrameworkCore;
using RailwaySystem.API.Data;
using RailwaySystem.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RailwaySystem.API.Repository
{
    public class RouteRepo : IRouteRepo
    {
        private TrainDbContext _trainDb;
        public RouteRepo(TrainDbContext trainDbContext)
        {
            _trainDb = trainDbContext;
        }
        #region Get All Route
        /// <summary>
        /// When this fuction is invoked we get all Route
        /// </summary>
        /// <returns>List of all the Route</returns>
        public List<Route> GetAllRoutes()
        {
            List<Route> route = null;
            try
            {
                route = _trainDb.route.ToList();
            }
            catch (Exception ex)
            {

            }
            return route;
        }
        #endregion

        #region Get Route by Id
        /// <summary>
        /// 
        /// </summary>
        /// <param name="RouteId"></param>
        /// <returns></returns>
        public Route GetRoute(int RouteId)
        {
            Route route = null;
            try
            {
                route = _trainDb.route.Find(RouteId);
            }
            catch (Exception ex)
            {

            }
            return route;

        }
        #endregion

        #region Save Route
        public string SaveRoute(Route route)
        {
            string stCode = string.Empty;
            try
            {
                _trainDb.route.Add(route);
                _trainDb.SaveChanges();
                stCode = "200";
            }
            catch (Exception ex)
            {
                stCode = "400";
            }
            return stCode;

        }
        #endregion

        #region Update Route
        public string UpdateRoute(Route route)
        {
            string stCode = string.Empty;
            try
            {
                _trainDb.Entry(route).State = EntityState.Modified;
                _trainDb.SaveChanges();
                stCode = "200";
            }
            catch
            {
                stCode = "400";
            }
            return stCode;

        }
        #endregion

        #region Deact Route


        public string DeactRoute(int RouteId)
        {
            string Result = string.Empty;
            Route delete;

            try
            {
                delete = _trainDb.route.Find(RouteId);


                if (delete != null)
                {
                    //_TicketDb.TicketsDb.Remove(delete);
                    delete.isActive = false;
                    _trainDb.SaveChanges();
                    Result = "200";
                }
            }
            catch (Exception ex)
            {
                Result = "400";
            }
            finally
            {
                delete = null;
            }
            return Result;
        }
        #endregion
    }
}