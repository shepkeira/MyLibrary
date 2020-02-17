using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLibrary;

namespace BankTests
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Library mylibrary = new Library();
            Book b = new Book("Title", "Author");
            Assert.AreEqual(b.ToString(), "Title: Title\nAuthor: Author\n");
            mylibrary.AddBook(b);
            Assert.AreEqual(mylibrary.ToString(), "Title: Title\nAuthor: Author\n\n");
        }
    }
}