
using SkillTrackerApp.DAL;
using SkillTrackerApp.DAL.Interface;
using SkillTrackerApp.DAL.Repository;
using SkillTrackerApp.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace SkillTrackerApp.Tests.TestCases
{
    public class FunctionalTests
    {
        private readonly ITestOutputHelper _output;
        private readonly ISkillTrackerInterface _skillTrackerSkill;
        public readonly Mock<ISkillTrackerRepository> skilltrackerskill = new Mock<ISkillTrackerRepository>();
        private readonly Skill _Skill;
        private readonly IEnumerable<Skill> SkillList;

        private static string type = "Functional";

        public FunctionalTests(ITestOutputHelper output)
        {
            _skillTrackerSkill = new SkillTrackerSkill(skilltrackerskill.Object);
            _output = output;
            _Skill = new Skill
            {
                Id = 1,
                Date = DateTime.Now,
                SkillName = "Exercise",
                IsCompleted = true,
                Notes = "30 minutes of jogging in the park."
            };
             SkillList = new List<Skill>
        {
            new Skill
            {
               Id = 1,
                Date = DateTime.Now,
                SkillName = "Exercise",
                IsCompleted = true,
                Notes = "30 minutes of jogging in the park."
            },
            new Skill
            {
                Id = 1,
                Date = DateTime.Now,
                SkillName = "Exercise",
                IsCompleted = true,
                Notes = "30 minutes of jogging in the park."
            },
        };

        }

        [Fact]
        public async Task<bool> Testfor_Get_Skill()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                 skilltrackerskill.Setup(repos => repos.GetSkills()).Returns(SkillList);
                var result =  _skillTrackerSkill.GetSkills();
                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_Get_Skill_ById()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            int id = 1;

            //Action
            try
            {
                skilltrackerskill.Setup(repos => repos.GetSkillByID(_Skill.Id)).Returns(_Skill);
                var result = _skillTrackerSkill.GetSkillByID(_Skill.Id);
                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_Update_Skill()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            int id = 1;

            //Action
            try
            {
                skilltrackerskill.Setup(repos => repos.UpdateSkill(_Skill)).Returns(true);
                var result=_skillTrackerSkill.UpdateSkill(_Skill);
                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_Delete_Skill()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            int id = 1;

            //Action
            try
            {
                skilltrackerskill.Setup(repos => repos.DeleteSkill(_Skill.Id)).Returns(1);
                var result=_skillTrackerSkill.DeleteSkill(_Skill.Id);

                //Assertion
                if (result!= null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

    }
}