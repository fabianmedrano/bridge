using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge
{
    public class Red : IColor
    {
        public void ChangeColor(Vehicle vehicle) {
            Console.WriteLine("changing the color of a vehicle to red");        
        }
    }
}
