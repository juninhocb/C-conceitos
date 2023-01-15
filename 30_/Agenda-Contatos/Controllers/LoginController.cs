using Agenda_Contatos.Helper;
using Agenda_Contatos.Models;
using Agenda_Contatos.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Agenda_Contatos.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly Helper.ISession _session;
        
        public LoginController(IUserRepository userRepository, Helper.ISession session)
        {
            _userRepository = userRepository;
            _session = session;
        }

        public IActionResult Index()
        {
            //Se o usuário estiver logado, redirecionar para a home 
            if (_session.SearchUserSession() != null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpPost]
        
        public IActionResult Enter(LoginModel loginCredentials)
        {
            try
            {
                
                if (ModelState.IsValid)
                {

                    UsuarioModel user = _userRepository.GetUserByLogin(loginCredentials.Login);

                    if (user != null)
                    {
                        if (user.ValidPassword(loginCredentials.Password))
                        {
                            _session.CreateUserSession(user);
                            return RedirectToAction("Index", "Home");
                        }
                        TempData["Error"] = "Senha inválida. Tente novamente";
                    }

                    

                    TempData["Error"] = "Usuário ou senha inválidos. Tente novamente"; 
                    
                }

                return View("Index");

            }catch(Exception ex){

                TempData["Error"] = $"Não foi possível realizar o login. Err: {ex.Message}" ;
                return RedirectToAction("Index");

            }
        }

        public IActionResult Exit()
        {
            _session.RemoveUserSession();
            return RedirectToAction("Index", "Login");
        }

        public IActionResult ResetPassword()
        {

            return View();
        }

        [HttpPost]

        public IActionResult SendEmailReset(ResetEmailModel credentials)
        {

            try { 
                if (ModelState.IsValid)
                {
                    UsuarioModel user = _userRepository.FindUserByLoginAndEmail(credentials.Email, credentials.Login);
                    
                    if (user != null)
                    {
                        string newPassword = user.GenPassword();

                        TempData["Success"] = "Um email foi enviado com sua nova senha";
                    } else
                    {
                        TempData["Error"] = "Usuário não encotnrado";
                    }

                    return RedirectToAction("Index", "Login");


                }
            } catch(Exception ex)
            {
                TempData["Error"] = $"Não foi possível redefinir a senha. Err: {ex.Message}";
                return RedirectToAction("Index", "Login");
            }

            return RedirectToAction("Index", "Login");
        }
    }
}
