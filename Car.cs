using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge
{
    public class Car :Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("moving a car");
        }
    }
}
