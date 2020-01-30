using System.Collections;
using System.Collections.Generic;

namespace Booking1.Domain.Model
{
    public class Salon
    {
        private string name;
        private int id;
        private int seat_width;
        private int seat_height;
      

       

        public Salon(string name, int id, int seatWidth, int seatHeight)
        {
            this.name = name;
            this.id = id;
            seat_width = seatWidth;
            seat_height = seatHeight;
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
            get => seat_width;
            set => seat_width = value;
        }

        public int SeatHeight
        {
            get => seat_height;
            set => seat_height = value;
        }

    }
}