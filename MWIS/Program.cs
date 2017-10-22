using System;
using System.IO;
using MWISMakerLib;

namespace MWIS
{
    class Program
    {
        static void Main(string[] args)
        {
            var mwisMaker = new MWISMaker();
            string line;
            using (var reader = new StreamReader("mwis.txt"))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    mwisMaker.AddVertex(int.Parse(line));
                }
            }
            mwisMaker.Execute();
            foreach (var i in mwisMaker.MWIS)
            {
                Console.WriteLine(i + 1);
            }
            Console.ReadKey();
        }
    }
}
