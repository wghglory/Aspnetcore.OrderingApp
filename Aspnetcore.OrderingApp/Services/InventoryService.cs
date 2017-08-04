using System.Collections.Generic;
using System.Linq;
using Aspnetcore.OrderingApp.Components;

namespace Aspnetcore.OrderingApp.Services
{
    public class InventoryService : IInventoryService
    {
        public List<InventoryItem> GetInventoryLevels(int threshold)
        {
            var inventory = new List<InventoryItem>()
            {
                new InventoryItem() {  Name = "Banner", Count = 8 },
                new InventoryItem() {  Name = "Markers", Count = 3 },
                new InventoryItem() {  Name = "Jacket", Count = 4 },
                new InventoryItem() {  Name = "Hoodie", Count = 12 },
                new InventoryItem() {  Name = "Poster", Count = 6 },
                new InventoryItem() {  Name = "Pens", Count = 16 }
            };

            return inventory.Where(x => x.Count <= threshold).ToList();
        }
    }
}
