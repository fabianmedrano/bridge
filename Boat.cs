﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge
{
    public class Boat : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("moving a boat");
        }
    }
}
