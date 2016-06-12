using System;
using System.Collections.Generic;
using RecensysRepository.DTO;

namespace RecensysRepository.Interfaces
{
    public interface IStrategyRepository : IDisposable
    {
        IEnumerable<StrategyDTO> GetAll();

        void Create(StrategyDTO item);

        StrategyDTO Read(int id);

        void Update(StrategyDTO item);

        void Delete(int id);
    }
}
