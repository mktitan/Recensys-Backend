using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using Dapper;
using ReviewIT_Backend.Models;
using ReviewIT_Backend.Repository.DTO;

namespace ReviewIT_Backend.Repository
{
    public class UserRepositoryDb : IUserRepository
    {

        private string _conStr;

        public UserRepositoryDb()
        {
            _conStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
        }

        public IEnumerable<UserDTO> GetAll()
        {

            return null;
        }

        public void Create(UserDTO user)
        {
            throw new NotImplementedException();
        }

        public UserDTO Read(int id)
        {

            UserDTO m;

            using (IDbConnection c = new SqlConnection(_conStr))
            {
                m = c.Query<UserDTO>("SELECT * FROM dbo.Users WHERE U_Id = @uid", new {uid = id}).SingleOrDefault();
            }

            return m;
        }

        public void Update(UserDTO user)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}