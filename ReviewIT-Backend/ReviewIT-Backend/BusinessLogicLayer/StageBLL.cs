using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ReviewIT_Backend.Models;
using ReviewIT_Backend.Repository.Factory;

namespace ReviewIT_Backend.BusinessLogicLayer
{
    public class StageBLL
    {

        private readonly IRepositoryFactory _factory;
        public StageBLL(IRepositoryFactory factory)
        {
            _factory = factory;
        }

        public StageModel Get(int id, int userId)
        {
            using (var repo = _factory.GetStageRepo())
            {

                var dto = repo.Read(id);

                return new StageModel()
                {
                    Id = id,
                    Name = dto.Name,
                    Description = dto.Description
                };
            }
        }

        


    }
}