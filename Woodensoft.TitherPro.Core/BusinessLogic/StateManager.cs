using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Woodensoft.TitherPro.Domain.Contexts;
namespace Woodensoft.TitherPro.Core.BusinessLogic
{
    public class StateManager
    {
        private static StateManager _manager = new StateManager();
        public static StateManager Instance { get { return _manager; } }

        private User _curUser;

        public void SetUser(User user)
        {
            _curUser = user;
        }

        public User GetUser()
        {
            return _curUser;
        }
    }
}
