using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Gameboy_Emulator
{
    internal class MemoryMap
    {
        private byte[] memory = new byte[0xFFFF];

        public static readonly ushort progStart = 0x150;

        public ReadOnlySpan<byte> GetInstruction(ushort address)
        {
            Span<byte> instructions = memory.AsSpan(progStart);

            Span<byte> instruction = instructions.Slice(address, 1);

            return instruction;
        }
    }
}
