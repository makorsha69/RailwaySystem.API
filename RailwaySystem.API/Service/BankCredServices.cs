using RailwaySystem.API.Model;
using RailwaySystem.API.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RailwaySystem.API.Service
{
    public class BankCredServices
    {
        private IBankCredRepo _bankcredRepository;
        public BankCredServices(IBankCredRepo bankcredRepository)
        {
            _bankcredRepository = bankcredRepository;
        }
        public string SaveBankCred(BankCred Seat)
        {
            return _bankcredRepository.SaveBankCred(Seat);
        }
        public string UpdateBankCred(BankCred seat)
        {
            return _bankcredRepository.UpdateBankCred(seat);
        }
        public BankCred GetBankCred(int BankCredId)
        {
            return _bankcredRepository.GetBankCred(BankCredId);
        }
        public List<BankCred> GetAllBankCreds()
        {
            return _bankcredRepository.GetAllBankCreds();
        }
    }
}
