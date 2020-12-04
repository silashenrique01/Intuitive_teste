using System;

namespace Intuitive.Domain.Entities
{
    public class User
    {

        public User(int _UserId, string _Name, string _DtNasc, string _Email, string _Username, string _Password)
        {
            UserId = _UserId;
            Name = _Name;
            DtNasc = _DtNasc;
            Email = _Email;
            Username = _Username;
            Password = _Password;

        }

        public User(){}

        public int UserId { get; set; }
        public string Name { get; set; }
        public string DtNasc { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}