using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Woodensoft.Tither.Utilities
{
    public static class SessionValidator
    {
        public static void ValidateSession(System.Windows.Forms.Form frm, Woodensoft.TitherPro.Domain.Contexts.User u)
        {
            if (u == null)
            {
                frm.Close();
                throw new Exception("You are not logged in!");
            }
        }
    }
}
