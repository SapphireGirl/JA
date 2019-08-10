using System;
using System.Collections.Generic;
using System.Text;

namespace JA.ModelsCore.Order
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
