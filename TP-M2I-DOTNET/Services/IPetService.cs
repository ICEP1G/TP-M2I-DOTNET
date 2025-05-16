using CSharpFunctionalExtensions;
using TP_M2I_DOTNET.DTOs;

namespace TP_M2I_DOTNET.Services
{
    public interface IPetService
    {
        Task<Result<List<PetDto>>> GetAllPetsAsync();
    }
}
