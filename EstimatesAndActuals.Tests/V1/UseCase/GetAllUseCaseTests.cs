using System.Linq;
using AutoFixture;
using EstimatesAndActuals.V1.Boundary.Response;
using EstimatesAndActuals.V1.Domain;
using EstimatesAndActuals.V1.Factories;
using EstimatesAndActuals.V1.Gateways;
using EstimatesAndActuals.V1.UseCase;
using FluentAssertions;
using Moq;
using NUnit.Framework;

namespace EstimatesAndActuals.Tests.V1.UseCase
{
    public class GetAllUseCaseTests : LogCallAspectFixture
    {
        private Mock<IDynamoDbGateway> _mockGateway;
        private GetAllUseCase _classUnderTest;
        private Fixture _fixture;

        [SetUp]
        public void SetUp()
        {
            _mockGateway = new Mock<IDynamoDbGateway>();
            _classUnderTest = new GetAllUseCase(_mockGateway.Object);
            _fixture = new Fixture();
        }

        [Test]
        public void GetsAllFromTheGateway()
        {
            var stubbedEntities = _fixture.CreateMany<EstimateAndActuals>().ToList();
            _mockGateway.Setup(x => x.GetAll()).Returns(stubbedEntities);

            var expectedResponse = new ResponseObjectList { EstimatesAndActualsResponses = stubbedEntities.ToResponse() };

            _classUnderTest.Execute().Should().BeEquivalentTo(expectedResponse);
        }

        //TODO: Add extra tests here for extra functionality added to the use case
    }
}
