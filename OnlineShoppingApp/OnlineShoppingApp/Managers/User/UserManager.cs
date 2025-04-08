using System;

namespace Managers
{
    public class UserManager : IUserAccount, IUserProducts
{
    void Login(string username, string password)
    {
        //TODO:Implement Method
    }

    void Logout(userId userId)
    {
        //TODO:Implement Method
    }

    void ViewAccountInfo(UserId userId)
    {
        //TODO:Implement Method
    }

    void AddProduct(ProductId productID, UserId userId)
    {
        //TODO:Implement Method
    }

    void ViewCategory(CategoryId categoryId)
    {
        //TODO:Implement Method
    }

    void ViewSearch(string searchString)
    {
        //TODO:Implement Method
    }
}
}