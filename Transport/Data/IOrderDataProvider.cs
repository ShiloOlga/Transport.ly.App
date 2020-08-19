using System.Collections.Generic;
using Transport.ly.App.Model;

namespace Transport.ly.App.Data
{
    public interface IOrderDataProvider
    {
        IReadOnlyList<Order> Load();
    }
}
