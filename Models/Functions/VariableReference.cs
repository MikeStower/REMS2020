﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Functions
{
    public class VariableReference : Node
    {
        public string VariableName { get; set; } = default;

        public VariableReference()
        { }
    }
}