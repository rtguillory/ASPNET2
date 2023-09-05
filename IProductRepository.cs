
using ASPNET2.Models;
using System.Collections.Generic;

namespace ASPNET2
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
    }
}
