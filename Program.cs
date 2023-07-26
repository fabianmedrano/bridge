using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge
{
    internal class Program
    {

        /*
         on a graphics application that needs to support multiple rendering engines. 
        Instead of hardcoding the rendering engine into the application, 
        the developer could use the Bridge pattern to create an abstraction for the rendering engine.
        This would allow them to easily switch between different rendering engines 
        without having to change the code that uses the rendering engine.

         when working on a cross-platform application. In this case, 
        the developer could use the Bridge pattern to create an abstraction for 
        platform-specific features, such as file system access or network communication.
         */
        static void Main(string[] args)
        {
            Car car = new Car();
            Boat boat = new Boat();

            car.Color = new Red();
            car.Color.ChangeColor(car);

            boat.Color = new Blue();
            boat.Color.ChangeColor(boat);

            car.Move();
            boat.Move();
            Console.ReadLine();
        }
    }
}
