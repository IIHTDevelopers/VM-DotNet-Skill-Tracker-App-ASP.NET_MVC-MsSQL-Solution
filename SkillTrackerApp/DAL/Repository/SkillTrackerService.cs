using SkillTrackerApp.DAL.Interface;
using SkillTrackerApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SkillTrackerApp.DAL.Repository
{
    public class SkillTrackerSkill : ISkillTrackerInterface
    {
        private ISkillTrackerRepository _repo;
        public SkillTrackerSkill(ISkillTrackerRepository repo)
        {
            this._repo = repo;
        }

        public int DeleteSkill(int SkillId)
        {
            var res= _repo.DeleteSkill(SkillId);
            return res;
        }

        public Skill GetSkillByID(int SkillId)
        {
            return _repo.GetSkillByID(SkillId);
        }
        public void Save()
        {
            _repo.Save();
        }


        IEnumerable<Skill> ISkillTrackerInterface.GetSkills()
        {
            return _repo.GetSkills();
        }

        Skill ISkillTrackerInterface.InsertSkill(Skill Skill)
        {
            return _repo.InsertSkill(Skill);
        }

        bool ISkillTrackerInterface.UpdateSkill(Skill Skill)
        {
            return _repo.UpdateSkill(Skill);
        }
    }
}