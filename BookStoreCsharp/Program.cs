using System;

namespace BookStoreCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string titolo = "Clean Code";
            string autore = "Robert C. “Uncle Bob” Martin";
            long isbn = 9780132350884;
            int numeroPagine = 431;
            double pesoLibro = 0.660;
            double larghezzaLibro = 17.91;
            double altezzaLibro = 23.5;
            double profonditalibro = 2.54;
            double valutazioneMedia = 4.7;
            int numeroRecensioni = 3307;
            string versioneKindle = "Si";
            string copertinaFlessibile = "Si";

            Console.WriteLine("Il libro di oggi: " + titolo + " di " + autore);
            Console.WriteLine("Informazioni generiche:");
            Console.WriteLine("ISBN: " + isbn);
            Console.WriteLine("Numero delle pagine: " + numeroPagine + " pagine");
            Console.WriteLine("Peso del libro:: " + pesoLibro + "Kg");
            Console.WriteLine("Dimensioni del libro: " + altezzaLibro + "cm x " + larghezzaLibro + "cm x " + profonditalibro + "cm");
            Console.WriteLine("Informazioni Amazon:");
            Console.WriteLine("Numero di recensioni: " + numeroRecensioni + " recensioni");
            Console.WriteLine("Valutazione media: " + valutazioneMedia + "☆");
            Console.WriteLine("Kindle disponibile: " + versioneKindle);
            Console.WriteLine("Copertina flessibile disponibile: " + copertinaFlessibile);

        }
    }
}
