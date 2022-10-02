namespace Gameboy_Emulator
{
    public class Program
    {
        public void Main()
        {
            Dictionary<int, IInstruction> instructions;

            addInstruction(
                LoadInstruction(), 
                0b01, 
                OpCodeParameter.Register, 
                OpCodeParameter.RegisterPrime);

            addInstruction(LDRegisterRAM, 0b01, Parameter.QQ0, 0b010);
        }
        void addInstruction();
    }
}