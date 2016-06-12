using System;
using System.Collections.Generic;
using RecensysRepository.DTO;

namespace RecensysRepository.Interfaces
{
    public interface IStageRepository : IDisposable
    {
        IEnumerable<StageDTO> GetAll();

        void Create(StageDTO item);

        StageDTO Read(int id);

        void Update(StageDTO item);

        void Delete(int id);
    }
}
