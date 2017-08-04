using System.Threading.Tasks;
using Aspnetcore.OrderingApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace Aspnetcore.OrderingApp.Components
{
    public class InventoryWidget : ViewComponent
    {
        private readonly IInventoryService _inventoryService;

        public InventoryWidget(IInventoryService inventoryService)
        {
            _inventoryService = inventoryService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int threshold = 10)
        {
            var inventory = _inventoryService.GetInventoryLevels(threshold);

            return View(inventory);
        }
    }

    public class InventoryItem
    {
        public int Count { get; set; }
        public string Name { get; set; }
    }
}
