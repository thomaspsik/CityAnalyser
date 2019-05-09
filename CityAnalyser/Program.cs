using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityAnalyser
{
    class QueryResult
    {
        internal int count;
        internal int sum;
    }

    class Program
    {
        static List<Crossroad> crossroads = CityGenerator.generateCrossroads();

        private static QueryResult queryCountPSSum(string streetInput, string colorInput)
        {
            QueryResult retValue = new QueryResult();
            retValue.count = 0;
            retValue.sum = 0;
            
            // code here ...
            // code here ...
            // code here ...
            // code here ...
            // code here ...


            return retValue;

        }

        static void Main(string[] args)
        {

            foreach (Crossroad cr in crossroads)
            {
                Console.WriteLine(cr);
            }

            while (true)
            {
                Console.WriteLine("Geben Sie eine Strasse, Farbe ein:");
                String streetInput = Console.ReadLine();
                Console.WriteLine("Geben Sie eine Farbe ein:");
                String colorInput = Console.ReadLine();

                QueryResult qr = queryCountPSSum(streetInput, colorInput);

                Console.WriteLine($"In der {streetInput} stehen {qr.count} Autos mit der Farbe {colorInput} und haben zusammen {qr.sum}PS");
            }
        }


    }
}
