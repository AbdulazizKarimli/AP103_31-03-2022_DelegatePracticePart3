using Homework.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Models
{
    internal class Book : IEntity
    {
        private static int _id;

        public int Id { get; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public bool IsDeleted { get; set; }

        public Book(string name, string authorName, int pageCount)
        {
            _id++;
            Id = _id;
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name} - Author name: {AuthorName} - Page count: {PageCount} - IsDeleted: {IsDeleted}");
        }
    }
}
