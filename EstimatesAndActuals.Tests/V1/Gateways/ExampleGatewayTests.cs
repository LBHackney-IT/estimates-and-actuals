using AutoFixture;
using EstimatesAndActuals.Tests.V1.Helper;
using EstimatesAndActuals.V1.Domain;
using EstimatesAndActuals.V1.Gateways;
using FluentAssertions;
using NUnit.Framework;

namespace EstimatesAndActuals.Tests.V1.Gateways
{
    //TODO: Remove this file if Postgres gateway is not being used
    //TODO: Rename Tests to match gateway name
    //For instruction on how to run tests please see the wiki: https://github.com/LBHackney-IT/lbh-estimates-and-actuals/wiki/Running-the-test-suite.
    [TestFixture]
    public class ExampleGatewayTests : DatabaseTests
    {
        private readonly Fixture _fixture = new Fixture();
        private EstimatesAndActualGateway _classUnderTest;

        [SetUp]
        public void Setup()
        {
            _classUnderTest = new EstimatesAndActualGateway(DatabaseContext);
        }

        [Test]
        public void GetEntityByIdReturnsNullIfEntityDoesntExist()
        {
            var response = _classUnderTest.GetById(123);

            response.Should().BeNull();
        }

        [Test]
        public void GetEntityByIdReturnsTheEntityIfItExists()
        {
            var entity = _fixture.Create<EstimateAndActuals>();
            var databaseEntity = DatabaseEntityHelper.CreateDatabaseEntityFrom(entity);

            DatabaseContext.DatabaseEntities.Add(databaseEntity);
            DatabaseContext.SaveChanges();

            var response = _classUnderTest.GetById(databaseEntity.Id);

            databaseEntity.Id.Should().Be(response.Id);
            databaseEntity.CreatedAt.Should().BeSameDateAs(response.CreatedAt);
        }

        //TODO: Add tests here for the get all method.
    }
}
