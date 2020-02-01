using System.Collections;
using System.Collections.Generic;

namespace Domain.Model
{
    public class Salon
    {
        public string Name { get; set; }
        public int Id{ get; set; }
        public int SeatWidth{ get; set; }
        public int SeatHeight{ get; set; }
        public IList<Show> Shows { get; set; } = new List<Show>();
        public IList<Seat> Seats { get; set; } = new List<Seat>();

        public Salon(string name, int id, int seatWidth, int seatHeight)
        {
            this.Name = name;
            this.Id = id;
            this.SeatWidth = seatWidth;
            this.SeatHeight = seatHeight;
        }
    }
}