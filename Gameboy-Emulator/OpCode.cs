using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gameboy_Emulator
{
    public enum OpCodeParameter
    {
        Register,
        RegisterPrime,
        QQ0,
        DD0,
        SS1
    }

    public enum RegisterPairDD
    {
        BC = 00,
        DE = 01,
        HL = 10,
        SP = 11
    }

    public enum RegisterPairSS
    {
        BC = 00,
        DE = 01,
        HL = 10,
        SP = 11
    }

    public enum RegisterPairQQ
    {
        BC = 00,
        DE = 01,
        HL = 10,
        AF = 11
    }

    public enum Register
    {
        A = 0b111,
        B = 0b000,
        C = 0b001,
        D = 0b010,
        E = 0b011,
        H = 0b100,
        L = 0b101
    }
    internal struct OpCode
    {
        uint header;
        uint middle;
        uint end;
        public OpCode(uint opCode)
        {
            opCode &= 0xFF;
            header = opCode >> 6;
            middle = opCode & 0xFF; // garbage
            end = opCode & 0xFF; //garbage, fix logic
        }
    }
    enum OpCodes
    {

    }
}
