using Prototype2WebApi.Models;

namespace Prototype2WebApi.Interfaces
{
    public interface IPrototypeDbRepository
    {
        UserInfoData CreateNewUser(UserInfoData data);
        Schedule CreateNewSchedule(Schedule schedule);
        List<Schedule> GetAllSchedules(bool fullFetch = true);
        List<PostedStory> GetAllPostedStories(bool fullFetch = true);
        PostedStory PostStory(PostedStory postedstory);
        Schedule GetScheduleId(int id, bool fullFetch = true);
        PostedStory GetPostedStoryId(int id, bool fullFetch = true);
        public bool DoesUserExistById(int id);
        public bool DoesScheduleExistById(int id);
        public bool DoesPostedStoryExistById(int id);
        public bool DoesUserExistByEmail(string email);
        UserInfoData GetUserById(int id);
        UserInfoData GetCustomerByFirstName(string firstname);
        UserInfoData GetCustomerByLastName(string lastname);
        UserInfoData GetCustomerByEmail(string email);
        UserInfoData GetCustomerByCell(string cell);
        UserInfoData GetCustomerByPassword(string password);
        public List<UserInfoData> GetUserInfoData();
        public Acheivement CreateNewAcheivement(Acheivement acheivement);
        public List<Acheivement> GetAllAcheivements();
        public Acheivement GetAcheivementById(int id);
    }
}
