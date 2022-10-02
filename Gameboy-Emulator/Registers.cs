using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gameboy_Emulator
{
    internal class Registers
    {
        private byte _A;
        public byte A
        {
            get { return _A; }
            set { _A = value; }
        }

        private byte _F;
        public byte F
        {
            get { return _F; }
            set { _F = value; }
        }


        private byte _B;
        public byte B
        {
            get { return _B; }
            set { _B = value; }
        }

        private byte _C;
        public byte C
        {
            get { return _C; }
            set { _C = value; }
        }


        private byte _D;
        public byte D
        {
            get { return _D; }
            set { _D = value; }
        }

        private byte _E;
        public byte E
        {
            get { return _E; }
            set { _E = value; }
        }


        private byte _H;
        public byte H
        {
            get { return _H; }
            set { _H = value; }
        }

        private byte _L;
        public byte L
        {
            get { return _L; }
            set { _L = value; }
        }

        public ushort PC { get; set; }
        public ushort SP { get; set; }
        
        private ushort getPair(byte high, byte low)
        {
            return (ushort)((low << 8) | high);
        }
        private void setPair(ushort pair, ref byte high, ref byte low)
        {
            high = (byte)(pair);
            low = (byte)(pair >> 8);
        }

        public ushort AF
        {
            get => getPair(A, F);
            set => setPair(value, ref _A, ref _F);
        }
        public ushort BC
        {
            get => getPair(B, C);
            set => setPair(value, ref _B, ref _C);
        }
        public ushort DE
        {
            get => getPair(D, E);
            set => setPair(value, ref _D, ref _E);
        }
        public ushort HL
        {
            get => getPair(H, L);
            set => setPair(value, ref _H, ref _L);
        }

        
        private void setFlag(int bitIndex, bool val)
        {
            int mask = 1 << bitIndex;
            if (val)
            {
                F |= (byte)mask;
            }
            else
            {
                F &= (byte)~mask;
            }
        }
        private bool getFlag(int bitIndex)
        {
            int mask = 1 << bitIndex;
            return (F & mask) == mask;
        }
        public bool ZFlag
        {
            get => getFlag(7);
            set => setFlag(7, value);
        }
        public bool NFlag
        {
            get => getFlag(6);
            set => setFlag(6, value);
        }
        public bool HFlag
        {
            get => getFlag(5);
            set => setFlag(5, value);
        }
        public bool CYFlag
        {
            get => getFlag(4);
            set => setFlag(4, value);
        }

        public Registers()
        {
        }
    }
}
