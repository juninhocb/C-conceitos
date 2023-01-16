using Agenda_Contatos.Models;
using Agenda_Contatos.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Agenda_Contatos.Controllers
{
    public class ChangePasswordController : Controller
    {

        private readonly IUserRepository _userRepository;
        private readonly Helper.ISession _session;

        public ChangePasswordController(IUserRepository userRepository, Helper.ISession session)
        {
            _userRepository = userRepository;
            _session = session; 
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Change(ChangePasswordModel password)
        {

            try{ 
                if (ModelState.IsValid)
                {
                    UsuarioModel loggedUser = _session.SearchUserSession();
                    password.Id = loggedUser.id;
                    _userRepository.ChangePassword(password);
                    TempData["Success"] = "Senha alterada com sucesso!";
                    return View("Index", password);
                }


                return View("Index", password);

            } catch (Exception ex)
            {
                TempData["Error"] = $"Não foi possível alterar a senha. Err: {ex.Message}";
                return View("Index", password);
            }
            return View();
        }
    }
}
