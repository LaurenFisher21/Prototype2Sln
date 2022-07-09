using Microsoft.EntityFrameworkCore;
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

        public UserInfoData CreateNewUser(UserInfoData user)
        {
            _dataContext.UserInfoDatas.Add(user);
            _dataContext.SaveChanges();

            return user;
        }

        public bool DoesUserExistById(int id)
        {
            return _dataContext.UserInfoDatas.Any(use => use.UserId == id);
        }

        public bool DoesUserExistByEmail(string email)
        {
            return _dataContext.UserInfoDatas.Any(use => use.EmailAddress == email);
        }

        public IEnumerable<UserInfoData> All
        {
            get { return _dataContext.UserInfoDatas.ToList(); }
        }
    }
}
