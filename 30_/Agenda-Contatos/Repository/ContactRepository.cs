using Agenda_Contatos.Data;
using Agenda_Contatos.Models;

namespace Agenda_Contatos.Repository
{
    public class ContactRepository : IContactRepository
    {
        private readonly DataContext _contactRepository;
        public ContactRepository(DataContext dataContext) {
            this._contactRepository = dataContext;
        }
        public ContactModel Add(ContactModel contact)
        {
            _contactRepository.Add(contact);  //insere 
            _contactRepository.SaveChanges(); //commit
            return contact;
        }

        public ContactModel Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ContactModel FindById(int id)
        {
            return _contactRepository.Contacts.FirstOrDefault(x => x.Id == id);
        }

        public List<ContactModel> FindAll()
        {
            return _contactRepository.Contacts.ToList();
        }

        public ContactModel Get(int id)
        {
            throw new NotImplementedException();
        }

        public ContactModel Update(ContactModel contact)
        {
            ContactModel contactDB = FindById(contact.Id);

            if (contactDB == null) throw new System.Exception("Ocorreu um problema ao atualizar os dados!");

            contactDB.Name = contact.Name;
            contactDB.Email = contact.Email;
            contactDB.Phone = contact.Phone;

            _contactRepository.Contacts.Update(contactDB);
            _contactRepository.SaveChanges();
            return contactDB;
        }

        public bool DeleteContact(int id)
        {
            ContactModel contactDB = FindById(id);

            if (contactDB == null) throw new System.Exception("Ocorreu um problema ao deletar o contato!");

            _contactRepository.Contacts.Remove(contactDB);
            _contactRepository.SaveChanges();

            return true;


        }
    }
}
