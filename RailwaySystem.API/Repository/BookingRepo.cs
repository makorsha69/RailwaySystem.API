using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RailwaySystem.API.Data;
using RailwaySystem.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RailwaySystem.API.Repository
{
    public class BookingRepo : IBookingRepo
    {
        private TrainDbContext _trainDb;
        public BookingRepo(TrainDbContext trainDb)
        {
            _trainDb = trainDb;
        }

        #region DeactivateBookinh

        public string DeactBooking(int BookingId)
        {
            string Result = string.Empty;
            Booking delete = null;
            try
            {
                delete = _trainDb.bookings.Find(BookingId);
                if (delete != null)
                {
                    delete.isActive = false;
                    _trainDb.SaveChanges();
                    Result = "200";
                }

            }
            catch (Exception ex)
            {
                Result = "400";
            }
            return Result;

        }

        #endregion


        #region GetAllBookings

        public List<Booking> GetAllBookings()
        {
            string Result = string.Empty;
            List<Booking> bookings = null;
            try
            {
                bookings = _trainDb.bookings.ToList();

            }
            catch (Exception ex)
            {

            }
            return bookings;
        }

        #endregion


        #region GetBooking

        public Booking GetBooking(int BookingId)
        {
            Booking booking = null;
            try
            {
                booking = _trainDb.bookings.Find(BookingId);
            }
            catch (Exception ex)
            {

            }
            return booking;
        }

        #endregion


        #region SaveBooking

        public string SaveBooking(Booking booking)
        {
            string stCode = string.Empty;
            try
            {
                _trainDb.bookings.Add(booking);
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


        #region UpdateBooking

        public string UpdateBooking(Booking booking)
        {
            string stCode = string.Empty;
            try
            {
                _trainDb.Entry(booking).State = EntityState.Modified;
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


        #region CalculateFare
        public double CalculateFare(int TrainId, string Class, int PassengerId)
        {
            double fare = 0.00;
            var train = _trainDb.trains.Find(TrainId);
            int distance = (int)train.distance;
            if (Class == "FirstAC")
            {
                fare = ((8 * distance) + 250 + 70) * 0.18;
            }
            if (Class == "SecondAC")
            {
                fare = ((6 * distance) + 150 + 50) * 0.18;
            }
            if (Class == "Sleeper")
            {
                fare = ((4 * distance) + 50 + 30) * 0.18;
            }
            Random rnd = new Random();
            int seat = rnd.Next(1, 72);
            _trainDb.bookings.Add(new Booking { TrainId = TrainId, Classes = Class, Status = "Pending", Date = DateTime.Now, PassengerId = PassengerId, SeatNum = seat, fare=fare });
            _trainDb.SaveChanges();
            return fare;
        }

        #endregion


        #region ConfirmBooking
        public Booking ConfirmBooking(int BookingId)
        {
            string Result = string.Empty;
            Booking confirm = null;

            try
            {
                confirm = _trainDb.bookings.Find(BookingId);
                if (confirm != null)
                {
                    confirm.Status = "CONFIRM";
                    _trainDb.transaction.Add(new Transaction { BookingId = BookingId, TransactionStatus = "Success", Fare = confirm.fare });
                    _trainDb.SaveChanges();
                    Result = "200";
                }

            }
            catch (Exception ex)
            {
                Result = "400";
            }
            return confirm;

        }
        #endregion

    }
}