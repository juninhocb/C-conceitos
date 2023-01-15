using Agenda_Contatos.Filters;
using Agenda_Contatos.Models;
using Agenda_Contatos.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Agenda_Contatos.Controllers
{
    [PageForAdmin]
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public IActionResult Index()
        {
            List<UsuarioModel> users = _userRepository.FindAll();
            return View(users);
        }

        public IActionResult Delete(int id)
        {
            UsuarioModel user = _userRepository.FindById(id);
            return View(user);
        }

        public IActionResult Edit(int id)
        {
            UsuarioModel user= _userRepository.FindById(id);
            return View(user);
        }

        public IActionResult Create() {

            return View();
        }

        [HttpPost]
        public IActionResult Create(UsuarioModel user)
        {
            
            user.registerDate = DateTime.Now;

            try
            {

                _userRepository.Add(user);
                TempData["Success"] = "Usuário cadastrado com sucesso!";
                return RedirectToAction("Index");
                
            }
            catch (Exception err)
            {
                TempData["Error"] = $"Não foi possível cadastrar o usuário. Detalhe do erro: {err.Message}";
                return RedirectToAction("Index");
            }
            


        }

        [HttpPost]
        public IActionResult Edit(UsuarioModel user)
        {
            try
            {
               _userRepository.Update(user);
               TempData["Success"] = "Usuário alterado com sucesso!";
               return RedirectToAction("Index");
            }
            catch (Exception err)
            {
                TempData["Error"] = $"Não foi possível alterar o usuário. Detalhe do erro: {err.Message}";
                return RedirectToAction("Index");
            }
        }

        public IActionResult DeleteUser(int id)
        {
            try
            {
                _userRepository.DeleteUser(id);
                TempData["Success"] = "Usuário deletado com sucesso!";
                return RedirectToAction("Index");
            }
            catch (Exception err)
            {
                TempData["Error"] = $"Não foi possível deletar o usuário. Detalhe do erro: {err.Message}";
                return RedirectToAction("Index");
            }
        }



    }
}
