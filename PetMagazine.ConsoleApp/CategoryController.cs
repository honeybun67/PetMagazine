namespace PetMagazine.ConsoleApp
{
    using PetMagazine.Common;
    using PetMagazine.Data.Models;
    using PetMagazine.Services;
    using System;
    using System.Collections.Generic;
    using System.Linq;
  
    public class CategoryController
    {
        private CategoryService service = new CategoryService();

        //Pagination variables
        private int currentPage = 1;
        private int itemsPerPage = 10;
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
                    PrintCategory();

                    Console.WriteLine("[A]dd; [P]revious; [N]ext; [E]dit; [D]elete; [S]ort; [I]tems per page");

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

        private static void ExceptionAction(Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(ex.Message);
            Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.DarkRed;
        }

        private void SeedDataEction()
        {
            for (int i = 1; i <= 40; i++)
            {
                service.Add(new Category() { Name = $"Category {i}" });
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
            service.DeleteCategory(deleteId);
            Console.WriteLine(string.Format(OutputMessages.DeleteCategory, deleteId));
            Thread.Sleep(2000);
            UpdatePagination();
        }

        private void EditAction()
        {
            Console.Write("Enter category id: ");
            int editId = int.Parse(Console.ReadLine());
            Console.Write("Enter name: ");
            string newName = Console.ReadLine();
            service.EditCategory(editId, newName);
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
            Console.Write("Enter ganre name: ");
            string name = Console.ReadLine();
            int id = service.Add(new Category() { Name = name });
            Console.WriteLine(string.Format(OutputMessages.AddCategory, id, name));
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
            totalItems = service.GetCategoriesCount();
            pageCount = (int)Math.Ceiling((double)totalItems / itemsPerPage);
        }

        private void PrintCategory()
        {
            List<Category> categoryList = service.GetCategories(currentPage, itemsPerPage, ascSort);
            string head = $"| {"Id",4} | {"Name",10} |";

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"{new string('-', head.Length)}");
            Console.WriteLine(head);
            Console.WriteLine($"|{new string('-', head.Length - 2)}|");
            foreach (var c in categoryList)
            {
                Console.WriteLine($"| {c.Id,4} | {string.Join("", c.Name.Take(10)),10} |");
            }
            Console.WriteLine($"{new string('-', head.Length)}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{currentPage}/{pageCount}, categories count: {totalItems}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
