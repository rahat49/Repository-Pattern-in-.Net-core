using EF.Core.Repository.Interface.Repository;
using EF.Core.Repository.Manager;
using RepositoryPattern.Data;
using RepositoryPattern.Interfaces.Manager;
using RepositoryPattern.Models;
using RepositoryPattern.Repository;

namespace RepositoryPattern.Manager
{
    public class ProductManager : CommonManager<Product>, IProductManager
    {
        public ProductManager(ApplicationDbContext dbContext):base(new ProductRepository(dbContext))
        {

        }

        public Product GetById(int id)
        {
            return GetFirstOrDefault(c=>c.Id == id);
        }
    }
}
