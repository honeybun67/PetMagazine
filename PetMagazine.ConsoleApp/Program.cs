using PetMagazine.Services;

namespace PetMagazine.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            new CategoryController().Action();
            //new PetController().Action();
        }
    }
}
