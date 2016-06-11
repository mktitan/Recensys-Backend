using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ReviewIT_Backend.Repository.DTO;

namespace ReviewIT_Backend.Repository
{
    public class StageRepositoryIm : IStageRepository
    {

        private List<StageDTO> _stages = new List<StageDTO>()
        {
            new StageDTO() {S_Id = 1, Name = "Stage 1", Description = "Description for stage 1", InProgress = true, Study_Id = 1, Strategy_Id = 1},
            new StageDTO() {S_Id = 2, Name = "Stage 2", Description = "Description for stage 2", InProgress = false, Study_Id = 1, Strategy_Id = 1}
        };

        public void Dispose()
        {
        }

        public IEnumerable<StageDTO> GetAll()
        {
            return _stages;
        }

        public void Create(StageDTO item)
        {
            _stages.Add(item);
        }

        public StageDTO Read(int id)
        {
            return _stages.Find(dto => dto.S_Id == id);
        }

        public void Update(StageDTO item)
        {
            _stages.RemoveAll(dto => dto.S_Id == item.S_Id);
            _stages.Add(item);
        }

        public void Delete(int id)
        {
            _stages.RemoveAll(dto => dto.S_Id == id);
        }
    }
}