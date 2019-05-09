using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityAnalyser
{
    class Crossroad
    {
        internal string street1;
        internal string street2;
        internal List<Car> cars;

        public Crossroad(string street1, string street2, List<Car> cars)
        {
            this.street1 = street1;
            this.street2 = street2;
            this.cars = cars;
        }

        public override string ToString()
        {
            string carList = "";
            if (cars != null)
            {
                carList = cars.Count+" - ";
                foreach (Car c in cars)
                {
                    carList += $"({c.id}){c.color}({c.ps}PS),";
                }
            }
            else
            {
                carList = "0";
            }
            return street1 + " x " + street2 + ":" + carList;
        }

    }
}
