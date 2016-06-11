using ReviewIT_Backend.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ReviewIT_Backend.Repository.DTO;

namespace ReviewIT_Backend.Repository.InMemoryImpl
{
    public class UserStudyRelationRepositoryIm : IUserStudyRelationRepository
    {

        private List<UserStudyRelationDTO> _relations = new List<UserStudyRelationDTO>() {
            new UserStudyRelationDTO() { R_Id = 1, S_Id = 1, U_Id = 1},
            new UserStudyRelationDTO() { R_Id = 1, S_Id = 1, U_Id = 2},
        };

        public void Create(UserStudyRelationDTO item)
        {
            _relations.Add(item);
        }

        public void Delete(int uid, int sid)
        {
            _relations.RemoveAll(dto => dto.U_Id == uid && dto.S_Id == sid);
        }

        public void Dispose()
        {
        }

        public IEnumerable<UserStudyRelationDTO> GetAll()
        {
            return _relations;
        }

        public UserStudyRelationDTO Read(int uid, int sid)
        {
            return _relations.Find(dto => dto.U_Id == uid && dto.S_Id == sid);
        }

        public void Update(UserStudyRelationDTO item)
        {
            _relations.RemoveAll(dto => dto.U_Id == item.U_Id && dto.S_Id == item.S_Id);
            _relations.Add(item);
        }
    }
}