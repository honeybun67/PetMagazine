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
        private int animalsPerPage = 5;
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

                    Console.WriteLine("[A]dd; [P]revious; [N]ext; [E]dit; [D]elete; [S]ort; [AN]imals per page; [AA]dopt");

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
                        case "SORT":
                            SortAction();
                            break;
                        case "AN":
                        case "ANIMALS":
                            ChangePaginationAction();
                            break;
                        case "AA":
                        case "ADOPT":
                            AdoptAction();
                            break;
                        case "SEED":
                            SeedDataAction();
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

        private void SeedDataAction()
        {
            for (int i = 11; i <= 30; i++)
            {
                service.Add(new Pet { Name = $"Pet {i} ", Age = i, Breed = $"breed {i} ", Owner = $"owner {i} ", KindOfPet =$"kind {i}"});
            }
            UpdatePagination();
        }

        private void ChangePaginationAction()
        {
            Console.Write("Enter animals per page: ");
            animalsPerPage = int.Parse(Console.ReadLine());
            Console.WriteLine($"Animals per page is set to {animalsPerPage}!");
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
            Console.WriteLine(string.Format(OutputMessages.DeletePet, deleteId));
            Thread.Sleep(2000);
            UpdatePagination();
        }

        private void EditAction()
        {
            Console.Write("Enter pet id: ");
            int editId = int.Parse(Console.ReadLine());
            Console.Write("Enter name: ");
            string newName = Console.ReadLine();
            service.EditPet(new Pet() { Name = newName });
            Console.WriteLine(string.Format(OutputMessages.EditCategory, editId));
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
            Console.Write("Enter age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter breed: ");
            string breed = Console.ReadLine();
            Console.Write("Enter kind of pet: ");
            string kind = Console.ReadLine();
            Console.Write("Enter owner name: ");
            string owner = Console.ReadLine();
            int id = service.Add(new Pet() { Name = name, Age = age, Breed = breed, KindOfPet = kind, Owner = owner });
            Console.WriteLine(string.Format(OutputMessages.AddPet, id));
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
            pageCount = (int)Math.Ceiling((double)totalItems / animalsPerPage);
        }

        private void PrintPets()
        {
            List<Pet> petList = service.GetPets(currentPage, animalsPerPage, ascSort);
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
