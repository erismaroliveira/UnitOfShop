using UnitOfShop.Data;
using UnitOfShop.Models;
using UnitOfShop.Repositories.Interfaces;

namespace UnitOfShop.Repositories;

public class OrderRepository : IOrderRepository
{
    private readonly DataContext _context;

    public OrderRepository(DataContext context)
    {
        _context = context;
    }

    public void Save(Order order)
    {
        _context.Orders.Add(order);
    }
}