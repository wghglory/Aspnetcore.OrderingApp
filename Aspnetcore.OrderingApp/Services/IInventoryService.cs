using System.Collections.Generic;
using Aspnetcore.OrderingApp.Components;

namespace Aspnetcore.OrderingApp.Services
{
    public interface IInventoryService
    {
        List<InventoryItem> GetInventoryLevels(int threshold);
    }
}
