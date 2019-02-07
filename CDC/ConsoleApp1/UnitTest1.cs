using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using static CambiaDataCreazione.Program;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFileReadAndWrite()
        {
            string path = @"Example.txt";
            createFile(path);
            
   
            var a = File.GetCreationTime(path);
            Assert.AreEqual(a.Date, System.DateTime.Now.Date);

            File.Delete(path);

        }

        [TestMethod]
        public void TestCD()
        {

            string metodo = "CD";
            string data = "12/25/1900"; // mm/dd/yyyy
            var my_data = System.DateTime.Parse(data);

            string path = @"Example.txt";
            createFile(path);

            var original_date = File.GetCreationTime(path);
            changeFileDate(metodo, path, data);
            Assert.AreNotEqual(original_date.Date, my_data.Date);
            var modified_date = File.GetCreationTime(path);
            Assert.AreEqual(modified_date.Date, my_data.Date);

            File.Delete(path);

        }

        [TestMethod]
        public void TestLW()
        {

            string metodo = "LW";
            string data = "12/25/1900"; // mm/dd/yyyy
            var my_data = System.DateTime.Parse(data);

            string path = @"Example.txt";
            createFile(path);

            var original_date = File.GetLastWriteTime(path);
            changeFileDate(metodo, path, data);
            Assert.AreNotEqual(original_date.Date, my_data.Date);
            var modified_date = File.GetLastWriteTime(path);
            Assert.AreEqual(modified_date, my_data.Date);

            File.Delete(path);

        }

        [TestMethod]
        public void TestLA()
        {

            string metodo = "LA";
            string data = "12/25/1900"; // mm/dd/yyyy
            var my_data = System.DateTime.Parse(data);

            string path = @"Example.txt";
            createFile(path);

            var original_date = File.GetLastAccessTime(path);
            changeFileDate(metodo, path, data);
            Assert.AreNotEqual(original_date.Date, my_data.Date);
            var modified_date = File.GetLastAccessTime(path);
            Assert.AreEqual(modified_date, my_data.Date);

            File.Delete(path);

        }

        [TestMethod]
        public void TestALL()
        {

            string metodo = "ALL";
            string data = "12/25/1900"; // mm/dd/yyyy
            var my_data = System.DateTime.Parse(data);

            string path = @"Example.txt";
            createFile(path);

            var original_CD_date = File.GetCreationTime(path);
            var original_LW_date = File.GetLastWriteTime(path);
            var original_LA_date = File.GetLastAccessTime(path);

            changeFileDate(metodo, path, data);

            var modified_CD_date = File.GetCreationTime(path);
            var modified_LW_date = File.GetLastWriteTime(path);
            var modified_LA_date = File.GetLastAccessTime(path);

            Assert.AreEqual(modified_CD_date, my_data.Date);
            Assert.AreEqual(modified_LW_date, my_data.Date);
            Assert.AreEqual(modified_LA_date, my_data.Date);
            File.Delete(path);

        }

        private static void createFile(string path)
        {
            if (!File.Exists(path))
            {
                File.Delete(path);

            }
            File.Create(path).Dispose();
            using (StreamWriter sr = new StreamWriter(path, false))
            {
                sr.WriteLine("The very first line!");
            }
        }
    }
}
