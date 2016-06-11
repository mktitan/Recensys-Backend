using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ReviewIT_Backend.Models;
using ReviewIT_Backend.Repository.DTO;
using ReviewIT_Backend.Repository.Factory;

namespace ReviewIT_Backend.BusinessLogicLayer
{
    public class UserBLL
    {

        private readonly IRepositoryFactory _factory;
        public UserBLL(IRepositoryFactory factory)
        {
            _factory = factory;
        }

        public void Add(UserModel model)
        {
            if (model == null) throw new ArgumentNullException("Model null reference");
            if (model.Id < 0) throw new ArgumentException("id under 0");

            using (var urepo = _factory.GetUserRepo())
            {
                urepo.Create(new UserDTO()
                {
                    U_Id = model.Id,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Metadata = model.Metadata
                });
            }
        }

        public UserModel Get(int id)
        {
            using (var urepo = _factory.GetUserRepo())
            {
                var dto = urepo.Read(id);
                if (dto == null) throw new IndexOutOfRangeException();

                return new UserModel()
                {
                    Id = dto.U_Id,
                    FirstName = dto.FirstName,
                    LastName = dto.LastName,
                    Metadata = dto.Metadata
                };
            }
        }

        public void AssociateUserToStudy(int userId, int studyId, StudyRole role)
        {
            using (var repo = _factory.GetUserStudyRelationRepository())
            {
                repo.Create(new UserStudyRelationDTO()
                {
                    U_Id = userId,
                    S_Id = studyId,
                    R_Id = (int)role
                });
            }
        }

        public void UnassociateUserToStudy(int userId, int studyId)
        {
            using (var repo = _factory.GetUserStudyRelationRepository())
            {
                repo.Delete(userId, studyId);
            }
        }

        
    }
}