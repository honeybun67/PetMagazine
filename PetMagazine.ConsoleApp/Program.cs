using PetMagazine.Services;

namespace PetMagazine.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            new PetController().Action();
        }
    }
}
