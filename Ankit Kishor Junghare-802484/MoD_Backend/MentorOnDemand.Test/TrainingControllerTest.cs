using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using TrainingService.Repository;
using TrainingService.Controllers;
using TrainingService.Models;
using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace MentorOnDemand.Test
{
   public class TrainingControllerTest
    {
        private readonly Mock<ITrainingRepository> _repo;
        private readonly TrainingController _controller;
        public TrainingControllerTest()
        {
            _repo = new Mock<ITrainingRepository>();
            _controller = new TrainingController(_repo.Object);

        }
          [Fact]
        public void Get()
        {
            _repo.Setup(m => m.Training_GetAll()).Returns(GetTraining());
            var result = _controller.Get() as List<Training>;
            Assert.Equal(3, result.Count);
        }
        [Fact]
        public void Post()
        {
            var item = GetTraining()[0];
            var result = _controller.Post(item) as OkResult;
            Assert.NotNull(result);
        }
        [Fact]
        public void Put()
        {
            var item = GetTraining()[0];
            var result = _controller.Put(item) as OkResult;
            Assert.NotNull(result);
        }
        private List<Training> GetTraining()
        {
            return new List<Training>()
            {
                new Training(){ Training_Id=1,Training_Status="Ongoing"},
                new Training(){ Training_Id=2,Training_Status="Completed"},
                new Training(){ Training_Id=3,Training_Status="Completed"}
            };
        }

    }
}
