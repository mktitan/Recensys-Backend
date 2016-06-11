using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using ReviewIT_Backend.BusinessLogicLayer;
using ReviewIT_Backend.Models;
using ReviewIT_Backend.Repository;
using ReviewIT_Backend.Repository.DTO;
using ReviewIT_Backend.Repository.Factory;

namespace ReviewIT_Backend.Controllers
{
    public class UserController : ApiController
    {

        private static UserBLL _userBLL = new UserBLL(new RepositoryFactoryMemory());
        

        // GET: api/Users
        public IEnumerable<UserModel> Get()
        {
            return null;
        }

        
        // GET: api/User/5
        public UserModel Get(int id)
        {

            // get dto from repo
            return _userBLL.Get(id);
            
            
        }

        // POST: api/User
        public void Post(UserModel user)
        {

            _userBLL.Add(user);
        }

        // PUT: api/User/5
        public void Put(int id, UserModel user)
        {
            _userBLL.Add(user);
        }

        // DELETE: api/User/5
        public void Delete(int id)
        {
            
        }
    }
}
