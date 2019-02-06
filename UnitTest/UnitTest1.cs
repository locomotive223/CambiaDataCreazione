using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"Example.txt";
            if (!File.Exists(path))
            {
               
                
            }
            else if (File.Exists(path))
            {
                File.Delete(path);
                
                
            }
            File.Create(path);
            TextWriter tw = new StreamWriter(path);
            tw.WriteLine("The very first line!");
            tw.Close();

            var a = File.GetCreationTime(path);
            Assert.AreEqual(a, System.DateTime.Now);
            
        }
    }
}
