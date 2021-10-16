using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviorPatterns.Iterator
{
    public class AutoPark : IEnumerable<Car>
    {
        public List<Car> Cars { get; set; }
        public AutoPark()
        {
            Cars = new List<Car>();
        }
        public void Add(Car car)
        {
            Cars.Add(car);
        }

        public IEnumerator<Car> GetEnumerator()
        {
            foreach(Car car in Cars)
            {
                yield return car;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)Cars).GetEnumerator();
        }
    }
}
