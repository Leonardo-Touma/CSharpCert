using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTest
{
    class Program
    {
        static void Main(string[] args)
        {
            books book = new books();
            var query = from b in book.getbooks() select new { b.isbn };
        }
    }
    class books
    {
        List<books> book = new List<books>();
        public int isbn { get; set; }
        public List<books> getbooks()
        {
            return book;
        }
    }
}
