using Logistica.mercadorias.Interfaces;
using Logistica.mercadorias.Models;
using Logistica.mercadorias.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Logistica.mercadorias.Controllers
{
    public class RegisterController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IProductRepository _productRepository;
        private readonly IClientRepository _clientRepository;
        public RegisterController(
            ICategoryRepository categoryRepository, 
            IProductRepository productRepository,
            IClientRepository clientRepository
            )
        {
            _categoryRepository = categoryRepository; 
            _productRepository = productRepository;
            _clientRepository = clientRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Categories()
        {
            ViewBag.ListCategories = _categoryRepository.FindAll();
            return View("~/Views/Register/Categories/Index.cshtml");
        }

        [HttpPost]
        public IActionResult CreateCategory(CategoryModel category) {
            
            int status = _categoryRepository.Save(category);
            if (ModelState.IsValid)
            {
                if (status == 1)
                {
                    TempData["Success"] = "Salvo com sucesso!";
                    return RedirectToAction("Categories");
                }
            }
            
            TempData["Error"] = "Não foi possível salvar a categoria!";
            throw new SystemException("Erro ao tentar salvar a categoria");
        }

        [HttpDelete]
        public IActionResult DeleteCategory(int id)
        {
            try
            {
                _categoryRepository.Delete(id);
                TempData["Sucesso"] = "Categoria deletada com sucesso!";
            }catch(Exception ex)
            {
                TempData["Error"] = "Não foi possível deletar. Err: " + ex.Message;
                return BadRequest();
            }

            return Ok();
        }


        public IActionResult Products()
        {
            return View("~/Views/Register/Products/Index.cshtml");
        }

        public IActionResult Clients()
        {
            return View("~/Views/Register/Clients/Index.cshtml");
        }
    }
}
