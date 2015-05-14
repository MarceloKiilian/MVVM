using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoringRetrievingSerlizing
{
    public class Car
    {
        public int id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        private List<Car> buildObjectGraph()
        {
            var myCars = new List<Car>();

            myCars.Add(new Car()
                {
                    id = 1,
                    Make = "Oldsmobile",
                    Model = "Cutlas Supreme",
                    Year = 1985
                });

            myCars.Add(new Car() { id = 2, Make = "Geo", Model = "Prism", Year = 1993 });
            myCars.Add(new Car() { id = 3, Make = "Ford", Model = "Escape", Year = 2005 });

            return myCars;
        }
    }


}
