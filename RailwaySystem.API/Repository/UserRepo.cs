using Microsoft.EntityFrameworkCore;
using RailwaySystem.API.Data;
using RailwaySystem.API.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RailwaySystem.API.Repository
{
    public class UserRepo : IUserRepo
    {
        private TrainDbContext _trainDb;

        public UserRepo(TrainDbContext trainDb)
        {
            _trainDb = trainDb;
        }

        #region GetAllUser
        public List<User> GetAllUser()
        {
            List<User> users = null;
            try
            {
                users = _trainDb.users.ToList();
            }
            catch (Exception ex)
            {

            }

            return users;
        }
        #endregion

        #region GetUser


        public User GetUser(int UserId)
        {
            User user = null;
            try
            {
                user = _trainDb.users.Find(UserId);

            }
            catch (Exception ex)
            {

            }
            return user;
        }
        #endregion

        public User GetUserbyName(string Name)
        {
            User user = null;
            try
            {
                user = _trainDb.users.Find(Name);

            }
            catch (Exception ex)
            {

            }
            return user;
        }

        #region SaveUser
        public string SaveUser(User user)
        {
            try
            {
                _trainDb.users.Add(user);

                _trainDb.SaveChanges();
            }
            catch (Exception ex)
            {

            }

            return "Saved";
        }
        #endregion

        #region UpdateUser
        public string UpdateUser(User user)
        {
            try
            {
                _trainDb.Entry(user).State = EntityState.Modified;
                _trainDb.SaveChanges();
            }
            catch (Exception ex)
            {

            }
            return "Updated";
        }
        #endregion
    }
}