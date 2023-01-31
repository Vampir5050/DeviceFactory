﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceFactory
{
    public class Consol : IConsole
    {
        public string Name { get ; set; }
        public string Model { get ; set; }
        public string Body { get; set ; }
        public bool IsDefective { get ; set; }
        public bool IsTested { get; set; }
    }
}