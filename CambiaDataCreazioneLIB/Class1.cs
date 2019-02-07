using System;
using System.IO;

namespace CambiaDataCreazioneLIB
{
    public class Lib
    {

        static void SetCreationTime(FileSystemInfo fsi, DateTime creationTime)
        {
            fsi.CreationTime = creationTime;
        }

        public static void changeFileDate(string metodo, string path, string data)
        {
            DateTime time = DateTime.Now;
            //try
            //{
                time = DateTime.Parse(data);
            //}
            //catch (Exception e)
            //{
                //showParameters();
                //System.Environment.Exit(-1);
            //}

            if (metodo == "CD")
            {
                File.SetCreationTime(path, time);
                //var fsi = new FileInfo(path);
                //SetCreationTime(fsi, time);
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
            if (metodo != "ALL" && metodo != "CD" && metodo != "LW" && metodo != "LA")
            {
                throw new Exception("Errore nei parametri");
                //showParameters();
                //System.Environment.Exit(-1);
            }
        }
    }
}
