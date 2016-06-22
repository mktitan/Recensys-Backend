using System;
using System.Collections.Generic;
using RecensysRepository.DTO;

namespace RecensysRepository.Interfaces
{
    public interface ITaskRepository : IDisposable
    {
        IEnumerable<TaskEntity> GetAll();

        void Create(TaskEntity item);

        TaskEntity Read(int id);

        void Update(TaskEntity item);

        void Delete(int id);
    }
}
