namespace PetMagazine.ConsoleApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using PetMagazine.Common;
    using PetMagazine.Data.Models;
    using PetMagazine.Services;

    public class PetController
    {
        private PetService service = new PetService();

        //Pagination variables
        private int currentPage = 1;
        private int itemsPerPage = 5;
        private int pageCount = 0;
        private int totalItems = 0;
        private bool ascSort = true;

        public void Action()
        {
            UpdatePagination();
            while (true)
            {
                Console.Clear();
                try
                {
                    PrintPets();

                    Console.WriteLine("[A]dd; [P]revious; [N]ext; [E]dit; [D]elete; [S]ort; [I]tems per page; [AA]dopt");

                    string cmd = GetCmd();

                    switch (cmd)
                    {
                        case "A":
                        case "ADD":
                            AddAction();
                            break;
                        case "P":
                        case "PREVIOUS":
                            PreviousAction();
                            break;
                        case "N":
                        case "NEXT":
                            NextAction();
                            break;
                        case "E":
                        case "EDIT":
                            EditAction();
                            break;
                        case "D":
                        case "DELETE":
                            DeleteAction();
                            break;
                        case "S":
                        case "Sort":
                            SortAction();
                            break;
                        case "I":
                        case "Items":
                            ChangePaginationAction();
                            break;
                        case "AA":
                        case "Adopt":
                            AdoptAction();
                            break;
                        case "SEED":
                            SeedDataEction();
                            break;
                        case "EX":
                        case "EXIT":
                            return;
                        default:
                            throw new InvalidOperationException("Invalid command!");
                    }
                }
                catch (Exception ex)
                {
                    ExceptionAction(ex);
                }
            }

        }

        private void AdoptAction()
        {
            Console.WriteLine("Enter pet id: ");
            int adoptId = int.Parse(Console.ReadLine());
            service.AdoptPet( adoptId );
            Console.WriteLine(string.Format(OutputMessages.AdoptedPet, adoptId));
            Thread.Sleep(2000);
            UpdatePagination();
        }

        private static void ExceptionAction(Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ex.Message);
            Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private void SeedDataEction()
        {
            for (int i = 1; i < 10; i++)
            {
                service.Add(new Pet {Name = $"Pet {i}" });
            }
            UpdatePagination();
        }

        private void ChangePaginationAction()
        {
            Console.Write("Enter items per page: ");
            itemsPerPage = int.Parse(Console.ReadLine());
            Console.WriteLine($"Items per page is set to {itemsPerPage}!");
            Thread.Sleep(2000);
            UpdatePagination();
        }

        private void SortAction()
        {
            ascSort = !ascSort;
        }

        private void DeleteAction()
        {
            Console.Write("Enter id: ");
            int deleteId = int.Parse(Console.ReadLine());
            service.DeletePet(deleteId);
            Console.WriteLine(string.Format(OutputMessages.DeleteCategory, deleteId));
            Thread.Sleep(2000);
            UpdatePagination();
        }

        private void EditAction()
        {
            Console.Write("Enter pet id: ");
            int editId = int.Parse(Console.ReadLine());
            Console.Write("Enter name: ");
            string newName = Console.ReadLine();
            int id = service.EditPet(new Pet() { Name = newName });
            Console.WriteLine(string.Format(OutputMessages.EditCategory, id));
            Thread.Sleep(2000);
        }

        private void NextAction()
        {
            if ((currentPage + 1) <= pageCount) { currentPage++; }
            else { currentPage = 1; }
        }

        private void PreviousAction()
        {
            if ((currentPage - 1) > 0) { currentPage--; }
            else { currentPage = pageCount; }
        }

        private void AddAction()
        {
            Console.Write("Enter pet name: ");
            string name = Console.ReadLine();
            int id = service.Add(new Pet() { Name = name });
            Console.WriteLine(string.Format(OutputMessages.AddPet, id, name));
            Thread.Sleep(2000);
            UpdatePagination();
        }

        private static string GetCmd()
        {
            Console.Write("Enter command: ");
            string cmd = Console.ReadLine().ToUpper();
            return cmd;
        }

        private void UpdatePagination()
        {
            totalItems = service.GetPetsCount();
            pageCount = (int)Math.Ceiling((double)totalItems / itemsPerPage);
        }

        private void PrintPets()
        {
            List<Pet> petList = service.GetPets(currentPage, itemsPerPage, ascSort);
            string head = $"| {"Id",4} | {"Name",10} |";

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"{new string('-', head.Length)}");
            Console.WriteLine(head);
            Console.WriteLine($"|{new string('-', head.Length - 2)}|");
            foreach (var c in petList)
            {
                Console.WriteLine($"| {c.Id,4} | {string.Join("", c.Name.Take(10)),10} |");
            }
            Console.WriteLine($"{new string('-', head.Length)}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{currentPage}/{pageCount}, pets count: {totalItems}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
