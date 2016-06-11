using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReviewIT_Backend.Repository.DTO;

namespace ReviewIT_Backend.Repository
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
