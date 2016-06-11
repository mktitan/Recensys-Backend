using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ReviewIT_Backend.Models;
using ReviewIT_Backend.Repository.DTO;

namespace ReviewIT_Backend.Repository
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