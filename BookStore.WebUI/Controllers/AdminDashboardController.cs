using BookStore.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

public class AdminDashboardController : Controller
{
    private readonly IProductService _bookService;
    private readonly IAuthorService _authorService;
    private readonly ICategoryService _categoryService;
    private readonly ISubscribeService _subscriberService;
    private readonly IQuoteService _quoteService;

    public AdminDashboardController(
        IProductService bookService,
        IAuthorService authorService,
        ICategoryService categoryService,
        ISubscribeService subscriberService,
        IQuoteService quoteService)
    {
        _bookService = bookService;
        _authorService = authorService;
        _categoryService = categoryService;
        _subscriberService = subscriberService;
        _quoteService = quoteService;
    }

    public IActionResult Index()
    {
        var books = _bookService.TGetAll();

        ViewBag.BookCount = books.Count;
        ViewBag.AuthorCount = _authorService.TGetAll().Count;
        ViewBag.CategoryCount = _categoryService.TGetAll().Count;
        ViewBag.SubscriberCount = _subscriberService.TGetAll().Count;
        ViewBag.QuoteOfTheDay = _quoteService.TGetAll().FirstOrDefault()?.Description ?? "Bugün için söz bulunamadı.";

        ViewBag.MostExpensiveBooks = books.OrderByDescending(b => b.ProductPrice).Take(5).ToList();
        ViewBag.CheapestBooks = books.OrderBy(b => b.ProductPrice).Take(5).ToList();

        return View();
    }
}
