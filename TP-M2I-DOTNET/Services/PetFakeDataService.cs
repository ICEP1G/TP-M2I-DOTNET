using CSharpFunctionalExtensions;
using TP_M2I_DOTNET.DTOs;

namespace TP_M2I_DOTNET.Services
{
    public class PetFakeDataService : IPetService
    {
        private readonly FakeDataService _fakeDataService;
        public PetFakeDataService(FakeDataService fakeDataService)
        {
            _fakeDataService = fakeDataService;
        }

        public async Task<Result<List<PetDto>>> GetAllPetsAsync()
        {
            try
            {
                await Task.Delay(500);
                List<PetDto>? pets = await _fakeDataService.GetAllPetsAsync();
                if (pets is null)
                    return Result.Failure<List<PetDto>>("No pets found");

                return Result.Success(pets);
            }
            catch (Exception ex)
            {
                return Result.Failure<List<PetDto>>($"Unexpected error: {ex.Message}");
            }
        }
    }
}
