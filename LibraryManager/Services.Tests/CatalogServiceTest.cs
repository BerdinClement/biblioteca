using BusinessLayer.Catalog;
using BusinessObjects.Entity;
using Moq;
using Services.Services;

namespace Services.Tests
{
    [TestClass]
    public class CatalogServiceTests
    {
        [TestMethod]
        public void ShowCatalog_Returns_Catalog()
        {

            var mockCatalogManager = new Mock<ICatalogManager>();
            var expectedCatalog = new List<Book> { new Book(), new Book() };
            mockCatalogManager.Setup(m => m.DisplayCatalog()).Returns(expectedCatalog);

            var catalogService = new CatalogService(mockCatalogManager.Object);


            var result = catalogService.ShowCatalog();


            Assert.AreEqual(expectedCatalog, result);
        }

        [TestMethod]
        public void ShowCatalog_FilteredByType_Returns_FilteredCatalog()
        {
            var mockCatalogManager = new Mock<ICatalogManager>();
            var expectedFilteredCatalog = new List<Book> { new Book(), new Book() };
            mockCatalogManager.Setup(m => m.DisplayCatalog(BookTypes.Fiction)).Returns(expectedFilteredCatalog);
            var catalogService = new CatalogService(mockCatalogManager.Object);

            var result = catalogService.ShowCatalog(BookTypes.Fiction);

            Assert.AreEqual(expectedFilteredCatalog, result);
        }

        [TestMethod]
        public void FindBook_Returns_Book()
        {
            var mockCatalogManager = new Mock<ICatalogManager>();
            var expectedBook = new Book();
            mockCatalogManager.Setup(m => m.FindBook(1)).Returns(expectedBook);
            var catalogService = new CatalogService(mockCatalogManager.Object);

            var result = catalogService.FindBook(1);

            Assert.AreEqual(expectedBook, result);
        }

        [TestMethod]
        public void GetBestRatedBook_Returns_BestRatedBook()
        {
            var mockCatalogManager = new Mock<ICatalogManager>();
            var expectedBestRatedBook = new Book();
            mockCatalogManager.Setup(m => m.GetBestRatedBook()).Returns(expectedBestRatedBook);
            var catalogService = new CatalogService(mockCatalogManager.Object);

            var result = catalogService.GetBestRatedBook();

            Assert.AreEqual(expectedBestRatedBook, result);
        }

        [TestMethod]
        public void ShowFantasyBooks_Returns_FantasyBooks()
        {
            var mockCatalogManager = new Mock<ICatalogManager>();
            var expectedFantasyBooks = new List<Book> { new Book(), new Book() };
            mockCatalogManager.Setup(m => m.DisplayFantasyBooks()).Returns(expectedFantasyBooks);
            var catalogService = new CatalogService(mockCatalogManager.Object);

            var result = catalogService.ShowFantasyBooks();

            Assert.AreEqual(expectedFantasyBooks, result);
        }
    }
}
