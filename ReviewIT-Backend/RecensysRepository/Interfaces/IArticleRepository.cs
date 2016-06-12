using System;
using System.Collections.Generic;
using RecensysRepository.DTO;

namespace RecensysRepository.Interfaces
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