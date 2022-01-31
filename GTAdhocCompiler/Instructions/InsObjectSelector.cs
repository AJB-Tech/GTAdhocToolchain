﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTAdhocCompiler.Instructions
{
    /// <summary>
    /// Unknown. Pops two values from the stack, does something with them and pushes a new value.
    /// </summary>
    public class InsObjectSelector : InstructionBase
    {
        public readonly static InsObjectSelector Default = new();

        public override AdhocInstructionType InstructionType => AdhocInstructionType.OBJECT_SELECTOR;

        public override string InstructionName => "OBJECT_SELECTOR";

        public InsObjectSelector()
        {
            
        }
    }
}