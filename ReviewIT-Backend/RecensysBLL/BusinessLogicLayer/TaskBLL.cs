using System.Collections.Generic;
using System.Linq;
using RecensysBLL.Models;
using RecensysRepository.DTO;
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
            var taskModels = new List<TaskModel>();
            
            using (var taskRepo = _factory.GetTaskRepo())
            using (var fieldRepo = _factory.GetFieldRepo())
            using (var fieldDataRepo = _factory.GetFieldDataRepo())
            {
                var tasks = taskRepo.GetAll().Where(dto => dto.U_Id == userId && dto.S_Id == stageId);
                foreach (var task in tasks)
                {
                    var fields = new Dictionary<FieldModel, List<FieldDataModel>>();

                    var fieldData = fieldDataRepo.GetAll().Where(dto => dto.Task_Id == task.T_Id);
                    foreach (var data in fieldData)
                    {
                        var field = fieldRepo.Read(data.Field_Id);
                        fields[new FieldModel() {Id = field.F_Id, FieldType = (FieldType)field.FieldType}].Add(new FieldDataModel() {Id = data.F_Id, ArticleId = data.Article_Id, Data = data.Data});
                        taskModels.Add(new TaskModel() {Id = task.T_Id, Fields = fields});
                    }
                }
            }

            return taskModels;
        }

        public void DeliverTask(TaskModel task)
        {
            using (var fieldDataRepo = _factory.GetFieldDataRepo())
            {
                foreach (var fields in task.Fields)
                {
                    foreach (var data in fields.Value)
                    {
                        fieldDataRepo.Update(new FieldDataDTO()
                        {
                            F_Id = data.Id,
                            Data = data.Data,
                            Field_Id = fields.Key.Id,
                            Article_Id = data.ArticleId,
                            Task_Id = task.Id
                        });
                    }
                }
            }
        }
    }
}