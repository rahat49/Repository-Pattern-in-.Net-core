using EF.Core.Repository.Repository;
using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Interfaces.Repository;
using RepositoryPattern.Models;

namespace RepositoryPattern.Repository
{
    public class ProductRepository : CommonRepository<Product>, IProductRepo
    {
        public ProductRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
