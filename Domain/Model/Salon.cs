using System.Collections;
using System.Collections.Generic;

namespace Booking1.Domain.Model
{
    public class Salon
    {
        private string name;
        private int id;
        private int seatWidth;
        private int seatHeight;
      

       

        public Salon(string name, int id, int seatWidth, int seatHeight)
        {
            this.name = name;
            this.id = id;
            this.seatWidth = seatWidth;
            this.seatHeight = seatHeight;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public int SeatWidth
        {
            get => seatWidth;
            set => seatWidth = value;
        }

        public int SeatHeight
        {
            get => seatHeight;
            set => seatHeight = value;
        }

    }
}