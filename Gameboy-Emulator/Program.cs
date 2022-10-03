namespace Gameboy_Emulator
{
    public class Program
    {
        public void Main()
        {
            Dictionary<int, IInstruction> instructions;

            //LD_R_R,         // r <- r'              01 r   r'
            AddInstruction(typeof(LDInstruction), InstructionType.LD_R_R, 0b01, OpCodeParameter.Register, OpCodeParameter.RegisterPrime);
            //LD_R_N,         // r <- n               00 r   110
            AddInstruction(typeof(LDInstruction), InstructionType.LD_R_N, 0b00, OpCodeParameter.Register, 0b110);
            //LD_R_DerefHL,   // r <- (HL)            01 r   110
            AddInstruction(typeof(LDInstruction), InstructionType.LD_R_DerefHL, 0b01, OpCodeParameter.Register, 0b110);
            //LD_DerefHL_R,   // (HL) <- r            01 110 r
            AddInstruction(typeof(LDInstruction), InstructionType.LD_DerefHL_R, 0b01, 0b110, OpCodeParameter.Register);
            //LD_DerefHL_N,   // (HL) <- n            00 110 110
            AddInstruction(typeof(LDInstruction), InstructionType.LD_DerefHL_N, 0b00, 0b110, 0b110);
            //LD_A_DerefBC,   // A <- (BC)            00 001 010
            AddInstruction(typeof(LDInstruction), InstructionType.LD_A_DerefBC, 0b00, 0b001, 0b010);
            //LD_A_DerefDE,   // A <- (DE)            00 011 010
            //LD_A_DerefC,    // A <- (0xFF00 + C)    11 110 010
            //LD_DerefC_A,    // (0xFF00 + C) <- A    11 100 010
            //LD_A_DerefN,    // A <- (FF00 + n)      11 110 000
            //LD_DerefN_A,    // (FF00 + n) <- A      11 100 000
            //LD_A_DerefNN,   // A <- (nn)            11 111 010
            //LD_DerefNN_A,   // (nn) <- A            11 101 010
            //LD_A_DerefHLI,  // A <- (HL), HL++      00 101 010
            //LD_A_DerefHLD,  // A <- (HL), HL--      00 111 010
            //LD_DerefBC_A,   // (BC) <- A            00 000 010
            //LD_DerefDE_A,   // (DE) <- A            00 010 010
            //LD_DerefHLI_A,  // (HL) <- A, HL++      00 100 010
            //LD_DerefHLD_A,  // (HL) <- A, HL--      00 110 010
            //LD_DD_NN,       // dd <- nn             00 dd0 001
            //LD_SP_HL,       // SP <- HL             11 111 001
        }
        void AddInstruction(Type type, InstructionType instructionType, byte header, byte middle, byte end)
        {
            OpCode opCode = new OpCode(header, middle, end);
            Activator.CreateInstance<IInstruction>(type); //garbage
        }
        void AddInstruction(Type type, InstructionType instructionType, byte header, OpCodeParameter middle, byte end)
        {

        }

        void AddInstruction(Type type, InstructionType instructionType, byte header, byte middle, OpCodeParameter end)
        {

        }
        void AddInstruction(Type type, InstructionType instructionType, byte header, OpCodeParameter middle, OpCodeParameter end)
        {
            switch (middle)
            {
                case OpCodeParameter.Bits:
                    break;
                case OpCodeParameter.Register:
                    break;
                case OpCodeParameter.QQ0:
                    break;
                case OpCodeParameter.DD0:
                    break;
                case OpCodeParameter.SS1:
                    break;
            }
        }
    }
}