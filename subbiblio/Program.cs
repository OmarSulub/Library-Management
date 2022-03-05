using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subbiblio
{
    public class Bok
    {
        // Egenskap
        private string titel;
        private string forfattare;
        private string typ;
        private int isbn;
        private int utgivning;

        public Bok(string titel, string forfattare, string typ,
                   int isbn, int utgivning)
        {
            this.titel = titel;
            this.forfattare = forfattare;
            this.typ = typ;
            this.isbn = isbn;
            this.utgivning = utgivning;
        }

    }
    public class Novell : Bok
    {
        private string novell;

        public Novell(string titel, string forfattare, int isbn, int utgivning)
            : base(titel, forfattare, "Novell", isbn, utgivning)
        {
        }
        public override string ToString()
        {
            return "Noveller finns i novellhyllan";
        }

    }
    public class Roman : Bok
    {
        private string roman;

        public Roman(string titel, string forfattare, int isbn, int utgivning)
            : base(titel, forfattare, "Roman", isbn, utgivning)
        {
        }
        public override string ToString()
        {
            return "Romaner finns i romanhyllan";
        }

    }
    public class Tidsskrift : Bok
    {
        private string tidsskrift;

        public Tidsskrift(string titel, string forfattare, int isbn, int utgivning)
            : base(titel, forfattare, "Tidsskrift", isbn, utgivning)
        {
        }
        public override string ToString()
        {
            return "Tidsskrifter finns i tidningshyllan";
        }

    }
    public class Bibliotekarie
    {
        private List<Bok> bokLista;
        // klassens Metoder 
        public void GetBooklist()
        {
            List<Bibliotekarie> bib = new List<Bibliotekarie>();
            foreach (Bok bok in bokLista)
            {
                Console.WriteLine(bok);
            }
        }
        public void CreateBook()
        {
            Console.Clear();
            Console.WriteLine("skapa titel");
            string titel = Console.ReadLine();

            Console.WriteLine("skapa författare:");
            string forfattare = Console.ReadLine();

            int isbn = 0;
            bool bokstav = false;
            while (!bokstav)
            {
                Console.Write("skapa ISBN: ");
                bokstav = int.TryParse(Console.ReadLine(), out isbn);
                if (!bokstav)
                    Console.WriteLine("Fel! Försök igen");
            }


            int utgivningsår = 0;
            bokstav = false;
            while (!bokstav)
            {
                Console.Write("skapa Utgivnings år: ");
                bokstav = int.TryParse(Console.ReadLine(), out utgivningsår);
                if (!bokstav)
                    Console.WriteLine("Fel! Försök igen");
            }

            Console.WriteLine("\när boken 1) en Novell, 2) Tidsskrift, 3) Roman ");
            int Displayvalue = Convert.ToInt32(Console.ReadLine());
            if (Displayvalue == 1)
            {
                Console.WriteLine("sparat");
                Bok novellLista = new Novell(titel, forfattare, isbn, utgivningsår);
                bokLista.Add(novellLista);
            }
            else if (Displayvalue == 2)
            {
                Console.WriteLine("sparat");
                Bok tidssskriftsLista = new Tidsskrift(titel, forfattare, isbn, utgivningsår);
                bokLista.Add(tidssskriftsLista);
            }
            else if (Displayvalue == 3)
            {
                Console.WriteLine("sparat");
                Bok romanLista = new Roman(titel, forfattare, isbn, utgivningsår);
                bokLista.Add(romanLista);
            }
            Console.WriteLine(" ");
        }
        public void SearchBook()
        {
            /*
            Console.WriteLine("mata in något att söka efter");
            string key = Console.ReadLine();
            string index = LinjärSökning(, key);
            Console.WriteLine("din sökning " + key + " finns i hylla " + index);
            */
        }
        static int LinjärSökning(List<string> strLista, string key)
        {
            // söker igenom alla element för att se om der går att hitta.
            for (int i = 0; i < strLista.Count; i++)
            {
                if (strLista[i] == key)
                    return i;

            }
            // Listan har gåtts igenom utan lyckad resultat. hittade inget
            return -1;
        }
    }
}
