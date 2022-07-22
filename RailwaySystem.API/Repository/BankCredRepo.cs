using Microsoft.EntityFrameworkCore;
using RailwaySystem.API.Data;
using RailwaySystem.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RailwaySystem.API.Repository
{
    public class BankCredRepo : IBankCredRepo
    {
        private TrainDbContext _trainDb;

        public BankCredRepo(TrainDbContext trainDb)
        {
            _trainDb = trainDb;
        }

        #region GetAllBankCred
        public List<BankCred> GetAllBankCreds()
        {
            List<BankCred> bankcred = null;
            try
            {
                bankcred = _trainDb.bankcred.ToList();

            }
            catch (Exception ex)
            {

            }
            return bankcred;
        }
        #endregion


        #region GetBankCred
        public BankCred GetBankCred(int BankCredId)
        {
            BankCred bankcred = null;
            try
            {
                bankcred = _trainDb.bankcred.Find(BankCredId);
            }
            catch (Exception ex)
            {

            }
            return bankcred;
        }
        #endregion

        #region SaveBankCred
        public string SaveBankCred(BankCred bankcred)
        {
            try
            {
                _trainDb.bankcred.Add(bankcred);
                _trainDb.SaveChanges();
            }
            catch (Exception ex)
            {

            }

            return "Saved";
        }
        #endregion

        #region UpdateBankCred
        public string UpdateBankCred(BankCred bankcred)
        {
            try
            {
                _trainDb.Entry(bankcred).State = EntityState.Modified;
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
