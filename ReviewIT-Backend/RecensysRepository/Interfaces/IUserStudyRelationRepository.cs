using System;
using System.Collections.Generic;
using RecensysRepository.DTO;

namespace RecensysRepository.Interfaces
{
    public interface IUserStudyRelationRepository : IDisposable
    {
        IEnumerable<UserStudyRelationEntity> GetAll();

        void Create(UserStudyRelationEntity item);

        UserStudyRelationEntity Read(int uid, int sid);

        void Update(UserStudyRelationEntity item);

        void Delete(int uid, int sid);
    }
}
