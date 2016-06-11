using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReviewIT_Backend.Repository.DTO;

namespace ReviewIT_Backend.Repository.Interfaces
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
