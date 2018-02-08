using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tere! Valige kes te olete." +
                "\n1 - nooremarendajad " +
                "\n2 - vanemarendajad" +
                "\n3 - koristajad" +
                "\n4 - ulemused" +
                "\n5 - andmetöötlejad");
            int UserChoise = Int32.Parse(Console.ReadLine());
            switch (UserChoise)
            {
                case 1:
                    var nooremarendajad = new Nooremarendajad();
                    break;
                case 2:
                    var vanemarendajad = new Vanemarendajad();
                    break;
                case 3:
                    var koristajad = new Koristajad();
                    break;
                case 4:
                    var ulemused = new Ulemused();
                    break;
                case 5:
                    var andmetootlejad = new andmetootlejad();
                    break;
            }
            Console.WriteLine("Kuhu ruumi te soovite minna?" +
                "\n1 - andmetöötlejate ruum" +
                "\n2 - arendajate ruum" +
                "\n3 - köök" +
                "\n4 - ülemuste ruum");
            int UserChoise2 = Int32.Parse(Console.ReadLine());
            switch (UserChoise2)
            {
                case 1:
                    var andmetootlejate_ruum = new andmetootlejate_ruum();
                    break;
                case 2:
                    var arendajate_ruum = new Arendajate_ruum();
                    break;
                case 3:
                    var kook = new Kook();
                    break;
                case 4:
                    var ulemuste_ruum = new Ulemuste_ruum();
                    break;
            }

        }
    }
}
