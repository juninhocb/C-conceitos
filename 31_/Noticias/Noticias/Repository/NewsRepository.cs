using Noticias.Data;
using Noticias.Models;

namespace Noticias.Repository
{
    public class NewsRepository : INewsRepository
    {
        private readonly DataContext _newsRepository;
        public NewsRepository(DataContext dataContext) {
            this._newsRepository = dataContext;
        }
        public NewsModel Create(NewsModel notice)
        {
            _newsRepository.News.Add(notice);
            _newsRepository.SaveChanges();
            return notice;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool DeleteNews(int id)
        {
            NewsModel contactDB = FindById(id);

            if (contactDB == null) throw new System.Exception("Ocorreu um problema ao deletar o contato!");

            _newsRepository.News.Remove(contactDB);
            _newsRepository.SaveChanges();

            return true;
        }

        public List<NewsModel> FindAll()
        {
            return _newsRepository.News.ToList();
        }

        public NewsModel FindById(int id)
        {
            List<NewsModel> listNews = _newsRepository.News.ToList(); 
            foreach (NewsModel noticeCompare in listNews)
            {
                if (noticeCompare.Id == id) return noticeCompare;
            }
            return null;
        }

        public NewsModel Update(NewsModel notice)
        {
            NewsModel contactDB = FindById(notice.Id);

            if (contactDB == null) throw new System.Exception("Ocorreu um problema ao atualizar os dados!");

            contactDB.Title = notice.Title;
            contactDB.Description = notice.Description;
            contactDB.Category = notice.Category;

            _newsRepository.News.Update(contactDB);
            _newsRepository.SaveChanges();
            return contactDB;
        }
    }
}
