using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ReviewIT_Backend.Repository.DTO;

namespace ReviewIT_Backend.Repository
{
    public class FieldRepositoryIm : IFieldRepository
    {

        private List<FieldDTO> _fields = new List<FieldDTO>()
        {
            new FieldDTO() {F_Id = 1, Name = "Title", FieldType = 1},
            new FieldDTO() {F_Id = 2, Name = "Is GSD?", FieldType = 2}
        };

        public void Dispose()
        {
        }

        public IEnumerable<FieldDTO> GetAll()
        {
            return _fields;
        }

        public void Create(FieldDTO item)
        {
            _fields.Add(item);
        }

        public FieldDTO Read(int id)
        {
            return _fields.Find(dto => dto.F_Id == id);
        }

        public void Update(FieldDTO item)
        {
            _fields.RemoveAll(dto => dto.F_Id == item.F_Id);
            _fields.Add(item);
        }

        public void Delete(int id)
        {
            _fields.RemoveAll(dto => dto.F_Id == id);
        }
    }
}