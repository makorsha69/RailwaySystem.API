using RailwaySystem.API.Model;
using RailwaySystem.API.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RailwaySystem.API.Services
{
    public class SeatServices
    {
        private ISeatRepo _seatRepository;
        public SeatServices(ISeatRepo seatRepository)
        {
            _seatRepository = seatRepository;
        }
        public string SaveSeat(Seat Seat)
        {
            return _seatRepository.SaveSeat(Seat);
        }
        public string UpdateSeat(Seat seat)
        {
            return _seatRepository.UpdateSeat(seat);
        }
        public Seat GetSeat(int SeatId)
        {
            return _seatRepository.GetSeat(SeatId);
        }
        public List<Seat> GetAllSeats()
        {
            return _seatRepository.GetAllSeats();
        }
    }
}