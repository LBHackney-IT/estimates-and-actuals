using AutoFixture;
using EstimatesAndActuals.V1.Domain;
using EstimatesAndActuals.V1.Infrastructure;

namespace EstimatesAndActuals.Tests.V1.Helper
{
    public static class DatabaseEntityHelper
    {
        public static DatabaseEntity CreateDatabaseEntity()
        {
            var entity = new Fixture().Create<EstimateAndActuals>();

            return CreateDatabaseEntityFrom(entity);
        }

        public static DatabaseEntity CreateDatabaseEntityFrom(EstimateAndActuals estimateAndActuals)
        {
            return new DatabaseEntity
            {
                Id = estimateAndActuals.Id,
                CreatedAt = estimateAndActuals.CreatedAt,
            };
        }
    }
}
