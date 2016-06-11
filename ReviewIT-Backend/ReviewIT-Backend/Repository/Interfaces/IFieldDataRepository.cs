using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReviewIT_Backend.Repository.DTO;

namespace ReviewIT_Backend.Repository.Interfaces
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
