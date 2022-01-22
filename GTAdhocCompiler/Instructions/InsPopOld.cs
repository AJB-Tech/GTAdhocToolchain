﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTAdhocCompiler.Instructions
{
    /// <summary>
    /// Pops 1 pointer off the stack.
    /// </summary>
    public class InsPopOld : InstructionBase
    {
        public readonly static InsPopOld Default = new();

        public override AdhocInstructionType InstructionType => AdhocInstructionType.POP_OLD;

        public override string InstructionName => "POP_OLD";
    }
}