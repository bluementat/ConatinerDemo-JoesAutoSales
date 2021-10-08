using InventoryContainer.Models;
using System;
using System.Collections.Generic;

namespace InventoryContainer.DataAccess
{
    public interface IInventoryRepository
    {
        InventoryItem Find(Guid id);
        List<InventoryItem> GetAll();
    }
}