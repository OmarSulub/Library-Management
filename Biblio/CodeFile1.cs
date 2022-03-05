using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subbiblio
{
    // Basklass
    public class Bok
    {
        // Egenskap
        public string titel;
        public string forfattare;
        public string typ;
        public int isbn;
        public int utgivning;
        // metod
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
    // underklass
    public class Novell : Bok
    {
        public Novell(string titel, string forfattare, int isbn, int utgivning)
            : base(titel, forfattare, " är en (Novell) ", isbn, utgivning)
        {
        }
        public override string ToString()
        {
            return "Boken: " + titel +
                "\nAv " + forfattare +
                typ + "\nmed ISBN:nr :" + isbn
                + "\nutgivningsår :" + utgivning +  "\nfinns i novellhyllan";
        }
    }
    // Underklass
    public class Roman : Bok
    {
        public Roman(string titel, string forfattare, int isbn, int utgivning)
            : base(titel, forfattare, " är en (Roman) ", isbn, utgivning)
        {
        }
        public override string ToString()
        {
            return "Boken: " + titel +
                "\nAv " + forfattare +
                typ + "\nmed ISBN:nr :" + isbn
                + "\nutgivningsår :" + utgivning + "\nfinns i romanhyllan";
        }

    }
    // Underklass
    public class Tidsskrift : Bok
    {
        public Tidsskrift(string titel, string forfattare, int isbn, int utgivning)
            : base(titel, forfattare, " är en (Tidsskrift) ", isbn, utgivning)
        {
        }
        public override string ToString()
        {
            return "Boken: "+ titel+
                "\nAv " + forfattare +
                typ +"\nmed ISBN:nr :"+  isbn
                +"\nutgivningsår :"+ utgivning +"\nfinns i tidningshyllan";
        }

    }
    public class Bibliotekarie
    {
        // Lista
        private List<Bok> bokLista;
        // konstruktor
        public Bibliotekarie()
        {
            bokLista = new List<Bok>();
        }
        // klassens Metoder 
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
        public void GetBooklist()
        {
            foreach (Bok bok in bokLista)
            {
                Console.WriteLine(bok);
            }
        }
        public void SearchBook()
        {
            Console.WriteLine("sök genom att ange utgivnings År:" + "\nmax ett sökord!");
            string söknr = Console.ReadLine();
            int key = Convert.ToInt32(söknr);
            foreach (Bok bok in bokLista)
            {
                if (bok.utgivning == key)
                {
                    Console.WriteLine("din sökning: " + bok.titel 
                        + "\nAv " + bok.forfattare
                        + bok.typ + "\nmed ISBN:nr :" + bok.isbn 
                        + "\nutgivningsår :" + bok.utgivning + "\nfinns i tidningshyllan");
                }
                else
                {
                    Console.WriteLine("Fel. Försök igen!");
                }
            }
        }
        public void RemoveList()
        {
            bokLista.Clear();
        }
        
    }
}
