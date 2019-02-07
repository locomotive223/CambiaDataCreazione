using System;
using System.IO;
using static CambiaDataCreazioneLIB.Lib;

namespace CambiaDataCreazione
{
    public class Program
    {
        static void showParameters()
        {
            Console.WriteLine("Uso: CambiaDataCreazione  {CD/LW/LA/ALL} nomeFile mm/dd/yyyy");
            Console.WriteLine("");
            Console.WriteLine("CD cambia creation date - data creazione");
            Console.WriteLine("LW cambia last write time - data ultima modifica");
            Console.WriteLine("LA cambia access time - data ultimo accesso");
            Console.WriteLine("ALL cambia tutte le date");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("File non trovato o errore nei parametri");
        }
        static void Main(string[] args)
        {
            if (args.Length < 3)
            {
                showParameters();
            }

            try
            {
                string metodo = args[0];
                string path = args[1];
                string data = args[2];
                changeFileDate(metodo, path, data);
            }
            catch (Exception e)
            {
                showParameters();
            }








        }
        
    }
}
