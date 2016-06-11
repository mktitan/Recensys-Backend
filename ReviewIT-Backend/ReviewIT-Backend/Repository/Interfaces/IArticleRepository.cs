using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ReviewIT_Backend.Repository.DTO;

namespace ReviewIT_Backend.Repository
{
    public interface IArticleRepository : IDisposable
    {
        IEnumerable<ArticleDTO> GetAll();

        void Create(ArticleDTO item);

        ArticleDTO Read(int id);

        void Update(ArticleDTO item);

        void Delete(int id);
    }
}