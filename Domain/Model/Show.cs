using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Booking1.Domain.Model
{
    public class Show
    {
        

        private string title;
        private DateTime start_time;
        private DateTime end_time;
        private string summary;
        private float price;
        private int id;
        [ForeignKey("Salon")]
        private int salon_id;
        private Salon salon;


        public Show(string title, DateTime startTime, DateTime endTime, string summary, float price, int id, int salonId, Salon salon)
        {
            this.title = title;
            start_time = startTime;
            end_time = endTime;
            this.summary = summary;
            this.price = price;
            this.id = id;
            salon_id = salonId;
            this.salon = salon;
        }


        public string Title
        {
            get => title;
            set => title = value;
        }

        public DateTime StartTime
        {
            get => start_time;
            set => start_time = value;
        }

        public DateTime EndTime
        {
            get => end_time;
            set => end_time = value;
        }

        public string Summary
        {
            get => summary;
            set => summary = value;
        }

        public float Price
        {
            get => price;
            set => price = value;
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

        public Salon Salon
        {
            get => salon;
            set => salon = value;
        }
    }
}