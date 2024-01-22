using SkillTrackerApp.DAL.Interface;
using SkillTrackerApp.DAL.Repository;
using SkillTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace SkillTrackerApp.Controllers
{
    public class SkillTrackerController : Controller
    {
        private readonly ISkillTrackerInterface _Repository;
        public SkillTrackerController(ISkillTrackerInterface skill)
        {
            _Repository = skill;
        }
        public SkillTrackerController()
        {
            // Constructor logic, if needed
        }
        // GET: SkillTracker
        public ActionResult Index()
        {
            var Skills = from work in _Repository.GetSkills()
                        select work;
            return View(Skills);
        }

        public ViewResult Details(int id)
        {
            Skill Skill =   _Repository.GetSkillByID(id);
            return View(Skill);
        }

        public ActionResult Create()
        {
            return View(new Skill());
        }

        [HttpPost]
        public ActionResult Create(Skill Skill)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _Repository.InsertSkill(Skill);
                    _Repository.Save();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View(Skill);
        }

        public ActionResult EditAsync(int id)
        {
            Skill Skill =  _Repository.GetSkillByID(id);
            return View(Skill);
        }
        [HttpPost]
        public ActionResult Edit(Skill Skill)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _Repository.UpdateSkill(Skill);
                    _Repository.Save();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View(Skill);
        }

        public ActionResult Delete(int id, bool? saveChangesError)
        {
            if (saveChangesError.GetValueOrDefault())
            {
                ViewBag.ErrorMessage = "Unable to save changes. Try again, and if the problem persists see your system administrator.";
            }
            Skill Skill =  _Repository.GetSkillByID(id);
            return View(Skill);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                Skill Skill =  _Repository.GetSkillByID(id);
                _Repository.DeleteSkill(id);
                _Repository.Save();
            }
            catch (DataException)
            {
                return RedirectToAction("Delete",
                   new System.Web.Routing.RouteValueDictionary {
        { "id", id },
        { "saveChangesError", true } });
            }
            return RedirectToAction("Index");
        }
    }
}