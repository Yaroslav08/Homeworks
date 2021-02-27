using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TestLaba.Models;
namespace TestLaba.Repositories
{
    public interface IPostRepository : IRepository<Post, long>
    {
        Task<List<Post>> GetPostsByUserIdAsync(int UserId);
    }
}