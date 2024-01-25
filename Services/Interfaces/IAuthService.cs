using CRUD_Operations.Dtos;
using CRUD_Operations.Models;

namespace CRUD_Operations.Services.Interfaces
{
    public interface IAuthService
    {
        public Task<Response<AuthModel>> Register(RegisterModel model);
        public Task<Response<AuthModel>> Login(LoginModel model);
    }
}
