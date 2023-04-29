using UnitOfShop.Models;

namespace UnitOfShop.Repositories.Interfaces;

public interface ICustomerRepository
{
    void Save(Customer customer);
}
