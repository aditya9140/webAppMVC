using WebAppMVCTask.Models;

namespace WebAppMVCTask.Interface
{
    public interface IOrderRepository
    {
        int Insert(Orders orders);
        int Updatedetail(Orders orders);

        List<Orders> Display();

        int Deletedetail(Orders orders);
    }
}
