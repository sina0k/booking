using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Booking1.Domain.Model
{
    public class Show
    {
        

        private string title;
        private DateTime startTime;
        private DateTime endTime;
        private string summary;
        private float price;
        private int id;
        private int salonId;
        private Salon salon;


        public Show(string title, DateTime startTime, DateTime endTime, string summary, float price, int id, int salonId, Salon salon)
        {
            this.title = title;
            this.startTime = startTime;
            this.endTime = endTime;
            this.summary = summary;
            this.price = price;
            this.id = id;
            this.salonId = salonId;
            this.salon = salon;
        }


        public string Title
        {
            get => title;
            set => title = value;
        }

        public DateTime StartTime
        {
            get => startTime;
            set => startTime = value;
        }

        public DateTime EndTime
        {
            get => endTime;
            set => endTime = value;
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
            get => salonId;
            set => salonId = value;
        }

        public Salon Salon
        {
            get => salon;
            set => salon = value;
        }
    }
}