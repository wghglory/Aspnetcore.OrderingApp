using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Aspnetcore.OrderingApp.Models
{
    // EF database first, use this method to avoid DataAnotation disappears when auto generating code from database update
    [ModelMetadataType(typeof(OrderMeta))]
    public partial class Order
    {
    }

    public class OrderMeta
    {
        [ScaffoldColumn(false)]  // this field won't be display in client
        public int Id { get; set; }
        [Required]
        public string CompanyName { get; set; }
    }
}
