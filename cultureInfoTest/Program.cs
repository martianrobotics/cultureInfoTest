using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace cultureInfoTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime d = new DateTime(2014, 7, 21);
            DateTime d = DateTime.Now;
            //CultureInfo provider = new CultureInfo("en-US");
            //CultureInfo cultureProvider = new CultureInfo("en-US");

            CultureInfo provider = CultureInfo.CurrentCulture;
            Console.WriteLine(d.ToString("d", provider)); // 7/21/2014
            Console.WriteLine(d.ToString("D", provider)); // Monday, July 21, 2014
            Console.WriteLine(d.ToString("M", provider)); // July 21
            Console.WriteLine(d.ToString("m", provider)); // July 21
            Console.WriteLine(d.ToString("y", provider)); // July, 2014
            Console.WriteLine(d.ToString("dd", provider)); // 21
            Console.WriteLine(d.ToString("MM", provider)); // 07
            Console.WriteLine(d.ToString("yy", provider)); // 14
            Console.WriteLine(d.ToString("yyyy", provider)); // 2014
            Console.WriteLine(d.ToString("MMMM", provider)); // July 
            Console.ReadKey();
        }
    }
}
