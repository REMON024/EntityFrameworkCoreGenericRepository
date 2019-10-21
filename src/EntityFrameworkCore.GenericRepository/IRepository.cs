using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EntityFrameworkCore.GenericRepo.Models;

namespace EntityFrameworkCore.GenericRepo
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T> Add(T item, DbSet<T> set);
        Task Remove(int id, DbSet<T> set);
        Task<T> Update(T item);
        Task<T> FindByID(int id, DbSet<T> set);        
    }
}    