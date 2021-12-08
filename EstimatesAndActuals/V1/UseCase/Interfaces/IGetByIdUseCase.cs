using EstimatesAndActuals.V1.Boundary.Response;

namespace EstimatesAndActuals.V1.UseCase.Interfaces
{
    public interface IGetByIdUseCase
    {
        ResponseObject Execute(int id);
    }
}
