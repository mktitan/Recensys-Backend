using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ReviewIT_Backend.BusinessLogicLayer;
using ReviewIT_Backend.Models;
using ReviewIT_Backend.Models.OverviewModels;
using ReviewIT_Backend.Repository;
using ReviewIT_Backend.Repository.Factory;

namespace ReviewIT_Backend.Controllers
{
    public class StudyController : ApiController
    {

        private static StudyBLL _studyBll = new StudyBLL(new RepositoryFactoryMemory());
        
        // GET: api/Study
        public IEnumerable<StudyOverviewModel> Get()
        {
            return _studyBll.Get();
        }

        // GET: api/Study/5
        public StudyModel Get(int id)
        {
            return _studyBll.Get(id);
        }

        // POST: api/Study
        public void Post(StudyOverviewModel model)
        {
            _studyBll.AddNew(model);
        }

        // PUT: api/Study/5
        public void Put(int id, StudyModel model)
        {
            
        }

        // DELETE: api/Study/5
        public void Delete(int id)
        {
            _studyBll.Remove(id);
        }
    }
}
