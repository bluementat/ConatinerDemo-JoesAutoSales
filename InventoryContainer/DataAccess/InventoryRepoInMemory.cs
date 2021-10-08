using InventoryContainer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryContainer.DataAccess
{
    public class InventoryRepoInMemory : IInventoryRepository
    {
        private List<InventoryItem> Inventory;
        
        public InventoryRepoInMemory()
        {
            Inventory = LoadData();
        }

        public List<InventoryItem> GetAll()
        {
            return Inventory;
        }

        public InventoryItem Find(Guid id)
        {
            return Inventory.FirstOrDefault(i => i.Id == id);            
        }

        private List<InventoryItem> LoadData()
        {
            List<InventoryItem> result = new List<InventoryItem>();

            result.Add(new InventoryItem()
            {
                Id = Guid.NewGuid(),
                Make = "Buick",
                Model = "Enclave",
                Color = "White",
                Price = 40123.99M,
                UnitsInStock = 5
            });

            result.Add(new InventoryItem()
            {
                Id = Guid.NewGuid(),
                Make = "Ford",
                Model = "Bronco",
                Color = "Black",
                Price = 28320.99M,
                UnitsInStock = 2
            });

            result.Add(new InventoryItem()
            {
                Id = Guid.NewGuid(),
                Make = "Dodge",
                Model = "Charger",
                Color = "White",
                Price = 31500.99M,
                UnitsInStock = 10
            });

            return result;
        }
    }
}
