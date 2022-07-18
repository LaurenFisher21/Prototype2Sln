using Prototype2WebApi.Interfaces;
using Prototype2WebApi.Models;

namespace Prototype2WebApi.Data
{
    /// <summary>
    /// where to get the info from.
    /// </summary>
    public class PrototypeDbRepository : IPrototypeDbRepository
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
        //creating a new schedule
        public Schedule CreateNewSchedule(Schedule schedule)
        {
            _dataContext.Schedules.Add(schedule);
            _dataContext.SaveChanges();

            return schedule;
        }
        //checking if the schedule id exists
        public bool DoesScheduleExistById(int id)
        {
            return _dataContext.Schedules.Any(use => use.ScheduleId == id);
        }
        //Get all schedule
        public List<Schedule> GetAllSchedules()
        {
            var schedule = _dataContext.Schedules.ToList();
            return schedule;
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
        public Acheivement CreateNewAcheivement(Acheivement acheivement)
        {
            _dataContext.Acheivements.Add(acheivement);
            _dataContext.SaveChanges();

            return acheivement;
        }
        public List<Acheivement> GetAllAcheivements()
        {
            var acheivements = _dataContext.Acheivements.ToList();
            return acheivements;
        }

        public Acheivement GetAcheivementById(int id)
        {
            var acheivement = _dataContext.Acheivements.Where(x => x.AcheivementsId == id).FirstOrDefault();
            return acheivement;
        }

        public List<Schedule> GetAllSchedules(bool fullFetch = true)
        {
            throw new NotImplementedException();
        }

        public Schedule GetScheduleId(int id, bool fullFetch = true)
        {
            throw new NotImplementedException();
        }

        public FamilyGroup CreateFamilyGroup(FamilyGroup famgroup)
        {
            _dataContext.FamilyGroups.Add(famgroup);
            _dataContext.SaveChanges();

            return famgroup;
        }
        public bool DoesFamilyGroupExistById(int id)
        {
            return _dataContext.FamilyGroups.Any(use => use.FamilyGroupId == id);
        }
        public List<FamilyGroup> GetAllFamilyMembers()
        {
            var famgroup = _dataContext.FamilyGroups.ToList();
            return famgroup;
        }
        public FamilyGroup GetFamilyGroupById(int id)
        {
            var famgroup = _dataContext.FamilyGroups.Where(x => x.FamilyGroupId == id).FirstOrDefault();
            return famgroup;
        }
        public FamilyStatus CreateFamilyStatus(FamilyStatus famstatus)
        {
            _dataContext.FamilyStatuses.Add(famstatus);
            _dataContext.SaveChanges();

            return famstatus;
        }
        public bool DoesFamilyStatusExistById(int id)
        {
            return _dataContext.FamilyStatuses.Any(use => use.FamilyStatusId == id);
        }
        public List<FamilyStatus> GetAllFamilyStatuses()
        {
            var famstatus = _dataContext.FamilyStatuses.ToList();
            return famstatus;
        }
        public FamilyStatus GetFamilyStatusById(int id)
        {
            var famstatus = _dataContext.FamilyStatuses.Where(x => x.FamilyStatusId == id).FirstOrDefault();
            return famstatus;
        }

        public List<PostedStory> GetAllPostedStories(bool fullFetch = true)
        {
            throw new NotImplementedException();
        }

        public PostedStory PostStory(PostedStory postedstory)
        {
            throw new NotImplementedException();
        }

        public PostedStory GetPostedStoryId(int id, bool fullFetch = true)
        {
            throw new NotImplementedException();
        }

        public bool DoesPostedStoryExistById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
