﻿using RailwaySystem.API.Data;
using RailwaySystem.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RailwaySystem.API.Repository
{
    public class PassengerRepo : IPassengerRepo
    {
        private TrainDbContext trainDb;
        public PassengerRepo(TrainDbContext _trainDb)
        {
            trainDb = _trainDb;
        }
        public Passenger AddPassenger(Passenger passenger)
        {
            string stCode = string.Empty;
            try
            {
                trainDb.passenger.Add(passenger);
                trainDb.SaveChanges();

                stCode = "200";
            }
            catch (Exception ex)
            {
                //return ex.Message;
                stCode = "400";
            }
            return passenger;
        }

        public string DeletePassenger(int PassengerId)
        {

            string Result = string.Empty;
            Passenger delete;

            try
            {
                delete = trainDb.passenger.Find(PassengerId);

                if (delete != null)
                {
                    trainDb.passenger.Remove(delete);

                    trainDb.SaveChanges();
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

        public List<Passenger> GetAllPassengers()
        {

            List<Passenger> passenger = null;
            try
            {
                passenger = trainDb.passenger.ToList();
                return passenger;

            }
            catch (Exception ex)
            {

            }
            return passenger;
        }

        public Passenger GetPassenger(int PassengerId)
        {
            Passenger passenger = null;
            try
            {
                passenger = trainDb.passenger.Find(PassengerId);
                return passenger;
            }
            catch (Exception ex)
            {

            }
            return passenger;
        }

        public Passenger UpdatePassenger(int PassengerId, Passenger passenger)
        {

            var passengers = trainDb.passenger.FirstOrDefault(q => q.PassengerId == PassengerId);
            try
            {
                if (passengers != null)
                {
                    passengers.PName = passenger.PName;
                    passengers.Age = passenger.Age;
                    passengers.gender = passenger.gender;

                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return passengers;
        }
    }
}