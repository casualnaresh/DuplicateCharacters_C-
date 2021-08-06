using System;

namespace DuplicateCharacters_CSharp
{
    class Program
    {
        static void Main()
        {
            string input = DeleteDuplicates("Visual STUDIO Code");
            Console.WriteLine(input);
        }

        static string DeleteDuplicates(string value)
        {
            string updatedValue = "";
            string FinalValue = "";

            foreach (char item in value.ToUpper())
            {
                if (updatedValue.IndexOf(item) == -1)
                {
                    updatedValue += item;
                    FinalValue += item;
                }
            }
            return FinalValue;
        }
    }
}
