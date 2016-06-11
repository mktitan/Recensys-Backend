using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ReviewIT_Backend.Repository.DTO;
using ReviewIT_Backend.Repository.Interfaces;

namespace ReviewIT_Backend.Repository.InMemoryImpl
{
    public class TaskRepositoryIm : ITaskRepository
    {

        private List<TaskDTO> _tasks = new List<TaskDTO>();

        public void Dispose()
        {
        }

        public IEnumerable<TaskDTO> GetAll()
        {
            return _tasks;
        }

        public void Create(TaskDTO item)
        {
            _tasks.Add(item);
        }

        public TaskDTO Read(int id)
        {
            return _tasks.Find(dto => dto.T_Id == id);
        }

        public void Update(TaskDTO item)
        {
            _tasks.RemoveAll(dto => dto.T_Id == item.T_Id);
            _tasks.Add(item);
        }

        public void Delete(int id)
        {
            _tasks.RemoveAll(dto => dto.T_Id == id);
        }
    }
}