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
    public class FriendDAL : IFriendDAL
    {
        private readonly ZustDbContext _context;
        public FriendDAL(ZustDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Friend friend)
        {
            await _context.Friends.AddAsync(friend);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Friend friend)
        {
            _context.Friends.Remove(friend);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Friend>> GetAllAsync()
        {
            var friends = await _context.Friends.ToListAsync();
            return friends;
        }

        public async Task<Friend> GetByIdAsync(int id)
        {
            var friend = await _context.Friends.FirstOrDefaultAsync(x => x.Id == id);
            return friend;
        }

        public async Task UpdateAsync(Friend friend)
        {
            _context.Friends.Update(friend);
            await _context.SaveChangesAsync();
        }
    }
}
