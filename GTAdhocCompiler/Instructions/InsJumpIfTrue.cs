﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTAdhocCompiler.Instructions
{
    /// <summary>
    /// Represents a jump to instruction if true instruction. Mostly used for switch cases.
    /// </summary>
    public class InsJumpIfTrue : InstructionBase
    {
        public override AdhocInstructionType InstructionType => AdhocInstructionType.JUMP_IF_TRUE;

        public override string InstructionName => "JUMP_IF_TRUE";

        public int JumpIndex { get; set; }
    }
}
