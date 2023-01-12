using Noticias.Models;

namespace Noticias.Repository
{
    public interface INewsRepository
    {
        public NewsModel Create(NewsModel notice);
        public NewsModel Update(NewsModel notice);
        public void Delete(int id);
        public NewsModel FindById(int id);
        public List<NewsModel> FindAll();
        public bool DeleteNews(int id);
    }
}
