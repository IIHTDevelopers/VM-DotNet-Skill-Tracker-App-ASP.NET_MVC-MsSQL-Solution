
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
    public class BoundaryTests
    {
        private readonly ITestOutputHelper _output;
        private readonly ISkillTrackerInterface _skillTrackerSkill;
        public readonly Mock<ISkillTrackerRepository> skilltrackerskill = new Mock<ISkillTrackerRepository>();
        private readonly Skill _Skill;
        private readonly IEnumerable<Skill> SkillList;

        private static string type = "Boundary";

        public BoundaryTests(ITestOutputHelper output)
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
                Id = 2,
                Date = DateTime.Now,
                SkillName = "Exercise",
                IsCompleted = true,
                Notes = "30 minutes of jogging in the park."
            },
        };

        }

        [Fact]
        public async Task<bool> Testfor_Id_NotNull()
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

        [Fact]
        public async Task<bool> Testfor_Date_NotNull()
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

        [Fact]
        public async Task<bool> Testfor_SkillName_NotNull()
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
                if (result!=null)
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
        public async Task<bool> Testfor_IsCompleted_NotNull()
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

        [Fact]
        public async Task<bool> Testfor_Notes_NotNull()
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

    }
}