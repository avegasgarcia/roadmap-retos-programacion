using System;

namespace roadmapdev
{
    internal class Program
    {
        /// <summary>
        /// Example of XML documentation comments
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Official C# reference site https://learn.microsoft.com/en-us/dotnet/csharp/

            //  Single line comment
            /*  Multiple
                line
                comment
            */
            int integer = 12;
            const int constant = 10; //inmutable

            // The readonly keyword differs from the const keyword. A const field can only be initialized at the declaration of the field.
            // A readonly field can be initialized either at the declaration or in a constructor.
            // Therefore, readonly fields can have different values depending on the constructor used.
            // Also, although a const field is a compile-time constant, the readonly field can be used for run-time constants,
            // as in this line: public static readonly uint l1 = (uint)DateTime.Now.Ticks;

            byte byte_var = 8; // 8-bit integer
            short short_var = 0; // 16-bit integer
            int integer_var = 256; // 32-bit integer                    
            long long_var = 10; // 64-bit integer
            float float_var = 25.5f; // 4-byte floating point
            double double_var = 25.5; // 8-byte floating point
            decimal decimal_var = 25.5M; // 16-byte floating point
            bool boolean = true;
            string string_var = "C#";
            char char_var = 'c';

            Console.WriteLine("¡Hola, C#!");
        }
    }
}