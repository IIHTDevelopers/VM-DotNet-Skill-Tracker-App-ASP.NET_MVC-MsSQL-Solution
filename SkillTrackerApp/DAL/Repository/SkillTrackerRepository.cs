using SkillTrackerApp.DAL.Interface;
using SkillTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace SkillTrackerApp.DAL.Repository
{
    public class SkillTrackerRepository : ISkillTrackerRepository
    {
        private SkillTrackerDbContext _context;
        public SkillTrackerRepository(SkillTrackerDbContext Context)
        {
            this._context = Context;
        }
        public IEnumerable<Skill> GetSkills()
        {
             return _context.Skills.ToList();
        }
        public Skill GetSkillByID(int id)
        {
            return _context.Skills.Find(id);
        }
        public Skill InsertSkill(Skill Skill)
        {
            return _context.Skills.Add(Skill);
        }
        public int DeleteSkill(int SkillID)
        {
            Skill Skill = _context.Skills.Find(SkillID);
            var res= _context.Skills.Remove(Skill);
            return res.Id;
        }
        public bool UpdateSkill(Skill Skill)
        {
            var res= _context.Entry(Skill).State = EntityState.Modified;
            return res.Equals("Skill");
        }
        public void Save()
        {
            _context.SaveChanges();
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
