using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gameboy_Emulator
{
    enum InstructionType
    {
        LD_R_R,         // r <- r'              01 r   r'
        LD_R_N,         // r <- n               00 r   110
        LD_R_DerefHL,   // r <- (HL)            01 r   110
        LD_DerefHL_R,   // (HL) <- r            01 110 r
        LD_DerefHL_N,   // (HL) <- n            00 110 110
        LD_A_DerefBC,   // A <- (BC)            00 001 010
        LD_A_DerefDE,   // A <- (DE)            00 011 010
        LD_A_DerefC,    // A <- (0xFF00 + C)    11 110 010
        LD_DerefC_A,    // (0xFF00 + C) <- A    11 100 010
        LD_A_DerefN,    // A <- (FF00 + n)      11 110 000
        LD_DerefN_A,    // (FF00 + n) <- A      11 100 000
        LD_A_DerefNN,   // A <- (nn)            11 111 010
        LD_DerefNN_A,   // (nn) <- A            11 101 010
        LD_A_DerefHLI,  // A <- (HL), HL++      00 101 010
        LD_A_DerefHLD,  // A <- (HL), HL--      00 111 010
        LD_DerefBC_A,   // (BC) <- A            00 000 010
        LD_DerefDE_A,   // (DE) <- A            00 010 010
        LD_DerefHLI_A,  // (HL) <- A, HL++      00 100 010
        LD_DerefHLD_A,  // (HL) <- A, HL--      00 110 010
        LD_DD_NN,       // dd <- nn             00 dd0 001
        LD_SP_HL,       // SP <- HL             11 111 001
    }

    public enum OpCodeParameter
    {
        Bits,
        Register,
        QQ0,
        DD0,
        SS1
    }

    internal struct OpCode
    {
        public byte Header { get; set; }
        public byte Middle { get; set; }
        public byte End { get; set; }
        public OpCode(byte opCode)
        {
            Header = (byte)(opCode >> 6);
            Middle = (byte)((opCode & 0b00111000) >> 3);
            End = (byte)(opCode & 0b00000111);
        }
        public OpCode(byte header, byte middle, byte end)
        {
            Header = header;
            Middle = middle;
            End = end;
        }
    }
}
