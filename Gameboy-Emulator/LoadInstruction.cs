using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gameboy_Emulator
{
    internal class LoadInstruction : IInstruction
    {
        //01 r rprime
        public void execute(Registers registers, ref byte r, byte rPrime)
        {
            r = rPrime;
        }
    }
}
