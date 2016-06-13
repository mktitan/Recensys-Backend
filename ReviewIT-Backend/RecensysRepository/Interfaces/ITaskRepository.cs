﻿using System;
using System.Collections.Generic;
using RecensysRepository.DTO;

namespace RecensysRepository.Interfaces
{
    public interface ITaskRepository : IDisposable
    {
        IEnumerable<TaskDTO> GetAll();

        void Create(TaskDTO item);

        TaskDTO Read(int id);

        void Update(TaskDTO item);

        void Delete(int id);
    }
}