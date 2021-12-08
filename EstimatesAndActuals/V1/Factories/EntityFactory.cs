using EstimatesAndActuals.V1.Domain;
using EstimatesAndActuals.V1.Infrastructure;

namespace EstimatesAndActuals.V1.Factories
{
    public static class EntityFactory
    {
        public static EstimateAndActuals ToDomain(this DatabaseEntity databaseEntity)
        {
            //TODO: Map the rest of the fields in the domain object.
            // More information on this can be found here https://github.com/LBHackney-IT/lbh-estimates-and-actuals/wiki/Factory-object-mappings

            return new EstimateAndActuals
            {
                Id = databaseEntity.Id,
                CreatedAt = databaseEntity.CreatedAt
            };
        }

        public static DatabaseEntity ToDatabase(this EstimateAndActuals estimateAndActuals)
        {
            //TODO: Map the rest of the fields in the database object.

            return new DatabaseEntity
            {
                Id = estimateAndActuals.Id,
                CreatedAt = estimateAndActuals.CreatedAt
            };
        }
    }
}
