using ReviewIT_Backend.Repository.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewIT_Backend.Repository.Interfaces
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
