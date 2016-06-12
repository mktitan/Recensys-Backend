using System;
using System.Collections.Generic;
using RecensysRepository.DTO;

namespace RecensysRepository.Interfaces
{
    public interface IStudyRoleRepository : IDisposable
    {
        IEnumerable<StudyRoleDTO> GetAll();

        void Create(StudyRoleDTO item);

        StudyRoleDTO Read(int id);

        void Update(StudyRoleDTO item);

        void Delete(int id);
    }
}
