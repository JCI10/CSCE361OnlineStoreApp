using System;

namespace User
{
    public interface IUserProducts
    {
        void AddProduct(ProductId productID, UserId userId);

        void ViewCategory(CategoryId categoryId);

        void ViewSearch(string searchString);

    }
}