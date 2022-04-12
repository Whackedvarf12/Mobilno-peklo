using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCvaja.Models
{
    public class Izpit
    {
        public DateTime Datum { get; set; }

        public int Id { get; set; }

        public int Ocena { get; set; }

        public Predmet Predmet { get; set; }

        public int PredmetId { get; set; }

        public Student Student { get; set; }

        public int StudentId { get; set; }
    }
}