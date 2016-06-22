using System;
using System.Collections.Generic;
using RecensysRepository.DTO;

namespace RecensysRepository.Interfaces
{
    public interface IStrategyRepository : IDisposable
    {
        IEnumerable<StrategyEntity> GetAll();

        void Create(StrategyEntity item);

        StrategyEntity Read(int id);

        void Update(StrategyEntity item);

        void Delete(int id);
    }
}
