using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace csharp_bibliotecaMvc.Models
{
    public class Autore
    {
        public int AutoreID { get; set; }
        public string Nome { get; set; }
        public int Scaffale { get; set; }
        public StatoLibro Stato { get; set; }
        public ICollection<Prestito> Prestiti { get; set; }
        public ICollection<Autore> Autori { get; set; }
    }
}
