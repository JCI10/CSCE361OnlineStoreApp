using System;

namespace User
{
    public class IUserAccount
    {
        void Login(string username, string password);

        void Logout(userId userId);

        void ViewAccountInfo(UserId userId);

    }
}