using System.ComponentModel.DataAnnotations.Schema;

namespace Booking1.Domain.Model
{
    public class Seat
    {
        private int id;
        [ForeignKey("Salon    ")]
        private int salon_id;
        private int x_coordinate;
        private int y_coordinate;
        private Salon salon;


        public Seat(int id, int salonId, int xCoordinate, int yCoordinate, Salon salon)
        {
            this.id = id;
            salon_id = salonId;
            x_coordinate = xCoordinate;
            y_coordinate = yCoordinate;
            this.salon = salon;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public int SalonId
        {
            get => salon_id;
            set => salon_id = value;
        }

        public int XCoordinate
        {
            get => x_coordinate;
            set => x_coordinate = value;
        }

        public int YCoordinate
        {
            get => y_coordinate;
            set => y_coordinate = value;
        }

        public Salon Salon
        {
            get => salon;
            set => salon = value;
        }
    }
}