using System;

namespace ProEventos.API.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Adress { get; set; }
        public DateTime Date { get; set; }   
        public string Theme { get; set; }
        public int Capacity { get; set; }
        public string Block { get; set; }
        public string ImageUrl { get; set; }
        

    }
}