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
            double pesoLibro = 660;
            double larghezzaLibro = 17.91;
            double altezzaLibro = 23.5;
            double profonditalibro = 2.54;
            double valutazioneMedia = 4.7;
            int numeroRecensioni = 3307;
            string versioneKindle = "Si";
            string copertinaFlessibile = "Si";

            Console.WriteLine("Il libro di oggi: " + titolo + " di " + autore);

        }
    }
}
