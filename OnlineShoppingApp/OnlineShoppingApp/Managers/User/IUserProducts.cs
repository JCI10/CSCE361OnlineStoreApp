using System;

namespace User
{
    public class IUserProducts
    {
        void AddProduct(ProductId productID, UserId userId);

        void ViewCategory(CategoryId categoryId);

        void ViewSearch(string searchString);

    }
}