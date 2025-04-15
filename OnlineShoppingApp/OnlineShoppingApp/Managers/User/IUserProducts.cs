using System;


public interface IUserProducts
{
    void AddProduct(int productID, int userId);

    void ViewCategory(int categoryId);

    void ViewSearch(string searchString);

}
