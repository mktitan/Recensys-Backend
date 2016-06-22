using System.Collections.Generic;
using RecensysRepository.Entities;
using RecensysRepository.Interfaces;

namespace RecensysRepository.InMemoryImpl
{
    public class StudyRoleRepository : IStudyRoleRepository
    {

        private List<StudyRoleEntity> _roles = new List<StudyRoleEntity>()
        {
            new StudyRoleEntity() {Id = 1, Name = "Owner"},
            new StudyRoleEntity() {Id = 1, Name = "Researcher"},
        };
        public void Create(StudyRoleEntity item)
        {
            _roles.Add(item);
        }

        public void Delete(int id)
        {
            _roles.RemoveAll(dto => dto.Id == id);
        }

        public void Dispose()
        {
        }

        public IEnumerable<StudyRoleEntity> GetAll()
        {
            return _roles;
        }

        public StudyRoleEntity Read(int id)
        {
            return _roles.Find(dto => dto.Id == id);
        }

        public void Update(StudyRoleEntity item)
        {
            _roles.RemoveAll(dto => dto.Id == item.Id);
            _roles.Add(item);
        }
    }
}