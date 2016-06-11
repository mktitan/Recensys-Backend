using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ReviewIT_Backend.Models;
using ReviewIT_Backend.Models.OverviewModels;
using ReviewIT_Backend.Repository;
using ReviewIT_Backend.Repository.DTO;
using ReviewIT_Backend.Repository.Factory;

namespace ReviewIT_Backend.BusinessLogicLayer
{
    public class StudyBLL
    {

        private readonly IRepositoryFactory _factory;

        public StudyBLL(IRepositoryFactory factory)
        {
            _factory = factory;
        }

        public void AddNew(StudyOverviewModel studyOverview)
        {
            using (var srepo = _factory.GetStudyRepo())
            {
                srepo.Create(new StudyDTO()
                {
                    S_Id = studyOverview.Id,
                    Name = studyOverview.Name,
                    Description = studyOverview.Description,
                });
            }
        }

        public List<StudyOverviewModel> Get()
        {
            using (var srepo = _factory.GetStudyRepo())
            {
                var dtos = srepo.GetAll();
                var res = new List<StudyOverviewModel>();
                foreach (var dto in dtos)
                {
                    res.Add(new StudyOverviewModel()
                    {
                        Id = dto.S_Id,
                        Name = dto.Name,
                        Description = dto.Description
                    });
                }
                return res;
            }
        }

        public StudyModel Get(int id)
        {
            
            using (var srepo = _factory.GetStudyRepo())
            using (var urepo = _factory.GetUserRepo())
            using (var arepo = _factory.GetArticleRepo())
            using (var strepo = _factory.GetStageRepo())
            {
                var sdto = srepo.Read(id);
                var adtos = arepo.GetAll().Where(dto => dto.S_Id == id).Take(10);
                var stdtos = strepo.GetAll().Where(dto => dto.Study_Id == id);

                // build roles dictionary for studyOverview
                

                // build articles
                var articles = new List<ArticleModel>();
                foreach (var adto in adtos)
                {
                    articles.Add(new ArticleModel()
                    {
                        Id = adto.A_Id,
                        Name = adto.Title
                    });
                }

                // build stages
                var stages = new List<StageOverviewModel>();
                foreach (var stdto in stdtos)
                {
                    stages.Add(new StageOverviewModel()
                    {
                        Id = stdto.S_Id,
                        Name = stdto.Name
                    });
                }

                return new StudyModel()
                {
                    Id = sdto.S_Id,
                    Name = sdto.Name,
                    Description = sdto.Description,
                    Articles = articles,
                    Stages = stages
                };
            }
        }

        public void Remove(int id)
        {
            using (var srepo = _factory.GetStudyRepo())
            {
                srepo.Delete(id);
            }
        }


        public void AddStage(StageModel stage)
        {
            using (var repo = _factory.GetStageRepo())
            using (var srepo = _factory.GetStrategyRepository())
            {
                /*
                srepo.Update(new StrategyDTO()
                {
                    S_Id = stage.Strategy.Id,
                    Name = stage.Strategy.Name
                });*/

                repo.Create(new StageDTO()
                {
                    Name = stage.Name,
                    Description = stage.Description
                });
            }
        }

        public void RemoveStage(int id)
        {
            using (var repo = _factory.GetStageRepo())
            {
                repo.Delete(id);
            }
        }

    }
}