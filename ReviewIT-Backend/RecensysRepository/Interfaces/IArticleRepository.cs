using System;
using System.Collections.Generic;
using RecensysRepository.DTO;

namespace RecensysRepository.Interfaces
{
    public interface IArticleRepository : IDisposable
    {
        IEnumerable<ArticleEntity> GetAll();

        void Create(ArticleEntity item);

        ArticleEntity Read(int id);

        void Update(ArticleEntity item);

        void Delete(int id);
    }
}