using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReviewIT_Backend.BusinessLogicLayer;
using ReviewIT_Backend.Models.OverviewModels;
using ReviewIT_Backend.Repository.DTO;
using ReviewIT_Backend.Repository.Factory;

namespace Unit_Test
{
    [TestClass]
    public class StudyBLLTest
    {
        [TestMethod]
        public void AddNew_GoodInput_Successful()
        {
            // Arrange
            var repo = new RepositoryFactoryMemory();
            var bll = new StudyBLL(repo);
            var model = new StudyOverviewModel()
            {
                Id = 10,
                Name = "name",
                Description = "desc"
            };
            var count = repo.GetStudyRepo().GetAll().Count();

            // Act
            bll.AddNew(model);

            // Assert
            Assert.AreEqual(count+1, repo.GetStudyRepo().GetAll().Count());
        }

        [TestMethod]
        public void Get__Successful()
        {
            // Arrange
            var repo = new RepositoryFactoryMemory();
            var bll = new StudyBLL(repo);
            var model = new StudyOverviewModel()
            {
                Id = 10,
                Name = "name",
                Description = "desc"
            };
            var count = repo.GetStudyRepo().GetAll().Count();

            // Act
            var list = bll.Get();

            // Assert
            Assert.AreEqual(count, list.Count);
        }

        [TestMethod]
        public void Get_StudyTableDataExists_Successful()
        {
            // Arrange
            var repo = new RepositoryFactoryMemory();
            var bll = new StudyBLL(repo);
            repo.GetStudyRepo().Create(new StudyDTO()
            {
                S_Id = 10,
                Name = "name",
                Description = "desc"
            });
            
            
            // Act
            var model = bll.Get(10);

            // Assert
            Assert.AreEqual(10, model.Id);
            Assert.AreEqual("name", model.Name);
            Assert.AreEqual("desc", model.Description);
        }

        [TestMethod]
        public void Get_AssociatedStages_Successful()
        {
            // Arrange
            var repo = new RepositoryFactoryMemory();
            var bll = new StudyBLL(repo);
            repo.GetStudyRepo().Create(new StudyDTO()
            {
                S_Id = 10,
                Name = "name",
                Description = "desc"
            });
            var bcount = repo.GetStageRepo().GetAll().Count(d => d.Study_Id == 10);
            repo.GetStageRepo().Create(new StageDTO()
            {
                Study_Id = 10,
                Name = "Stage1",
                S_Id = 15,
            });
            repo.GetStageRepo().Create(new StageDTO()
            {
                Study_Id = 10,
                Name = "Stage2",
                S_Id = 16,
            });


            // Act
            var model = bll.Get(10);

            // Assert
            var stage = model.Stages.Find(s => s.Id == 15);
            Assert.AreEqual(bcount+2, model.Stages.Count);
            Assert.IsNotNull(stage);
            Assert.AreEqual("Stage1", stage.Name);
        }

        [TestMethod]
        public void Remove_GoodId_Successful()
        {
            // Arrange
            var repo = new RepositoryFactoryMemory();
            var bll = new StudyBLL(repo);
            repo.GetStudyRepo().Create(new StudyDTO()
            {
                S_Id = 13
            });
            var count = repo.GetStudyRepo().GetAll().Count();

            // Act
            bll.Remove(13);

            // Assert
            Assert.AreEqual(count-1, repo.GetStudyRepo().GetAll().Count());
        }

        [TestMethod]
        public void AddStage_GoodInput_StageAdded()
        {
            // Arrange
            var repo = new RepositoryFactoryMemory();
            var bll = new StudyBLL(repo);
        }
    }
}
