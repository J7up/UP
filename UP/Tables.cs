using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Drawing;

namespace UP
{
    [Table(Name = "Service")]
    public class Service
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int ID { get; set; }
        [Column]
        public string Title { get; set; }
        [Column]
        public decimal Cost { get; set; }
        [Column]
        public int DurationInSeconds { get; set; }
        [Column]
        public string Description { get; set; }
        [Column]
        public double Discount { get; set; }
        [Column]
        public string MainImagePath { get; set; }
        
        public Image Image { get; set; }
    }
    [Table(Name = "Client")]
    public class Client
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int ID { get; set; }
        [Column]
        public string FirstName { get; set; }
        [Column]
        public string LastName { get; set; }
        [Column]
        public string Patronymic { get; set; }
        [Column]
        public DateTime Birthday { get; set; }
        [Column]
        public DateTime RegistrationDate { get; set; }
        [Column]
        public string Email { get; set; }
        [Column]
        public string Phone { get; set; }
        [Column]
        public char GenderCode { get; set; }
        [Column]
        public string PhotoPath { get; set; }

    }
    [Table(Name = "ClientService")]
    public class ClientService
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int ID { get; set; }
        [Column]
        public int ClientID { get; set; }
        [Column]
        public int ServiceID { get; set; }
        [Column]
        public DateTime StartTime { get; set; } 
        [Column]
        public string Comment { get; set; }
    }
}
