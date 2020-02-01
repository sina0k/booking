using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace Domain.Model
{
    public class Show
    {
        public string Title { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Summary { get; set; }
        public float Price { get; set; }
        public int Id { get; set; }
        public int SalonId { get; set; }
        public Salon Salon { get; set; }
        public IList<Seat> Seats { get; set; }

        public Show(string title, DateTime startTime, DateTime endTime, string summary, float price, int id,
            int salonId)
        {
            this.Title = title;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Summary = summary;
            this.Price = price;
            this.Id = id;
            this.SalonId = salonId;
        }
    }
}