using SQLite;

namespace Prototype2.Model
{
    public class UserData
    {
        [PrimaryKey][AutoIncrement]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
    }
}
