using WebUI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebUI.Services.Interfaces
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderResponseModel>> GetOrdersByUserName(string userName);
    }
}
