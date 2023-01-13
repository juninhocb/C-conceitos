using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using Noticias.Models;
using Noticias.Repository;

namespace Noticias.Controllers
{
    public class NewsController : Controller
    {
        private readonly INewsRepository _newsRepository;

        public NewsController(INewsRepository newsRepositoryParam)
        {
            _newsRepository = newsRepositoryParam;
        }
        public IActionResult Index()
        {
            List<NewsModel> listNews = _newsRepository.FindAll();

            return View(listNews);
        }

        public IActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        public IActionResult Create(NewsModel notice)
        {
            Console.WriteLine("Teste " + notice);
            try{
                _newsRepository.Create(notice);
                TempData["Success"] = "Contato alterado com sucesso!";
                return RedirectToAction("Index");
            } catch (Exception) {
                TempData["Error"] = "Contato alterado com sucesso!";
                return View();
            }
        }

        public IActionResult Edit(int id)
        {
            NewsModel notice = _newsRepository.FindById(id);
            return View(notice);
        }

        [HttpPost]
        public IActionResult Edit(NewsModel notice)
        {

            try
            {
                _newsRepository.Update(notice);
                TempData["Success"] = "Contato alterado com sucesso!";
                return RedirectToAction("Index");
            }
            catch (Exception err)
            {
                TempData["Error"] = $"Não foi possível alterar o contato. Detalhe do erro: {err.Message}";
                return RedirectToAction("Index");
            }
        }

        public IActionResult Delete(int id)
        {
            NewsModel notice = _newsRepository.FindById(id);
            Console.WriteLine("Titulo da notice é igual a: " + notice.Title);
            return View(notice);

        }

        public IActionResult DeleteNews(int id)
        {
            try
            {
                _newsRepository.DeleteNews(id);
                TempData["Success"] = "Contato deletado com sucesso!";
                return RedirectToAction("Index");
            }
            catch (Exception err)
            {
                TempData["Error"] = $"Não foi possível deletar o contato. Detalhe do erro: {err.Message}";
                return RedirectToAction("Index");
            }
        }


    }
}
