﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using вдишп1.Models;

namespace вдишп1.Factory
{
    public class TrainFactory : AbstractFactory
    {
        public override Transport TypeTransport()
        {
            return new Train();
        }
    }
}
