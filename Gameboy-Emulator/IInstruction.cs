using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gameboy_Emulator
{
    internal interface IInstruction
    {
        public string Name { get; }
        public string Shorthand { get; }
        void execute(Registers r);
    }
}
