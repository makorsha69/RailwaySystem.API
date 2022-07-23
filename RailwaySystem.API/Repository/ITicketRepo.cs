using RailwaySystem.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RailwaySystem.API.Repository
{
    public interface ITicketRepo
    {
        public string SaveTicket(Tickets ticket);
        public string UpdateTicket(Tickets ticket);
        public string DeactTicket(int TicketId);
        Tickets GetTicket(int TicketId);
        List<Tickets> GetAllTickets();
    }
}