
using SkillTrackerApp.Models;
using System.Data.Entity;

namespace SkillTrackerApp.DAL
{
    public class SkillTrackerDbContext : DbContext
    {
        public SkillTrackerDbContext()
            : base("name=DefaultConnectionString")
        {
        }
        public DbSet<Skill> Skills { get; set; }
    }
}