using System.ComponentModel.DataAnnotations.Schema;

namespace Booking1.Domain.Model
{
    public class Ticket
    {
        private int user_id;
        [ForeignKey("Show")]
        private int show_id;
        [ForeignKey("Seat")]
        private int seat_id;
        private Seat seat;
        private Show show;


        public Ticket(int userId, int showId, int seatId, Seat seat, Show show)
        {
            user_id = userId;
            show_id = showId;
            seat_id = seatId;
            this.seat = seat;
            this.show = show;
        }


        public int UserId
        {
            get => user_id;
            set => user_id = value;
        }

        public int ShowId
        {
            get => show_id;
            set => show_id = value;
        }

        public int SeatId
        {
            get => seat_id;
            set => seat_id = value;
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