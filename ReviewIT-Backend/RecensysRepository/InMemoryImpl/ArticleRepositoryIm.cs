using System.Collections.Generic;
using RecensysRepository.DTO;
using RecensysRepository.Interfaces;

namespace RecensysRepository.InMemoryImpl
{
    public class ArticleRepositoryIm : IArticleRepository
    {


        private List<ArticleDTO> _articles = new List<ArticleDTO>()
        {
            new ArticleDTO() {A_Id = 1, Title = "Article 1", Author = "John Doe"},
            new ArticleDTO() {A_Id = 2, Title = "Article 2", Author = "Jane Doe"}
        };

        public IEnumerable<ArticleDTO> GetAll()
        {
            return _articles;
        }

        public void Create(ArticleDTO item)
        {
            _articles.Add(item);
        }

        public ArticleDTO Read(int id)
        {
            return _articles.Find(dto => dto.A_Id == id);
        }

        public void Update(ArticleDTO item)
        {
            _articles.RemoveAll(dto => dto.A_Id == item.A_Id);
            _articles.Add(item);
        }

        public void Delete(int id)
        {
            _articles.RemoveAll(dto => dto.A_Id == id);
        }

        public void Dispose()
        {
        }
    }
}