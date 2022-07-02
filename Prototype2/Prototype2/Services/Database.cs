using System.Collections.Generic;
using System.Threading.Tasks;
using Prototype2.Model;
using SQLite;

namespace Prototype2.Services
{
    public class Database
    {
        private readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<UserData>();
        }

        public Task<List<UserData>> GetUserDataAsync()
        {
            return _database.Table<UserData>().ToListAsync();
        }

        public Task<int> SaveUserDataAsync (UserData userdata)
        {
            return _database.InsertAsync(userdata);
        }
    }
}
