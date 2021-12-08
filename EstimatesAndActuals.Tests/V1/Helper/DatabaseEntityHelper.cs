using AutoFixture;
using EstimatesAndActuals.V1.Domain;
using EstimatesAndActuals.V1.Infrastructure;

namespace EstimatesAndActuals.Tests.V1.Helper
{
    public static class DatabaseEntityHelper
    {
        public static EstimateAndActualsDbEntity CreateDatabaseEntity()
        {
            var entity = new Fixture().Create<EstimateAndActuals>();

            return CreateDatabaseEntityFrom(entity);
        }

        public static EstimateAndActualsDbEntity CreateDatabaseEntityFrom(EstimateAndActuals estimateAndActuals)
        {
            return new EstimateAndActualsDbEntity
            {
                Id = estimateAndActuals.Id,
                CreatedAt = estimateAndActuals.CreatedAt,
            };
        }
    }
}
