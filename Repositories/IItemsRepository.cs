using System;
using System.Collections.Generic;
using ShopManager.Entities;

namespace ShopManager.Repositories
{
    public interface IItemsRepository
    {
        Item GetItem(Guid id);
        IEnumerable<Item> GetItems();
    }
}