using Lab_5_2.Controllers;
using Lab_5_2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace Lab_5_2_test
{
    public class ApiBookControllerTest
    {
        [Fact]
        public void GetBooksTest()
        {
            BookMemoryRepository repository = new BookMemoryRepository();
            repository.Add(new Lab_5_2.Models.Book() { Title = "TEST"});
            repository.Add(new Lab_5_2.Models.Book() { Title = "TEST" });
            ApiBookController controllerTest = new ApiBookController(repository);
            System.Collections.Generic.IList<Lab_5_2.Models.Book> books = controllerTest.GetBooks();
            Assert.Equal(2, books.Count);
        }

        public void DeleteBookTest()
        {
            BookMemoryRepository repository = new BookMemoryRepository();
            repository.Add(new Lab_5_2.Models.Book() { Title = "TEST" });
            repository.Add(new Lab_5_2.Models.Book() { Title = "TEST" });
            ApiBookController controllerTest = new ApiBookController(repository);
            Microsoft.AspNetCore.Mvc.IActionResult actionResult = controllerTest.DeleteBook(2);
            Assert.IsType<OkResult>(actionResult);
            actionResult = controllerTest.DeleteBook(6);
            Assert.IsType<NotFoundResult>(actionResult);
        }
        [Fact]
        public void AddBookTest()
        {
            BookMemoryRepository repository = new BookMemoryRepository();
            repository.Add(new Lab_5_2.Models.Book() { Title = "TEST" });
            repository.Add(new Lab_5_2.Models.Book() { Title = "TEST" });
            ApiBookController controllerTest = new ApiBookController(repository);
            Book newBook = new Book() { Id = 10, Title = "NEW" };
            ActionResult<Book> actionResult = controllerTest.AddBook(newBook);
            Assert.Equal("NEW", repository.FindById(3).Title);

        }
    }
}
