using System;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using Shouldly;
using TubeHaus.External.Tfl.Api;

namespace TubeHaus.External.Tfl.Tests.Api
{
    [TestFixture]
    public class LineServiceTests
    {
        private LineService _lineService;

        [SetUp]
        public void Setup()
        {
            var configurationBuilder = new ConfigurationBuilder()
                .AddUserSecrets(typeof(LineServiceTests).GetTypeInfo().Assembly)
                .Build();

            var appId = configurationBuilder.GetSection("TflApiConfig:AppId").Value;
            var appKey = configurationBuilder.GetSection("TflApiConfig:AppKey").Value;

            var config = new TflApiConfig(appId, appKey);

            _lineService = new LineService(config);
        }

        [Test]
        public async Task GetValidModes_ReturnsValidModes()
        {
            // Arrange

            // Act 
            var result = await _lineService.GetModes();

            // Assert
            result.IsSuccess.ShouldBe(true);

        }


        [Test]
        public async Task GetSeverityCodes_ReturnsSeverityCodes()
        {
            // Arrange

            // Act 
            var result = await _lineService.GetSeverityCodes();

            // Assert
            result.IsSuccess.ShouldBe(true);

        }




        [Test]
        public async Task GetLines_ReturnsLines()
        {
            // Arrange
            var lineIds = new string[] { "victoria", "circle" };


            // Act 
            var result = await _lineService.GetLines(lineIds);

            // Assert
            result.IsSuccess.ShouldBe(true);

        }



        [Test]
        public async Task GetLineStatus_ReturnsLines()
        {
            // Arrange
            var lineIds = new string[] { "victoria", "circle" };
            var startDate = DateTime.Today.AddDays(2);
            var endDate = DateTime.Today.AddDays(5);

            // Act 
            var result = await _lineService.GetLineStatus(lineIds, startDate, endDate, true);

            // Assert
            result.IsSuccess.ShouldBe(true);


        }


        [Test]
        public async Task GetDisruptionCategories()
        {
            // Arrange

            // Act 
            var result = await _lineService.GetDisruptionCategories();

            // Assert
            result.IsSuccess.ShouldBe(true);

        }


    }
}
