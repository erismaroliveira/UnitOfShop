using UnitOfShop.Models;

namespace UnitOfShop.Repositories.Interfaces;

public interface IOrderRepository
{
    void Save(Order order);
}
