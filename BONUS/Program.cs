using System;

namespace BONUS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Definizione variabili
            Console.WriteLine("Inserisci seguenti informazioni libro:");
            Console.Write("Titolo: ");
            string titolo = Console.ReadLine();
            Console.Write("Autore: ");
            string autore = Console.ReadLine();
            Console.Write("ISBN: ");
            long isbn = Convert.ToInt64(Console.ReadLine());
            Console.Write("Numero pagine: ");
            int numeroPagine = Convert.ToInt32(Console.ReadLine());
            Console.Write("Peso (espresso in kg): ");
            double pesoLibro = Convert.ToDouble(Console.ReadLine());
            Console.Write("Larghezza: ");
            double larghezzaLibro = Convert.ToDouble(Console.ReadLine());
            Console.Write("Altezza: ");
            double altezzaLibro = Convert.ToDouble(Console.ReadLine());
            Console.Write("Profondita: ");
            double profonditalibro = Convert.ToDouble(Console.ReadLine());
            Console.Write("Valutazione media: ");
            double valutazioneMedia = Convert.ToDouble(Console.ReadLine());
            Console.Write("Valutazione numero recensioni: ");
            int numeroRecensioni = Convert.ToInt32(Console.ReadLine());
            Console.Write("Versione Kindle (Si o No): ");
            string versioneKindle = Console.ReadLine().ToUpper();
            Console.Write("Copertina flessibile (Si o No): ");
            string copertinaFlessibile = Console.ReadLine().ToUpper();

          


            //Print informazioni acquisite
            Console.WriteLine(" ----------------------------------------- ");
            Console.WriteLine("Il libro di oggi: " + titolo + " di " + autore);
            Console.WriteLine("Informazioni generiche:");
            Console.WriteLine("ISBN: " + isbn);
            Console.WriteLine("Numero delle pagine: " + numeroPagine + " pagine");
            Console.WriteLine("Peso del libro:: " + pesoLibro + "Kg");
            Console.WriteLine("Dimensioni del libro: " + altezzaLibro + "cm x " + larghezzaLibro + "cm x " + profonditalibro + "cm");
            Console.WriteLine("Informazioni Amazon:");
            Console.WriteLine("Numero di recensioni: " + numeroRecensioni + " recensioni");
            Console.WriteLine("Valutazione media: " + valutazioneMedia + "☆");
            if (versioneKindle == "SI")
            {
                Console.WriteLine("Kindle disponibile: Si");
            } else if (versioneKindle == "NO")
            {
                Console.WriteLine("Kindle disponibile: No");
            }else
            {
                Console.WriteLine("Non hai inserito valore accettato");
            }

            if (copertinaFlessibile == "SI")
            {
                Console.WriteLine("Copertina flessibile disponibile: Si");
            }
            else if (copertinaFlessibile == "NO")
            {
                Console.WriteLine("Copertina flessibile disponibile: No");
            }
            else
            {
                Console.WriteLine("Non hai inserito valore accettato");
            }
            
        }
    }
}
