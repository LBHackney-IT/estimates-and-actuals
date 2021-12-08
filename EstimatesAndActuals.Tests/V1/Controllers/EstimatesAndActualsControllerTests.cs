using AutoFixture;
using EstimatesAndActuals.V1.Controllers;
using EstimatesAndActuals.V1.UseCase;
using EstimatesAndActuals.V1.UseCase.Interfaces;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstimatesAndActuals.Tests.V1.Controllers
{
    [TestFixture]
    public class EstimatesAndActualsControllerTests : LogCallAspectFixture
    {
        private EstimatesAndActualsController _classUnderTest;
        private Mock<IGetByIdUseCase> _mockGetByIdUseCase;
        private Mock<IGetAllUseCase> _mockGetByAllUseCase;

        [SetUp]
        public void SetUp()
        {
            _mockGetByIdUseCase = new Mock<IGetByIdUseCase>();
            _mockGetByAllUseCase = new Mock<IGetAllUseCase>();
            _classUnderTest = new EstimatesAndActualsController(_mockGetByAllUseCase.Object, _mockGetByIdUseCase.Object);
        }


        //Add Tests Here
    }
}