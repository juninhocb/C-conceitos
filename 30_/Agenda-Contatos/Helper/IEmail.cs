namespace Agenda_Contatos.Helper
{
    public interface IEmail
    {

        bool Send(string Email,  string Subject,  string Message);
    }
}
