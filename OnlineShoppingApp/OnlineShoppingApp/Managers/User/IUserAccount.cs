using System;

public interface IUserAccount
{
    void Login(string username, string password);

    void Logout(int userId);

    void ViewAccountInfo(int userId);

}
