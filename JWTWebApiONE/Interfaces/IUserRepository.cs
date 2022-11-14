using JWTWebApiONE.DTO;

namespace JWTWebApiONE.Interfaces
{
    public interface IUserRepository
    {
        public string RegisterAUser(UserRegisterDTO userRegisterDTO);
        public string LoginUser(UserLoginDTO userLoginDTO);
    }
}
