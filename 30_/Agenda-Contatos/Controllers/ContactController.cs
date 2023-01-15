using Agenda_Contatos.Data;
using Agenda_Contatos.Filters;
using Agenda_Contatos.Models;
using Agenda_Contatos.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;

namespace Agenda_Contatos.Controllers
{
    [PageForLoggedUser]
    public class ContactController : Controller
    {
        private readonly IContactRepository _contactRepository;

        public ContactController(IContactRepository contactRepository)
        {
            _contactRepository= contactRepository;
        }
        public IActionResult Index()
        {
            List<ContactModel> contacts = _contactRepository.FindAll();
            
            return View(contacts);
            
        }

        public IActionResult Create()
        {
            
            return View();
        }

        
        public IActionResult Edit(int id)
        {
            ContactModel contact = _contactRepository.FindById(id);
            return View(contact);
        }
        public IActionResult Delete(int id)
        {
            ContactModel contact = _contactRepository.FindById(id);
            return View(contact);
        }


        public IActionResult Clean()
        {
            Console.WriteLine("Teste do botão");
            return View();
        }

        [HttpPost]
        public IActionResult Create(ContactModel contact)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _contactRepository.Add(contact);
                    TempData["Success"] = "Contato cadastrado com sucesso!";
                    return RedirectToAction("Index");
                }
                return View(contact);
            } catch(Exception err)
            {
                TempData["Error"] = $"Não foi possível cadastrar o contato. Detalhe do erro: {err.Message}";
                return RedirectToAction("Index");
            }
            

        }

        [HttpPost]
        public IActionResult Edit(ContactModel contact)
        {
            try {

                if (ModelState.IsValid)
                {
                    _contactRepository.Update(contact);
                    TempData["Success"] = "Contato alterado com sucesso!";
                    return RedirectToAction("Index");
                }
                
                return View(contact);

            } catch(Exception err)
            {
                TempData["Error"] = $"Não foi possível alterar o contato. Detalhe do erro: {err.Message}";
                return RedirectToAction("Index");
            }
        }

        public IActionResult DeleteContact(int id)
        {
            try
            {
                _contactRepository.DeleteContact(id);
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
