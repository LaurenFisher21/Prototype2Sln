using Prototype2WebApi.Models;

namespace Prototype2WebApi.Data
{
    /// <summary>
    /// where to get the info from.
    /// </summary>
    public class PrototypeDbRepository
    {
        private DataContext _dataContext;

        public PrototypeDbRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        //Creating a new user
        public UserInfoData CreateNewUser(UserInfoData user)
        {
            _dataContext.UserInfoDatas.Add(user);
            _dataContext.SaveChanges();

            return user;
        }

        //Checking if the user ID exists
        public bool DoesUserExistById(int id)
        {
            return _dataContext.UserInfoDatas.Any(use => use.UserId == id);
        }

        //Checking if the user email exists
        public bool DoesUserExistByEmail(string email)
        {
            return _dataContext.UserInfoDatas.Any(use => use.EmailAddress == email);
        }

        //Gets all the users
        public List<UserInfoData> GetUserInfoData()
        {
            var users = _dataContext.UserInfoDatas.ToList();
            return users;
        }

        public UserInfoData GetUserById(int id)
        {
            var user = _dataContext.UserInfoDatas.Where(x => x.UserId == id).FirstOrDefault();
            return user;
        }

        public UserInfoData GetCustomerByFirstName(string firstname)
        {
            var user = _dataContext.UserInfoDatas.Where(x => x.FirstName.Contains(firstname)).FirstOrDefault();
            return user;
        }

        public UserInfoData GetCustomerByLastName(string lastname)
        {
            var user = _dataContext.UserInfoDatas.Where(x => x.LastName.Contains(lastname)).FirstOrDefault();
            return user;
        }

        public UserInfoData GetCustomerByEmail(string email)
        {
            var user = _dataContext.UserInfoDatas.Where(x => x.LastName.Contains(email)).FirstOrDefault();
            return user;
        }

        public UserInfoData GetCustomerByCell(string cell)
        {
            var user = _dataContext.UserInfoDatas.Where(x => x.LastName.Contains(cell)).FirstOrDefault();
            return user;
        }

        public UserInfoData GetCustomerByPassword(string password)
        {
            var user = _dataContext.UserInfoDatas.Where(x => x.LastName.Contains(password)).FirstOrDefault();
            return user;
        }
    }
}
