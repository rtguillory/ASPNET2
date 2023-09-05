using ASPNET2.Models;
using Dapper;
using System.Collections.Generic;
using System.Data;

namespace ASPNET2
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDbConnection _conn;

        public ProductRepository(IDbConnection conn)
        {
            _conn = conn;
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return _conn.Query<Product>("SELECT * FROM PRODUCTS");
        }
    }
}
