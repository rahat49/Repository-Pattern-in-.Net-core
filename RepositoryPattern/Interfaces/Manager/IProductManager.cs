using EF.Core.Repository.Interface.Manager;
using RepositoryPattern.Models;

namespace RepositoryPattern.Interfaces.Manager
{
    public interface IProductManager:ICommonManager<Product>
    {
        Product GetById(int id);
    }
}
