using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JA.Models.OrderModels
{
    public class OrderDetail : Entity<OrderDetail>, IOrderDetail
    {

        public IDisposable Subscribe(IObserver<OrderDetail> observer)
        {
            throw new NotImplementedException();
        }
    }

    public interface IOrderDetail
    {
    }
}
