using System.Collections.Generic;
using Aspnetcore.OrderingApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Aspnetcore.OrderingApp.Services
{
    public interface IFormDataService
    {
        List<SelectListItem> GetLocations();
        List<SelectListItem> GetClientTypes();
        List<SelectListItem> GetOrderStages();
        List<OrderProductVM> GetProducts();
    }
}
