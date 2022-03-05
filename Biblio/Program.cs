using subbiblio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio
{
    internal class Ovning2
    {
        // statisk metod som innehar välkomst till bibliotek
            public static void Welcome()
            {
                Console.WriteLine("Hej och välkommen till biblioteket! ");
                Console.WriteLine(
                 "skapa författare och" +
                 " tillhörande bok," +
                 " ange title sedan författare\n");

            }
        // statisk metod som innehar menyval
            public static void Menu()
            {
                Console.WriteLine("1) Add boks" +
                    "\n================");
                Console.WriteLine("2) Display all books" +
                    "\n================");
                Console.WriteLine("3) Search for books" +
                    "\n================");
                Console.WriteLine("4) Delete books" +
                    "\n================");
                Console.WriteLine("5) End program" +
                    "\n================");
            }
    }
        internal class Program1
        {

            public static void Main(string[] args)
            {
            // Lista-bokhyllan
                Bibliotekarie bibliotek = new Bibliotekarie();

                Console.Clear();
            // välkomst metod
                Ovning2.Welcome();

                bool spela = true;
                while (spela)
                {
                // menyvals-metod
                    Ovning2.Menu();
                    // TryParse förhindrar körtidsfel & att programmet kraschar.(Undantagshantering)
                    if (Int32.TryParse(Console.ReadLine(), out int value))
                    {
                        // inne i en while loop
                        switch (value)
                        {
                            case 1://Skapa Bok
                                Console.Clear();
                                bibliotek.CreateBook();
                                break;
                            case 2: // skriver ut böcker
                                Console.Clear();
                                bibliotek.GetBooklist();
                                break;
                            case 3:// Sök bland böcker!!
                                Console.Clear();
                                bibliotek.SearchBook();
                                break;
                            case 4: //Raderar bokhyllan
                                Console.Clear();
                                bibliotek.RemoveList();
                                Console.WriteLine("Raderat");
                                break;
                            case 5: //Avsluta Programmet
                                Console.Clear();
                                Console.WriteLine("Avslutar programmet");
                                spela = false;
                                break;
                            default:
                                Console.WriteLine("Fel, försök igen");
                                break;
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Fel! Försök igen");
                    }
                }
            }
        }
    
}
