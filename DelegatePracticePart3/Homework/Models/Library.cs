using Homework.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Utils.Exceptions;

namespace Homework.Models
{
    internal class Library : IEntity
    {
        private static int _id;
        //private List<Book> _books;
        private readonly Database<Book> _db;

        public int Id { get; set; }
        public int BookLimit { get; set; }

        public Library(int bookLimit)
        {
            _id++;
            Id = _id;
            //_books = new List<Book>();
            BookLimit = bookLimit;
            _db = new Database<Book>();
        }

        public void AddBook(Book book)
        {
            _db.Add(book, b => !b.IsDeleted && b.Name == book.Name);
        }
        public Book GetBookById(int? id)
        {
            if (id == null)
                throw new NullReferenceException("null ola bilmez");

            return _db.Get(b => b.Id == id && !b.IsDeleted);
        }
        public List<Book> GetAllBooks()
        {
            return _db.GetAll(b => !b.IsDeleted);
        }
        public void DeleteBookById(int? id)
        {
            if (id == null)
                throw new NullReferenceException("null ola bilmez");

            _db.Delete(b => b.Id == id && !b.IsDeleted);
        }

        //public void AddBook(Book book)
        //{
        //    if (book == null)
        //        throw new NullReferenceException("null ola bilmez");

        //    if (_books.Exists(b => !b.IsDeleted && b.Name == book.Name))
        //        throw new AlreadyExistsException("bu adda kitab var");

        //    if(_books.Count < BookLimit)
        //    {
        //        _books.Add(book);
        //        return;
        //    }

        //    throw new CapacityLimitException("limit doldu");
        //}
        //public Book GetBookById(int? id)
        //{
        //    if (id == null)
        //        throw new NullReferenceException("id null ola bilmez");

        //    return _books.Find(b => !b.IsDeleted && b.Id == id);
        //}
        //public List<Book> GetAllBooks()
        //{
        //    List<Book> booksCopy = new List<Book>();
        //    booksCopy.AddRange(_books.FindAll(b => !b.IsDeleted));

        //    return booksCopy;
        //}
        //public void DeleteBookById(int? id)
        //{
        //    if (id == null)
        //        throw new NullReferenceException("id null ola bilmez");

        //    Book book = _books.Find(b => !b.IsDeleted && b.Id == id);
        //    if (book == null)
        //        throw new NotFoundException("bu idli kitab yoxdur");

        //    book.IsDeleted = true;
        //}
        //public void EditBookName(int? id, string name)
        //{
        //    if (id == null || string.IsNullOrWhiteSpace(name))
        //        throw new NullReferenceException("id null ola bilmez");

        //    Book book = _books.Find(b => !b.IsDeleted && b.Id == id);
        //    if (book == null)
        //        throw new NotFoundException("bu idli kitab yoxdur");

        //    book.Name = name;
        //}
        //public List<Book> FilterByPageCount(int minPageCount, int maxPageCount)
        //{
        //    List<Book> booksCopy = new List<Book>();
        //    booksCopy
        //        .AddRange(_books
        //        .FindAll(b => !b.IsDeleted && b.PageCount >= minPageCount && b.PageCount <= maxPageCount));
        //    return booksCopy;
        //}

        //public IEnumerator GetEnumerator()
        //{
        //    foreach (var item in _books)
        //    {
        //        yield return item;
        //    }
        //}
    }
}
