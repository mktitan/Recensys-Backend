using System.Collections.Generic;
using RecensysRepository.Entities;
using RecensysRepository.Interfaces;

namespace RecensysRepository.InMemoryImpl
{
    public class UserStudyRelationRepositoryIm : IUserStudyRelationRepository
    {

        private List<UserStudyRelationEntity> _relations = new List<UserStudyRelationEntity>() {
            new UserStudyRelationEntity() { StudyRole_Id = 1, Study_Id = 1, Id = 1},
            new UserStudyRelationEntity() { StudyRole_Id = 1, Study_Id = 1, Id = 2},
        };

        public void Create(UserStudyRelationEntity item)
        {
            _relations.Add(item);
        }

        public void Delete(int uid, int sid)
        {
            _relations.RemoveAll(dto => dto.Id == uid && dto.Study_Id == sid);
        }

        public void Dispose()
        {
        }

        public IEnumerable<UserStudyRelationEntity> GetAll()
        {
            return _relations;
        }

        public UserStudyRelationEntity Read(int uid, int sid)
        {
            return _relations.Find(dto => dto.Id == uid && dto.Study_Id == sid);
        }

        public void Update(UserStudyRelationEntity item)
        {
            _relations.RemoveAll(dto => dto.Id == item.Id && dto.Study_Id == item.Study_Id);
            _relations.Add(item);
        }
    }
}