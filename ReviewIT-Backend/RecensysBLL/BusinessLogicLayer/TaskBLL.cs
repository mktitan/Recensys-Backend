using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using RecensysBLL.Models;
using RecensysBLL.Models.FullModels;
using RecensysRepository.Entities;
using RecensysRepository.Factory;

namespace RecensysBLL.BusinessLogicLayer
{
    public class TaskBLL
    {

        private readonly IRepositoryFactory _factory;

        public TaskBLL(IRepositoryFactory factory)
        {
            _factory = factory;
        }

        public List<TaskModel> GetTasks(int stageId, int userId)
        {
            var tasks = new List<TaskModel>();
            
            using (var taskRepo = _factory.GetTaskRepo())
            using (var typeRepo = _factory.GetDataTypeRepo())
            using (var fieldDataRepo = _factory.GetDataRepo())
            {
                var taskDtos = taskRepo.GetAll().Where(dto => dto.User_Id == userId);
                foreach (var dto in taskDtos)
                {
                    var task = new TaskModel() {Id = dto.Id, Data = new List<DataModel>()};

                    // Add data to taskModel
                    var dataEntities = fieldDataRepo.GetAll().Where(d => d.Task_Id == dto.Id);
                    foreach (var dataEntity in dataEntities)
                    {
                        var dataType = typeRepo.Read(dataEntity.DataType_Id);

                        task.Data.Add(new DataModel()
                        {
                            Id = dataEntity.Id,
                            Data = dataEntity.Data,
                            ArticleId = dataEntity.Article_Id,
                            DataType = dataType.Type,
                            DataTypeId = dataType.Id
                        });
                    }

                    tasks.Add(task);
                }
            }

            return tasks;
        }

        public void DeliverTask(TaskModel task)
        {
            using (var dataRepo = _factory.GetDataRepo())
            {
                /* TODO correct for new model
                foreach (var fields in task.Fields)
                {
                    foreach (var data in fields.Value)
                    {
                        fieldDataRepo.Update(new FieldDataDTO()
                        {
                            Id = data.Id,
                            Data = data.Data,
                            Field_Id = fields.Key.Id,
                            Article_Id = data.ArticleId,
                            Task_Id = task.Id
                        });
                    }
                }*/

                foreach (var data in task.Data)
                {
                    dataRepo.Update(new DataEntity()
                    {
                        Id = data.Id,
                        Data = data.Data,
                        DataType_Id = data.DataTypeId,
                        Task_Id = task.Id,
                        Article_Id = data.ArticleId,
                        Field_Id = data.
                    });
                }
            }
        }
    }
}