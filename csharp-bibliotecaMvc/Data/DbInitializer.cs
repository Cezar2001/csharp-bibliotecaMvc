using csharp_bibliotecaMvc.Models;
using System;
using System.Linq;

namespace csharp_bibliotecaMvc.Data
{
    public static class DbInitializer
    {
        public static void Initialize(BibliotecaContext context)
        {
            context.Database.EnsureCreated();

            if (context.Utenti.Any())
            {
                return;   // DB has been seeded
            }

            var Utenti = new Utente[]
            {
            new Utente{Nome="Carson",Cognome="Alexander",PrestitoDate=DateTime.Parse("2005-09-01")},
            new Utente{Nome="Meredith",Cognome="Alonso",PrestitoDate=DateTime.Parse("2002-09-01")},
            new Utente{Nome="Arturo",Cognome="Anand",PrestitoDate=DateTime.Parse("2003-09-01")},
            new Utente{Nome="Gytis",Cognome="Barzdukas",PrestitoDate=DateTime.Parse("2002-09-01")},
            new Utente{Nome="Yan",Cognome="Li",PrestitoDate=DateTime.Parse("2002-09-01")},
            new Utente{Nome="Peggy",Cognome="Justice",PrestitoDate=DateTime.Parse("2001-09-01")},
            new Utente{Nome="Laura",Cognome="Norman",PrestitoDate=DateTime.Parse("2003-09-01")},
            new Utente{Nome="Nino",Cognome="Olivetto",PrestitoDate=DateTime.Parse("2005-09-01")}
            };
            foreach (Utente u in Utenti)
            {
                context.Utenti.Add(u);
            }
            context.SaveChanges();

            var Libri = new Libro[]
            {
            new Libro{LibroID=1050,Titolo="Chemistry",Scaffale=3},
            new Libro{LibroID=4022,Titolo="Microeconomics",Scaffale=3},
            new Libro{LibroID=4041,Titolo="Macroeconomics",Scaffale=3},
            new Libro{LibroID=1045,Titolo="Calculus",Scaffale=4},
            new Libro{LibroID=3141,Titolo="Trigonometry",Scaffale=4},
            new Libro{LibroID=2021,Titolo="Composition",Scaffale=3},
            new Libro{LibroID=2042,Titolo="Literature",Scaffale=4}
            };
            foreach (Libro l in Libri)
            {
                context.Libri.Add(l);
            }
            context.SaveChanges();

            var Prestiti = new Prestito[]
            {
            new Prestito{UtenteID=1,LibroID=1050,Stato=StatoLibro.Disponibile},
            new Prestito{UtenteID=1,LibroID=4022,Stato=StatoLibro.Indisponibile},
            new Prestito{UtenteID=1,LibroID=4041,Stato=StatoLibro.Disponibile},
            new Prestito{UtenteID=2,LibroID=1045,Stato=StatoLibro.Disponibile},
            new Prestito{UtenteID=2,LibroID=3141,Stato=StatoLibro.Indisponibile},
            new Prestito{UtenteID=2,LibroID=2021,Stato=StatoLibro.Indisponibile},
            new Prestito{UtenteID=3,LibroID=1050,Stato=StatoLibro.Disponibile},
            new Prestito{UtenteID=4,LibroID=1050,Stato=StatoLibro.Indisponibile},
            new Prestito{UtenteID=4,LibroID=4022,Stato=StatoLibro.Indisponibile},
            new Prestito{UtenteID=5,LibroID=4041,Stato=StatoLibro.Disponibile},
            new Prestito{UtenteID=6,LibroID=1045,Stato=StatoLibro.Disponibile},
            new Prestito{UtenteID=7,LibroID=3141,Stato=StatoLibro.Disponibile},
            };
            foreach (Prestito p in Prestiti)
            {
                context.Prestiti.Add(p);
            }
            context.SaveChanges();
        }
    }
}
