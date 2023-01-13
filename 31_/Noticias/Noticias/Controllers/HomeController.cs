using Microsoft.AspNetCore.Mvc;
using Noticias.Models;
using Noticias.Repository;
using System.Diagnostics;

namespace Noticias.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly INewsRepository _newsRepository;

        public HomeController(INewsRepository newsRepositoryParam)
        {
            _newsRepository = newsRepositoryParam;
        }
        
        public IActionResult Index()
        {
            List<NewsModel> news = _newsRepository.FindAll();
            return View(news);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult Details(int id)
        {
            NewsModel notice = _newsRepository.FindById(id);    
            return View(notice);
        }




    }
}