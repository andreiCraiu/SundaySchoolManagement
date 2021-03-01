using SundaySchoolManagement.Domain.DatabaseEntities;

namespace SundaySchoolManagement.Application.Interfaces
{
    public interface IAuthorizeService
    {
        User Authenticate(string email, string password);

        User Register(string username,string email, string password);
        string GenerateJwtToken(User user, string secretKey);
    }
}
