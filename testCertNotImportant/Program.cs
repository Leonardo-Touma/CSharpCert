using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testCertNotImportant
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Test> tests = new List<Test>();
            var hej = tests.Where(x => x.Equals(2)).FirstOrDefault();
            Console.WriteLine(hej);
            Console.ReadKey();
        }
    }
    [Serializable]public enum Test:short
    {
        test = 0,hej = 1,nej = 2
    }
}
