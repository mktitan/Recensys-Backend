using System.Collections.Generic;
using RecensysBLL.Models.OverviewModels;

namespace RecensysBLL.Models
{
    public enum StudyRole
    {
        Admin, User, Guest
    }

    public class StudyModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<StageOverviewModel> Stages { get; set; }

        public List<UserModel> Persons { get; set; }

        public Dictionary<UserModel, StudyRole> PersonRoles { get; set; }

        public List<ArticleModel> Articles { get; set; }
    }
}