namespace csharp_bibliotecaMvc.Models
{
    public class Prestito
    {
        public int PrestitoID { get; set; }
        public int LibroID { get; set; }
        public int UtenteID { get; set; }
        public StatoLibro Stato { get; set; }
        public Libro Libro { get; set; }
        public Utente Utente { get; set; }
    }
}
