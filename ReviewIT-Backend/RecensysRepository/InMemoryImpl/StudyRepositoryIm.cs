using System.Collections.Generic;
using RecensysRepository.DTO;
using RecensysRepository.Interfaces;

namespace RecensysRepository.InMemoryImpl
{
    public class StudyRepositoryIm : IStudyRepository
    {

        private readonly List<StudyDTO> _studies = new List<StudyDTO>()
        {
            new StudyDTO() {S_Id = 1, Name = "study1", Description = "This is the description for study 1"},
            new StudyDTO() {S_Id = 2, Name = "study2", Description = "This is the description for study 2"}
        };

        public void Dispose()
        {
        }

        public IEnumerable<StudyDTO> GetAll()
        {
            return _studies;
        }

        public void Create(StudyDTO study)
        {
            _studies.Add(study);
        }

        public StudyDTO Read(int id)
        {
            return _studies.Find(dto => dto.S_Id == id);
        }

        public void Update(StudyDTO study)
        {
            _studies.RemoveAll(dto => dto.S_Id == study.S_Id);
            _studies.Add(study);
        }

        public void Delete(int id)
        {
            _studies.RemoveAll(dto => dto.S_Id == id);
        }
    }
}