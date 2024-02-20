using RockSeatAuction.API.Repositories;
using RockSeatAuction.API.Entities;
using RockSeatAuction.API.Contracts;
namespace RockSeatAuction.API.Services;

public class LoggedUser : ILoggedUser
{
    private readonly IHttpContextAccessor _httContextAccessor;
    private readonly IUserRepository _repository;

    public LoggedUser(IHttpContextAccessor httpContext, IUserRepository repository)
    {
        _httContextAccessor = httpContext;
        _repository = repository;
    }
    public User User()
    {

        var token = TokenOnRequest();
        var email = FromBase64String(token);

        return _repository.GetUserByEmail(email);
    }

    private string TokenOnRequest()
    {

        var authentication = _httContextAccessor.HttpContext!.Request.Headers.Authorization.ToString();

        return authentication["Bearer ".Length..];
    }

    private string FromBase64String(string base64)
    {
        var data = Convert.FromBase64String(base64);

        return System.Text.Encoding.UTF8.GetString(data);
    }
}