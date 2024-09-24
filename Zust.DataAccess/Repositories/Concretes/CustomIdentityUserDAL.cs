using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zust.DataAccess.Data;
using Zust.DataAccess.Repositories.Abstracts;
using Zust.Entities.Entities;

namespace Zust.DataAccess.Repositories.Concretes
{
    public class CustomIdentityUserDAL : ICustomIdentityUserDAL
    {
        private readonly ZustDbContext _context;

        public CustomIdentityUserDAL(ZustDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(CustomIdentityUser user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(CustomIdentityUser user)
        {
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }

        public async Task<List<CustomIdentityUser>> GetAllAsync()
        {
            var users = await _context.Users.ToListAsync();
            return users;
        }

        public async Task<CustomIdentityUser> GetByIdAsync(string id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
            return user;
        }

        public async Task UpdateAsync(CustomIdentityUser user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }
    }
}
