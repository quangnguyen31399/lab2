using Lab2_NguyenLeHongQuang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace Lab2_NguyenLeHongQuang.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            return View();
        }

        public String HelloStudent(string university)
        {
            return "Hello em NLHQuang - University:" + university;
        }

        public ActionResult ListBook()
        {
            var books = new List<string>();
            books.Add("HTML5 & CSS The complete Manual - Author Name Book 1");
            books.Add("HTML5 & CSS Responsive web  Design cookbook - Author Name Book 2");
            books.Add("Professional ASP.NET MVC5 - Author Name Book 2");
            ViewBag.Books = books;
            return View();
        }
        public ActionResult ListBookModel()
        {
            var books = new List<Book>();
            books.Add(new Book(1,"HTML5 & CSS3 The complete Manual"," Author Name Book 1","/Content/image/book1.jpg"));
            books.Add(new Book(2,"HTML5 & CSS Responsive web  Design cookbook", "Author Name Book 2", "/Content/image/book2.jpg"));
            books.Add(new Book(3,"Professional ASP.NET MVC5", "Author Name Book 2", "/Content/image/book3.jpg"));
           
            return View(books);
        }
        public ActionResult EditBook(int id)
        {
            var books = new List<Book>();
            books.Add(new Book(1, "HTML5 & CSS3 The complete Manual", " Author Name Book 1", "/Content/image/book1.jpg"));
            books.Add(new Book(2, "HTML5 & CSS Responsive web  Design cookbook", "Author Name Book 2", "/Content/image/book2.jpg"));
            books.Add(new Book(3, "Professional ASP.NET MVC5", "Author Name Book 2", "/Content/image/book3.jpg"));

            Book book = new Book();
            foreach (Book b in books)
            {
                if(b.Id==id)
                {
                    book = b;
                    break;
                }

            }
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);

        }
        [HttpPost, ActionName("EditBook")]
        [ValidateAntiForgeryToken]

        public ActionResult EditBook(int id, string Title,string Author, string ImageCover)
        {
            var books = new List<Book>();
            books.Add(new Book(1, "HTML5 & CSS3 The complete Manual", " Author Name Book 1", "/Content/image/book1.jpg"));
            books.Add(new Book(2, "HTML5 & CSS Responsive web  Design cookbook", "Author Name Book 2", "/Content/image/book2.jpg"));
            books.Add(new Book(3, "Professional ASP.NET MVC5", "Author Name Book 2", "/Content/image/book3.jpg"));
            if(id == null)
            {
                return HttpNotFound();
            }
            foreach(Book b in books)
            {
                if (b.Id == id)
                {
                    b.Title = Title;
                    b.Author = Author;
                    b.ImageCover = ImageCover;
                    break;
                }
            }
            return View("ListBookModel", books);
        }
        public ActionResult CreateBook()
        {
            return View();
        }

    }
}