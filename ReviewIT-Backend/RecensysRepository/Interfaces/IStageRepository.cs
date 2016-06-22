﻿using System;
using System.Collections.Generic;
using RecensysRepository.DTO;

namespace RecensysRepository.Interfaces
{
    public interface IStageRepository : IDisposable
    {
        IEnumerable<StageEntity> GetAll();

        void Create(StageEntity item);

        StageEntity Read(int id);

        void Update(StageEntity item);

        void Delete(int id);
    }
}
