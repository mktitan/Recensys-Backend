﻿using ReviewIT_Backend.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ReviewIT_Backend.Repository.DTO;

namespace ReviewIT_Backend.Repository.InMemoryImpl
{
    public class StudyRoleRepositoryIm : IStudyRoleRepository
    {

        private List<StudyRoleDTO> _roles = new List<StudyRoleDTO>()
        {
            new StudyRoleDTO() {R_Id = 1, Name = "Admin" },
            new StudyRoleDTO() {R_Id = 2, Name = "Researcher" },
            new StudyRoleDTO() {R_Id = 3, Name = "Guest" },
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