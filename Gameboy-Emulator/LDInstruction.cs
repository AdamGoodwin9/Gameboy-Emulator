using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Gameboy_Emulator
{
    internal class LDInstruction : IInstruction
    {
        //01 r rprime
        Registers registers;
        OpCodeParameter middle;
        OpCodeParameter end;
        InstructionType loadType;
        PropertyInfo Dest;
        PropertyInfo Src;
        dynamic DestObj;
        dynamic SrcObj;
        public LDInstruction(OpCode opCode, InstructionType instructionType, Registers registers)
        {
            this.registers = registers;
            switch (loadType)
            {
                case InstructionType.LD_R_R:
                    var garb1 = (Register)opCode.Middle;
                    garb1.ToString();
                    string rName = Enum.GetName(typeof(Register), opCode.Middle)
                        ?? throw new ArgumentException($"Register {opCode.Middle} does not exist");
                    string rPrimeName = Enum.GetName(typeof(Register), opCode.End)
                        ?? throw new ArgumentException($"Register {opCode.End} does not exist");
                    Dest = registers.GetType().GetProperty(rName);
                    Src = registers.GetType().GetProperty(rPrimeName);
                    DestObj = registers;
                    SrcObj = registers;
                    break;
                case InstructionType.LD_R_N:
                    break;
                case InstructionType.LD_R_DerefHL:
                    break;
                case InstructionType.LD_DerefHL_R:
                    break;
                case InstructionType.LD_DerefHL_N:
                    break;
                case InstructionType.LD_A_DerefBC:
                    break;
                case InstructionType.LD_A_DerefDE:
                    break;
                case InstructionType.LD_A_DerefC:
                    break;
                case InstructionType.LD_DerefC_A:
                    break;
                case InstructionType.LD_A_DerefN:
                    break;
                case InstructionType.LD_DerefN_A:
                    break;
                case InstructionType.LD_A_DerefNN:
                    break;
                case InstructionType.LD_DerefNN_A:
                    break;
                case InstructionType.LD_A_DerefHLI:
                    break;
                case InstructionType.LD_A_DerefHLD:
                    break;
                case InstructionType.LD_DerefBC_A:
                    break;
                case InstructionType.LD_DerefDE_A:
                    break;
                case InstructionType.LD_DerefHLI_A:
                    break;
                case InstructionType.LD_DerefHLD_A:
                    break;
                case InstructionType.LD_DD_NN:
                    break;
                case InstructionType.LD_SP_HL:
                    break;
                default:
                    throw new ArgumentException("Passed non-load instruction to LDInstruction Class");
            }
        }

        public string Name { get => "LD"; }
        public string Shorthand { get; private set; }

        public void execute(Registers registers, OpCode opCode)
        {
            Dest.SetValue(DestObj, Src.GetValue(SrcObj));
        }

        public void execute(Registers r)
        {
            throw new NotImplementedException();
        }
    }
}
