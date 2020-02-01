using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Model
{
    public class Ticket
    {
        public int UserId { get; set; }
        public int ShowId{ get; set; }
        public int SeatId{ get; set; }
        public Seat Seat{ get; set; }
        public Show Show{ get; set; }

        public Ticket(int userId, int showId, int seatId)
        {
            this.UserId= userId;
            this.ShowId = showId;
            this.SeatId = seatId;
        }


    }
}