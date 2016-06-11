using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewIT_Backend.Repository.DTO
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
