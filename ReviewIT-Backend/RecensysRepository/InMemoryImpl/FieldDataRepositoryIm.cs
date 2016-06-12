using System.Collections.Generic;
using RecensysRepository.DTO;
using RecensysRepository.Interfaces;

namespace RecensysRepository.InMemoryImpl
{
    public class FieldDataRepositoryIm : IFieldDataRepository
    {

        private List<FieldDataDTO> _fieldData = new List<FieldDataDTO>()
        {
            new FieldDataDTO() {F_Id = 1, Field_Id = 1, Data = "jsondata"},
            new FieldDataDTO() {F_Id = 2, Field_Id = 1, Data = "jsondata"},
            new FieldDataDTO() {F_Id = 3, Field_Id = 1, Data = "jsondata"},
            new FieldDataDTO() {F_Id = 4, Field_Id = 1, Data = "jsondata"},
        };

        public void Dispose()
        {
        }

        public IEnumerable<FieldDataDTO> GetAll()
        {
            return _fieldData;
        }

        public void Create(FieldDataDTO item)
        {
            _fieldData.Add(item);
        }

        public FieldDataDTO Read(int id)
        {
            return _fieldData.Find(dto => dto.F_Id == id);
        }

        public void Update(FieldDataDTO item)
        {
            _fieldData.RemoveAll(dto => dto.F_Id == item.F_Id);
            _fieldData.Add(item);
        }

        public void Delete(int id)
        {
            _fieldData.RemoveAll(dto => dto.F_Id == id);
        }
    }
}