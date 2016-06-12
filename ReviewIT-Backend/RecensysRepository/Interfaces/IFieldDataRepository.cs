using System;
using System.Collections.Generic;
using RecensysRepository.DTO;

namespace RecensysRepository.Interfaces
{
    public interface IFieldDataRepository : IDisposable
    {
        IEnumerable<FieldDataDTO> GetAll();

        void Create(FieldDataDTO item);

        FieldDataDTO Read(int id);

        void Update(FieldDataDTO item);

        void Delete(int id);
    }
}
