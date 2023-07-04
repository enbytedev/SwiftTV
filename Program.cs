using System.Text.RegularExpressions;

namespace SwiftTV
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0 || !IsValidInputFile(args[0]))
            {
                PrintHelpMessage();
                return;
            }

            string filePath = args[0];

            if (File.Exists(filePath))
            {
                string customCode = File.ReadAllText(filePath);

                string outputCode = Transpile(customCode);

                string outputFilePath = Path.ChangeExtension(filePath, ".swift");
                File.WriteAllText(outputFilePath, outputCode);

                Console.WriteLine($"Transpiled code has been written to: {outputFilePath}");
            }
            else
            {
                Console.WriteLine("File not found!");
            }

            Console.ReadLine();
        }

        static void PrintHelpMessage()
        {
            Console.WriteLine("Usage: Swift (Taylor's Version) Transpiler <file-path>");
            Console.WriteLine("Transpiles the Swift (Taylor's Version) code (.stv) in the specified file into Swift code.");
            Console.WriteLine();
            Console.WriteLine("Arguments:");
            Console.WriteLine("  <file-path>   The path to the file containing the Swift (Taylor's Version) code.");
            Console.WriteLine();
        }

        static bool IsValidInputFile(string filePath)
        {
            return Path.GetExtension(filePath).ToLower() == ".stv";
        }

        static string Transpile(string customCode)
        {
            Dictionary<string, string> keywordMap = new Dictionary<string, string>()
            {
                { "speaknow", "print" },
                { "glitter", "let" },
                { "fountain", "var" },
                { "delicate", "if" },
                { "chill", "else" },
                { "cool", "else if" },
                { "longlive", "while" },
                { "belongwithme", "import" },
                { "shortskirts", "false" },
                { "tshirts", "true" },
                { "itwas", "#800000"}
            };

            // Use regex to find and replace the keywords
            string pattern = @"\b(" + string.Join("|", keywordMap.Keys) + @")\b";
            string transpiledCode = Regex.Replace(customCode, pattern, match => keywordMap[match.Value]);

            return transpiledCode;
        }
    }
}
