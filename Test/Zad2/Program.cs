using System;
using System.IO;
using System.Linq;
using Zad2.Common;

namespace Zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length <= 0)
            {
                Console.WriteLine($"Please start program with the file name!");
                return;
            }

            var fileName = GetExistingFile(args);

            var testSchemaModelData = XmlFileManipulation.GetXmlDeserializedData(fileName);

            if (testSchemaModelData == null)
            {
                Console.WriteLine($"Cannot retrieve deserialized data.");
                return;
            }

            var userInput = string.Empty;

            Console.WriteLine("Please enter cell address:\n");


            while (true)
            {
                userInput = Console.ReadLine();

                if (userInput == "-1 -1")
                {
                    Environment.Exit(0);
                }

                if (UserInputHasValues(userInput)) continue;

                if (UserInputHasDigitsOnly(userInput)) continue;

                if (UserInputHasTwoParamsOnly(userInput, out var rowCell)) continue;

                var row = int.Parse(rowCell[0]);
                var cell = int.Parse(rowCell[1]);

                if (testSchemaModelData.Rows.ElementAtOrDefault(row) != null)
                {
                    var selectedRow = testSchemaModelData.Rows[row];

                    Console.WriteLine(selectedRow?.Cell.ElementAtOrDefault(cell) != null
                        ? $"{selectedRow.Cell[cell]}"
                        : "EMPTY");
                }
                else
                {
                    Console.WriteLine("EMPTY");
                }
            }
        }

        private static string GetExistingFile(string[] args)
        {
            var fileName = args[0];

            while (!File.Exists(fileName))
            {
                Console.WriteLine($"File {fileName} does not exist!\nTry adding new one:");
                fileName = Console.ReadLine();
            }

            return fileName;
        }

        private static bool UserInputHasValues(string userInput)
        {
            if (!string.IsNullOrEmpty(userInput)) return false;
            Console.WriteLine("Please enter TEXT values.");

            return true;
        }

        private static bool UserInputHasDigitsOnly(string userInput)
        {
            var isDigit = userInput.Trim().Split(' ').All(s => s.Any(char.IsDigit));

            if (isDigit) return false;

            Console.WriteLine("Please enter DIGIT values.");

            return true;
        }

        private static bool UserInputHasTwoParamsOnly(string userInput, out string[] rowCell)
        {
            rowCell = userInput.Trim().Split(' ');

            if (rowCell.Length == 2) return false;

            Console.WriteLine("Please enter only two(2) values.");

            return true;
        }

    }
}
