using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecensysBLL.BusinessLogicLayer;
using RecensysBLL.Models;
using RecensysRepository.DTO;
using RecensysRepository.Factory;

namespace Unit_Test
{
    [TestClass]
    public class UserBLLTest
    {
        [TestMethod]
        public void Add_ModelNotNull_Successful()
        {
            // Arrange
            var repo = new RepositoryFactoryMemory();
            var bll = new UserBLL(repo);
            var model = new UserModel();
            var precount = repo.GetUserRepo().GetAll().Count();

            // Act
            bll.Add(model);

            // Assert
            Assert.AreEqual(repo.GetUserRepo().GetAll().Count(), precount + 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Add_ModelNull_ThrowNullException()
        {
            // Arrange
            var repo = new RepositoryFactoryMemory();
            var bll = new UserBLL(repo);

            // Act
            bll.Add(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Add_ModelIdOutofRange_ThrowsArgumentException()
        {
            // Arrange
            var repo = new RepositoryFactoryMemory();
            var bll = new UserBLL(repo);
            var model = new UserModel
            {
                Id = -1
            };

            // Act
            bll.Add(model);
        }

        [TestMethod]
        public void Get_ElementExists_Successful()
        {
            // Arrange
            var repo = new RepositoryFactoryMemory();
            var bll = new UserBLL(repo);
            repo.GetUserRepo().Create(new UserDTO
            {
                U_Id = 10,
                FirstName = "Mathias",
                LastName = "Pedersen"
            });

            // Act
            var model = bll.Get(10);

            // Assert
            Assert.AreEqual(model.Id, 10);
            Assert.AreEqual(model.FirstName, "Mathias");
            Assert.AreEqual(model.LastName, "Pedersen");
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Get_NoSuchId_ThrowIndexOutOfRangeException()
        {
            // Arrange
            var repo = new RepositoryFactoryMemory();
            var bll = new UserBLL(repo);

            // Act
            var model = bll.Get(10);
        }

        [TestMethod]
        public void AssociateUserToStudy_GoodInput_Success()
        {
            // Arrange
            var repo = new RepositoryFactoryMemory();
            var bll = new UserBLL(repo);

            // Act
            bll.AssociateUserToStudy(10, 15, StudyRole.Guest);

            // Assert
            var storedDto = repo.GetUserStudyRelationRepository().Read(10, 15);
            Assert.AreEqual(storedDto.U_Id, 10);
            Assert.AreEqual(storedDto.S_Id, 15);
            Assert.AreEqual(storedDto.R_Id, (int) StudyRole.Guest);
        }

        [TestMethod]
        public void UnassociateUserToStudy_GoodInput_Success()
        {
            // Arrange
            var repo = new RepositoryFactoryMemory();
            var bll = new UserBLL(repo);
            repo.GetUserStudyRelationRepository().Create(new UserStudyRelationDTO
            {
                S_Id = 15,
                R_Id = 2,
                U_Id = 10
            });
            var count = repo.GetUserStudyRelationRepository().GetAll().Count();

            // Act
            bll.UnassociateUserToStudy(10, 15);

            // Assert
            Assert.AreEqual(count - 1, repo.GetUserStudyRelationRepository().GetAll().Count());
        }
    }
}