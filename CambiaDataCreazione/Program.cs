using System;
using System.IO;

namespace CambiaDataCreazione
{
    class Program
    {
        static void console()
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
                console();
            }

            try
            {
                string metodo = args[0];
                string path = args[1];
                string data = args[2];

                DateTime time = DateTime.Parse(data);

                if (metodo == "CD")
                {
                    File.SetCreationTime(path, time);
                }
                if (metodo == "LW")
                {
                    File.SetLastWriteTime(path, time);
                }
                if (metodo == "LA")
                {
                    File.SetLastAccessTime(path, time);
                }
                if (metodo == "ALL")
                {
                    File.SetLastAccessTime(path, time);
                    File.SetCreationTime(path, time);
                    File.SetLastWriteTime(path, time);
                }
            }
            catch (Exception e)
            {
                console();
            }
               

            
            
            

            

        }
    }
}
