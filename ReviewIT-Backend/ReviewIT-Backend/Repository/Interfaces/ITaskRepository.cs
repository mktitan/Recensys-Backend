using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReviewIT_Backend.Repository.DTO;

namespace ReviewIT_Backend.Repository.Interfaces
{
    public interface ITaskRepository : IDisposable
    {
        IEnumerable<TaskDTO> GetAll();

        void Create(TaskDTO item);

        TaskDTO Read(int id);

        void Update(TaskDTO item);

        void Delete(int id);
    }
}
