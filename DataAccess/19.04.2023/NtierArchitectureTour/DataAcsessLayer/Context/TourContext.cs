using DataAcsessLayer.Entity;
using DataAcsessLayer.Options;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataAcsessLayer.Context
{
    public class TourContext:DbContext
    {
        public TourContext() : base("MyConnection") 
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new GuideMap());
            modelBuilder.Configurations.Add(new PaymentMap());
            modelBuilder.Configurations.Add(new ReservationMap());
            modelBuilder.Configurations.Add(new TourLocationMap());
            modelBuilder.Configurations.Add(new TourMap());
            modelBuilder.Configurations.Add(new TourTypeMap());
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Guide> Guides { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<TourLocation> TourLocations { get; set; }
        public DbSet<Tour> Tours { get; set; }
        public DbSet<TourType> TourTypes { get; set; }
    }
}
