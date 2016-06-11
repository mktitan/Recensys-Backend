using ReviewIT_Backend.Repository.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewIT_Backend.Repository.Interfaces
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
