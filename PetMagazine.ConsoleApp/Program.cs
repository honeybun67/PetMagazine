using System.Text;
using PetMagazine.ConsoleApp;
using PetMagazine.Services;

namespace PetMagazine.ConsoleApp
{
    public class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Clear();
                PrintMenu();
                Console.Write("Enter command: ");
                string cmd = Console.ReadLine();
                switch (cmd)
                {
                    case "0":
                        return;
                    case "1":
                        new PetController().Action();
                        break;
                        case "2":
                            new CategoryController().Action();
                        break;
                    default:
                        Console.WriteLine("Invalid command!");
                        break;
                }
            }
        }
        public static void PrintMenu()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Pet magazine menu:");
            sb.AppendLine($"\t0: Back");
            sb.AppendLine($"\t1: Pets");
            sb.AppendLine($"\t2: Categories");
            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
 }
