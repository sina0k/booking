using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Model
{
    public class Seat
    {
        public int Id { get; set; }
        public int SalonId { get; set; }
        public Salon Salon { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public IList<Ticket> Tickets { get; set; } = new List<Ticket>();
        public Seat(int id, int salonId, int x, int y)
        {
            this.Id = id;
            this.SalonId = salonId;
            this.X = x;
            this.Y = y;
        }
    }
}