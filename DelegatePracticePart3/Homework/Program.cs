using Homework.Models;
using System;
using System.Collections.Generic;
using Utils.Enums;
using Utils.Exceptions;
using Utils.Helpers;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,5
            //};

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //Book book1 = new Book("asfdas", "asdasfa", 12);
            //Book book2 = new Book("asfdaasdass", "asdasfatew", 13);

            //Library library = new Library(5);

            //library.AddBook(book1);
            //library.AddBook(book2);

            //foreach (Book item in library)
            //{
            //    item.ShowInfo();
            //}

            //Console.WriteLine("Username");
            //string username = Console.ReadLine();
            //string email;
            //do
            //{
            //    Console.WriteLine("Email:");
            //    email = Console.ReadLine();
            //} while (!Checker.EmailChecker(email));
            //byte role;
            //bool isNum;
            //do
            //{
            //    Console.WriteLine("Role (1. Admin 2. Member):");
            //    string roleStr = Console.ReadLine();
            //    isNum = byte.TryParse(roleStr, out role);
            //} while (!isNum || !Enum.IsDefined(typeof(Role), role));

            //User user = new User(username, email, (Role)role);

            //Library library = new Library(5);

            //bool check = true;
            //do
            //{
            //    Console.WriteLine("====== Menu ======");
            //    Console.WriteLine("1. Add book");
            //    Console.WriteLine("2. Get book by id");
            //    Console.WriteLine("3. Get all books");
            //    Console.WriteLine("4. Delete book by id");
            //    Console.WriteLine("5. Edit book name");
            //    Console.WriteLine("6. Filter books by page count");
            //    Console.WriteLine("0. Quit");

            //    string choice = Console.ReadLine();

            //    switch (choice)
            //    {
            //        case "1":
            //            Console.WriteLine("Book name:");
            //            string bookName = Console.ReadLine();
            //            Console.WriteLine("Author name:");
            //            string authorName = Console.ReadLine();
            //            int pageCount = GetInputInt("Page count:", 10);

            //            Book book = new Book(bookName, authorName, pageCount);
            //            try
            //            {
            //                library.AddBook(book);
            //            }
            //            catch (NullReferenceException ex)
            //            {
            //                Console.WriteLine(ex.Message);
            //            }
            //            catch (AlreadyExistsException ex)
            //            {
            //                Console.WriteLine(ex.Message);
            //            }
            //            catch (CapacityLimitException ex)
            //            {
            //                Console.WriteLine(ex.Message);
            //            }
            //            break;
            //        case "2":
            //            int bookId = GetInputInt("Id:", 1);
            //            try
            //            {
            //                library.GetBookById(bookId).ShowInfo();
            //            }
            //            catch (NullReferenceException ex)
            //            {
            //                Console.WriteLine(ex.Message);
            //            }
            //            break;
            //        case "3":
            //            foreach (var item in library.GetAllBooks())
            //            {
            //                item.ShowInfo();
            //            }
            //            break;
            //        case "4":
            //            int id = GetInputInt("Id:", 1);

            //            try
            //            {
            //                library.DeleteBookById(id);
            //            }
            //            catch (NullReferenceException ex)
            //            {
            //                Console.WriteLine(ex.Message);
            //            }
            //            catch(NotFoundException ex)
            //            {
            //                Console.WriteLine(ex.Message);
            //            }
            //            break;
            //        case "5":
            //            int editId = GetInputInt("Id: ", 1);
            //            string name = Console.ReadLine();

            //            try
            //            {
            //                library.EditBookName(editId, name); 
            //            }
            //            catch (NullReferenceException ex)
            //            {
            //                Console.WriteLine(ex.Message);
            //            }
            //            break;
            //        case "6":
            //            int minPage = GetInputInt("min page:", 1, 1300);
            //            int maxPage = GetInputInt("min page:", 1, 1300);

            //            foreach (var item in library.FilterByPageCount(minPage, maxPage))
            //            {
            //                item.ShowInfo();
            //            }
            //            break;
            //        case "0":
            //            check = false;
            //            break;
            //        default:
            //            Console.WriteLine("bele bir emeliyyat yoxdur...");
            //            break;
            //    }
            //} while (check);
        }

        //static int GetInputInt(string title, int min, int max = int.MaxValue)
        //{
        //    int input;
        //    bool isNum;
        //    do
        //    {
        //        Console.WriteLine(title);
        //        string inputStr = Console.ReadLine();
        //        isNum = int.TryParse(inputStr, out input);
        //    } while (!isNum);

        //    return input;
        //}
    }
}
