using System.Collections.Generic;
using RecensysRepository.DTO;
using RecensysRepository.Interfaces;

namespace RecensysRepository.InMemoryImpl
{
    public class StudyRoleRepository : IStudyRoleRepository
    {

        private List<StudyRoleDTO> _roles = new List<StudyRoleDTO>()
        {
            new StudyRoleDTO() {R_Id = 1, Name = "Owner"},
            new StudyRoleDTO() {R_Id = 1, Name = "Researcher"},
        };
        public void Create(StudyRoleDTO item)
        {
            _roles.Add(item);
        }

        public void Delete(int id)
        {
            _roles.RemoveAll(dto => dto.R_Id == id);
        }

        public void Dispose()
        {
        }

        public IEnumerable<StudyRoleDTO> GetAll()
        {
            return _roles;
        }

        public StudyRoleDTO Read(int id)
        {
            return _roles.Find(dto => dto.R_Id == id);
        }

        public void Update(StudyRoleDTO item)
        {
            _roles.RemoveAll(dto => dto.R_Id == item.R_Id);
            _roles.Add(item);
        }
    }
}