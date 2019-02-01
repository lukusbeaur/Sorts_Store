using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class FakeIProductRepository : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product>
        {
            new Product
            {
                Name= "FootBall", Price= 50
            },
            new Product
            {
                Name ="Soccer Ball", Price =35
            },
            new Product
            {
                Name="Running Shows", Price = 95
            }
        }.AsQueryable<Product>();
    }
}
