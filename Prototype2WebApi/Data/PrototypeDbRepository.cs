﻿using Prototype2WebApi.Models;

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
    }
}
