namespace api.Interfaces;

public interface IUserRepository
{
    public Task<LoggedInDto?> RegisterAsync(AppUser userInput, CancellationToken cancellationToken);
      public Task<LoggedInDto?> LoginAsync(LoginDto userInput, CancellationToken cancellationToken);
    public Task<List<AppUser>?> GetAllAsync(CancellationToken cancellationToken);
    public Task<UpdateDto?> UpdateByIdAsync(string userId, AppUser userInput, CancellationToken cancellationToken);
    public Task<DeleteResult?> DeleteByIdAsync(string userId, CancellationToken cancellationToken);
}