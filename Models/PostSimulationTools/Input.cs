﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.PostSimulationTools
{
    public class Input : ApsimNode
    {
        public string FileName { get; set; } = default;

        public Input()
        { }
    }
}
