using System;
using System.Collections.Generic;
using ShoppingApp.API.Models;

namespace ShoppingApp.API.Data
{
    public interface IShoppingService
    {
        IEnumerable<ShoppingItem> GetAllItems();
        ShoppingItem Add(ShoppingItem newItem);
        ShoppingItem GetById(Guid id);
        void Remove(Guid id);
    }
}