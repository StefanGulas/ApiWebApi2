using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiWebApi2.Models
{
    public class Document
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Größe { get; set; }
        public string Typ { get; set; }
        public DateTime ZeitpunktDesHochladens { get; set; }
    }
}