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
    public class UserRepository : IUserRepository
    {
        private BlogContext db;
        public UserRepository()
        {
            db = new BlogContext();
        }

        public async Task<User> CreateAsync(User model)
        {
            db.Users.Add(model);
            await SaveAsync();
            return model;
        }

        public async Task<User> EditAsync(User model)
        {
            db.Users.Update(model);
            await SaveAsync();
            return model;
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await db.Users.AsNoTracking().ToListAsync();
        }

        public async Task<User> GetByIdAsTrackingAsync(int Id)
        {
            return await db.Users.FindAsync(Id);
        }

        public async Task<User> GetByIdAsync(int Id)
        {
            return await db.Users.AsNoTracking().FirstOrDefaultAsync(d => d.Id == Id); 
        }

        public async Task<User> GetByWhereAsync(Expression<Func<User, bool>> match)
        {
            return await db.Users.AsNoTracking().FirstOrDefaultAsync(match);
        }

        public async Task<List<User>> GetListByWhereAsync(Expression<Func<User, bool>> match)
        {
            return await db.Users.AsNoTracking().Where(match).ToListAsync();
        }

        public async Task RemoveAsync(User model)
        {
            db.Users.Remove(model);
            await SaveAsync();
        }

        public async Task SaveAsync()
        {
            await db.SaveChangesAsync();
        }
    }
}