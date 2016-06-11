using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReviewIT_Backend.Repository.DTO;
using ReviewIT_Backend.Repository.Interfaces;

namespace ReviewIT_Backend.Repository.Factory
{
    public interface IRepositoryFactory
    {
        IUserRepository GetUserRepo();
        IStudyRepository GetStudyRepo();
        IStageRepository GetStageRepo();
        IFieldRepository GetFieldRepo();
        IFieldDataRepository GetFieldDataRepo();
        ITaskRepository GetTaskRepo();
        IArticleRepository GetArticleRepo();
        ICredentialsRepository GetCredentialsRepo();
        IUserStudyRelationRepository GetUserStudyRelationRepository();
        IStudyRoleRepository GetStudyRoleRepository();
        IStrategyRepository GetStrategyRepository();
    }
}
