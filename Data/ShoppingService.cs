using System;
using System.Collections.Generic;
using ShoppingApp.API.Models;

namespace ShoppingApp.API.Data
{
    public class ShoppingService : IShoppingService
    {
        public ShoppingItem Add(ShoppingItem newItem)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ShoppingItem> GetAllItems()
        {
            throw new NotImplementedException();
        }

        public ShoppingItem GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}