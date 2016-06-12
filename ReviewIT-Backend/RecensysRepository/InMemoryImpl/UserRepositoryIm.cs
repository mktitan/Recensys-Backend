using System.Collections.Generic;
using RecensysRepository.DTO;
using RecensysRepository.Interfaces;

namespace RecensysRepository.InMemoryImpl
{
    public class UserRepositoryIm : IUserRepository
    {

        private List<UserDTO> _users = new List<UserDTO>()
        {
            new UserDTO() {U_Id = 1, LastName = "Pedersen", FirstName = "Mathias"},
            new UserDTO() {U_Id = 2, LastName = "Cholewa", FirstName = "Jacob"}
        };
        private List<StudyRoleDTO> _roles = new List<StudyRoleDTO>()
        {
            new StudyRoleDTO() {R_Id = 1, Name = "Admin" }
        };
        private List<UserStudyRelationDTO> _userStudyRelation = new List<UserStudyRelationDTO>()
        {
            new UserStudyRelationDTO() {U_Id = 1, S_Id = 1, R_Id = 1 }
        };

        public void Dispose()
        {
        }

        public IEnumerable<UserDTO> GetAll()
        {
            return _users;
        }

        public void Create(UserDTO user)
        {
            _users.Add(user);
        }

        public UserDTO Read(int id)
        {
            return _users.Find(dto => dto.U_Id == id);
        }

        public void Update(UserDTO user)
        {
            _users.RemoveAll(dto => dto.U_Id == user.U_Id);
            _users.Add(user);
        }

        public void Delete(int id)
        {
            _users.RemoveAll(dto => dto.U_Id == id);
        }
        
    }
}