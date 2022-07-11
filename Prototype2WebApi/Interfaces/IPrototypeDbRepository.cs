using Prototype2WebApi.Models;

namespace Prototype2WebApi.Interfaces
{
    public interface IPrototypeDbRepository
    {
        UserInfoData CreateNewUser(UserInfoData data);
        public bool DoesUserExistById(int id);
        public bool DoesUserExistByEmail(string email);
        UserInfoData GetUserById(int id);
        UserInfoData GetCustomerByFirstName(string firstname);
        UserInfoData GetCustomerByLastName(string lastname);
        UserInfoData GetCustomerByEmail(string email);
        UserInfoData GetCustomerByCell(string cell);
        UserInfoData GetCustomerByPassword(string password);
    }
}
