using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ReviewIT_Backend.Repository.DTO;
using ReviewIT_Backend.Repository.Interfaces;

namespace ReviewIT_Backend.Repository.InMemoryImpl
{
    public class StrategyRepositoryIm : IStrategyRepository
    {

        private List<StrategyDTO> _strategies = new List<StrategyDTO>()
        {
            new StrategyDTO() {S_Id = 1, Name = "Strategy 1", Description = "Description for strategy 1"},
            new StrategyDTO() {S_Id = 2, Name = "Strategy 2", Description = "Description for strategy 2"},
        };

        public void Dispose()
        {
        }

        public IEnumerable<StrategyDTO> GetAll()
        {
            return _strategies;
        }

        public void Create(StrategyDTO item)
        {
            _strategies.Add(item);
        }

        public StrategyDTO Read(int id)
        {
            return _strategies.Find(dto => dto.S_Id == id);
        }

        public void Update(StrategyDTO item)
        {
            _strategies.RemoveAll(dto => dto.S_Id == item.S_Id);
            _strategies.Add(item);
        }

        public void Delete(int id)
        {
            _strategies.RemoveAll(dto => dto.S_Id == id);
        }
    }
}