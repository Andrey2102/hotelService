using Entites;

namespace Data.Repositories.Abstracts
{
    interface IOrdersRepository
    {
        void addOrder(OrderEntity order);
        void updateOrder(OrderEntity order);
        OrderEntity getOrderById(int id);
        void deleteOrderById(int id);
    }
}
