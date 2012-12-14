using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Woodensoft.TitherPro.Domain.Contexts;
namespace Woodensoft.TitherPro.Domain.Repositories
{
    public class UserRepository
    {
        private TitheDBEntities _entities;
        public UserRepository(TitheDBEntities entities)
        {
            _entities = entities;
        }
       
        public User ValidateUserLogin(string username, string password)
        {
            return _entities.Users.SingleOrDefault(x => x.Active && x.Username.ToLower() == username.ToLower() && x.Password == password);
        }

        public void AddUser(string username, string password, bool isAdmin)
        {
            if (_entities.Users.Any(x => x.Username == username))
                return;
            _entities.Users.AddObject(new User { Username = username, Password = password, IsAdmin = isAdmin, Active = true });

        }

        public void UpdateUser(int userId, string password, bool isAdmin, bool active)
        {
            var user = _entities.Users.SingleOrDefault(u => u.UserId == userId);
            if (user == null)
                return;
            user.Active = active;
            user.IsAdmin = isAdmin;
            user.Password = password;
        }

        public void DeleteUser(int userId)
        {
            var user = _entities.Users.SingleOrDefault(x => x.UserId == userId);
            if (user == null)
                return;
            user.Active = false;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _entities.Users.ToList();
        }
    }
}
