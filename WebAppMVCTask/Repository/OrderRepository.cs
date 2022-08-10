using Dapper;
using System.Data;
using WebAppMVCTask.HelperCode;
using WebAppMVCTask.Interface;
using WebAppMVCTask.Models;

namespace WebAppMVCTask.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public int Deletedetail(Orders orders)
        {
            var x = new DynamicParameters();
            x.Add("@OrderId", orders.OrderId, DbType.Int32);
            x.Add("@Flag", "Delete", DbType.String);
            return DataBaseFactory.QuerySP("Sp_orderDetails", param: x, module: "Delete.", dbCon: null);
        }

        public List<Orders> Display()
        {
            var x = new DynamicParameters();
            x.Add("@Flag", "Select", DbType.String);
            return DataBaseFactory.QuerySP<Orders>("Sp_orderDetails", param: x, module: "Display.", dbCon: null).ToList();
        }

        public int Insert(Orders orders)
        {
            var x = new DynamicParameters();
            x.Add("@OrderName", orders.OrderName, DbType.String);
            x.Add("@OrderNo", orders.OrderNo, DbType.String);
            x.Add("@Discount", orders.Discount, DbType.Decimal);
            x.Add("@Created", orders.Created, DbType.DateTime);
            x.Add("@Flag", "Insert", DbType.String);
            return DataBaseFactory.QuerySP("Sp_orderDetails", param: x, module: "Insert", dbCon: null);
        }

        public int Updatedetail(Orders orders)
        {
            var x = new DynamicParameters();
            x.Add("@OrderId", orders.OrderId, DbType.Int32);
            x.Add("@OrderName", orders.OrderName, DbType.String);
            x.Add("@OrderNo", orders.OrderNo, DbType.String);
            x.Add("@Discount", orders.Discount, DbType.Decimal);
            x.Add("@Created", orders.Created, DbType.DateTime);
            x.Add("@Flag", "Update", DbType.String);
            return DataBaseFactory.QuerySP("Sp_orderDetails", param: x, module: "Update.", dbCon: null);
        }
    }
}
