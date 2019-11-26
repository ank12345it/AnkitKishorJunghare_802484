using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using TechnologyService.Repository;
using TechnologyService.Models;
using TechnologyService.Controllers;

using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace MentorOnDemand.Test
{
   public class TechnologyControllerTest
    {
        private readonly Mock<ISkillsRepository> _repo;
        private readonly SkillsController _controller;

        public TechnologyControllerTest()
        {
            _repo = new Mock<ISkillsRepository>();
            _controller = new SkillsController(_repo.Object);

        }
        [Fact]
        public void Post()
        {
            var item = GetSkills()[0];
            var result = _controller.Post(item) as OkResult;
            Assert.NotNull(result);
        }
        [Fact]
        public void Get()
        {
            _repo.Setup(m => m.Skills_GetAll()).Returns(GetSkills());
            var result = _controller.Get() as List<Skills>;
            Assert.Equal(3, result.Count);
        }
        [Fact]
        public void Put()
        {
            var item = GetSkills()[0];
            var result = _controller.Put(item) as OkResult;
            Assert.NotNull(result);
        }
        private List<Skills> GetSkills()
        {
            return new List<Skills>()
            {
                new Skills(){ Skill_Id=1,Skill_Name="Java"},
                new Skills(){ Skill_Id=2,Skill_Name="IOT"},
                new Skills(){ Skill_Id=3,Skill_Name="Python"}
            };
        }

    } 
}
