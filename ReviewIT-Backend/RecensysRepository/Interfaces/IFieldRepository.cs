using System;
using System.Collections.Generic;
using RecensysRepository.DTO;

namespace RecensysRepository.Interfaces
{
    public interface IFieldRepository : IDisposable
    {
        IEnumerable<FieldDTO> GetAll();

        void Create(FieldDTO item);

        FieldDTO Read(int id);

        void Update(FieldDTO item);

        void Delete(int id);
    }
}
