using System;
using System.Collections.Generic;
using RecensysRepository.DTO;

namespace RecensysRepository.Interfaces
{
    public interface IStudyRoleRepository : IDisposable
    {
        IEnumerable<StudyRoleEntity> GetAll();

        void Create(StudyRoleEntity item);

        StudyRoleEntity Read(int id);

        void Update(StudyRoleEntity item);

        void Delete(int id);
    }
}
