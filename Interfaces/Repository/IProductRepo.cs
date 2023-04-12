using EF.Core.Repository.Interface.Manager;
using EF.Core.Repository.Interface.Repository;
using RepositoryPattern.Models;

namespace RepositoryPattern.Interfaces.Repository
{
    public interface IProductRepo:ICommonRepository<Product>
    {
    }
}
