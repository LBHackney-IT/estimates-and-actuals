using AutoFixture;
using Estimates_And_Actuals.V1.Controllers;
using Estimates_And_Actuals.V1.UseCase;
using Estimates_And_Actuals.V1.UseCase.Interfaces;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estimates_And_Actuals.Tests.V1.Controllers
{
    [TestFixture]
    public class Estimates_And_ActualsControllerTests : LogCallAspectFixture
    {
        private Estimates_And_ActualsController _classUnderTest;
        private Mock<IGetByIdUseCase> _mockGetByIdUseCase;
        private Mock<IGetAllUseCase> _mockGetByAllUseCase;

        [SetUp]
        public void SetUp()
        {
            _mockGetByIdUseCase = new Mock<IGetByIdUseCase>();
            _mockGetByAllUseCase = new Mock<IGetAllUseCase>();
            _classUnderTest = new Estimates_And_ActualsController(_mockGetByAllUseCase.Object, _mockGetByIdUseCase.Object);
        }


        //Add Tests Here
    }
}
