using System.Collections.Generic;
using RecensysRepository.DTO;
using RecensysRepository.Interfaces;

namespace RecensysRepository.InMemoryImpl
{
    public class CredentialsRepositoryIm : ICredentialsRepository
    {

        private List<CredentialsDTO> _credentials = new List<CredentialsDTO>()
        {
            new CredentialsDTO() {U_Id = 1, C_Id = 1, User_Name = "Mat", Password_Salt = "SALT"}
        };

        public void Dispose()
        {
        }

        public IEnumerable<CredentialsDTO> GetAll()
        {
            return _credentials;
        }

        public void Create(CredentialsDTO item)
        {
            _credentials.Add(item);
        }

        public CredentialsDTO Read(int id)
        {
            return _credentials.Find(dto => dto.C_Id == id);
        }

        public void Update(CredentialsDTO item)
        {
            _credentials.RemoveAll(dto => dto.C_Id == item.C_Id);
            _credentials.Add(item);
        }

        public void Delete(int id)
        {
            _credentials.RemoveAll(dto => dto.C_Id == id);
        }
    }
}