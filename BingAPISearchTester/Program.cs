using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BingAPISearch;

namespace BingAPISearchTester
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Bing.WebResult> results = null;
            BingAPISearch.BingAPISearch bas = new BingAPISearch.BingAPISearch();

            //bas.Search(@"""5-HTP"" AND active AND inactive AND ingredient");
            results = bas.Search(@"""A-25"" AND active AND inactive AND ingredient");
        }
    }
}
