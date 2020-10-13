using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TestLaba.Context;
using TestLaba.Models;

namespace TestLaba.Repositories.Imlp
{
    public class PostRepository : IPostRepository
    {
        private BlogContext db;
        public PostRepository()
        {
            db = new BlogContext();
        }

        public async Task<Post> CreateAsync(Post model)
        {
            db.Posts.Add(model);
            await SaveAsync();
            return model;
        }

        public async Task<Post> EditAsync(Post model)
        {
            db.Posts.Update(model);
            await SaveAsync();
            return model;
        }

        public async Task<List<Post>> GetAllAsync()
        {
            return await db.Posts.AsNoTracking().ToListAsync();
        }

        public async Task<Post> GetByIdAsTrackingAsync(long Id)
        {
            return await db.Posts.FindAsync(Id);
        }

        public async Task<Post> GetByIdAsync(long Id)
        {
            return await db.Posts.AsNoTracking().FirstOrDefaultAsync(d => d.Id == Id);
        }

        public async Task<Post> GetByWhereAsync(Expression<Func<Post, bool>> match)
        {
            return await db.Posts.AsNoTracking().FirstOrDefaultAsync(match);
        }

        public async Task<List<Post>> GetListByWhereAsync(Expression<Func<Post, bool>> match)
        {
            return await db.Posts.AsNoTracking().Where(match).ToListAsync();
        }

        public async Task<List<Post>> GetPostsByUserIdAsync(int UserId)
        {
            return await db.Posts.AsNoTracking().Where(d => d.UserId == UserId).ToListAsync();
        }

        public async Task RemoveAsync(Post model)
        {
            db.Posts.Remove(model);
            await SaveAsync();
        }

        public async Task SaveAsync()
        {
            await db.SaveChangesAsync();
        }
    }
}
