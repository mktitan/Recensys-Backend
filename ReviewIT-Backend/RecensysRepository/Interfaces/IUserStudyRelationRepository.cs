using System;
using System.Collections.Generic;
using RecensysRepository.DTO;

namespace RecensysRepository.Interfaces
{
    public interface IUserStudyRelationRepository : IDisposable
    {
        IEnumerable<UserStudyRelationDTO> GetAll();

        void Create(UserStudyRelationDTO item);

        UserStudyRelationDTO Read(int uid, int sid);

        void Update(UserStudyRelationDTO item);

        void Delete(int uid, int sid);
    }
}
