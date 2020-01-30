using System.ComponentModel.DataAnnotations.Schema;

namespace Booking1.Domain.Model
{
    public class Seat
    {
        private int id;
        private int salonId;
        private int xCoordinate;
        private int yCoordinate;
        private Salon salon;


        public Seat(int id, int salonId, int xCoordinate, int yCoordinate, Salon salon)
        {
            this.id = id;
            this.salonId = salonId;
            this.xCoordinate = xCoordinate;
            this.yCoordinate = yCoordinate;
            this.salon = salon;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public int SalonId
        {
            get => salonId;
            set => salonId = value;
        }

        public int XCoordinate
        {
            get => xCoordinate;
            set => xCoordinate = value;
        }

        public int YCoordinate
        {
            get => yCoordinate;
            set => yCoordinate = value;
        }

        public Salon Salon
        {
            get => salon;
            set => salon = value;
        }
    }
}