using Agenda_Contatos.Models;

namespace Agenda_Contatos.Repository
{
    public interface IContactRepository
    {
        ContactModel FindById(int id);
        List<ContactModel> FindAll(int userId);
        ContactModel Add(ContactModel contact);
        ContactModel Update(ContactModel contact);
        ContactModel Delete(int id);
        ContactModel Get(int id);

        bool DeleteContact(int id);


    }
}
