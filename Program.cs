using System;

namespace Exercises
{
    class MaxAndMinMemory
    {
        static void Main(string[] args)
        {
            Console.Write("Reads the amount of memory used by each data type!!!\n");
            Console.WriteLine($"Int uses {sizeof (int)} bytes and can store numbers upto the range of \n{int.MinValue:N0} to {int.MaxValue:N0}.");
            Console.WriteLine($"sbyte uses {sizeof (sbyte)} bytes and can store numbers upto the range of \n{sbyte.MinValue:N0} to {sbyte.MaxValue:N0}.");
            Console.WriteLine($"ushort uses {sizeof (ushort)} bytes and can store numbers upto the range of \n{ushort.MinValue:N0} to {ushort.MaxValue:N0}. ");
            Console.WriteLine($"uint uses {sizeof (uint)} bytes and can store numbers upto the range of \n{uint.MinValue} to {uint.MaxValue}.");
            Console.WriteLine($"ulong uses {sizeof (ulong)} bytes and can store numbers upto the range of \n{ulong.MinValue} to {ulong.MaxValue}.");
        }
    }
}
