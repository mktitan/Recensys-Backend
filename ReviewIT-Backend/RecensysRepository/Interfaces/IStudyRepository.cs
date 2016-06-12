using System;
using System.Collections.Generic;
using RecensysRepository.DTO;

namespace RecensysRepository.Interfaces
{
    public interface IStudyRepository : IDisposable
    {
        IEnumerable<StudyDTO> GetAll();

        void Create(StudyDTO study);

        StudyDTO Read(int id);

        void Update(StudyDTO study);

        void Delete(int id);
    }
}