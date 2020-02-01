using System.ComponentModel.DataAnnotations.Schema;

namespace Booking1.Domain.Model
{
    public class Ticket
    {
        private int userID;
        private int showId;
        private int seatId;
        private Seat seat;
        private Show show;


        public Ticket(int userId, int showId, int seatId, Seat seat, Show show)
        {
            userID = userId;
            this.showId = showId;
            this.seatId = seatId;
            this.seat = seat;
            this.show = show;
        }


        public int UserId
        {
            get => userID;
            set => userID = value;
        }

        public int ShowId
        {
            get => showId;
            set => showId = value;
        }

        public int SeatId
        {
            get => seatId;
            set => seatId = value;
        }

        public Seat Seat
        {
            get => seat;
            set => seat = value;
        }

        public Show Show
        {
            get => show;
            set => show = value;
        }
    }
}