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
    public class FriendRequestDAL : IFriendRequestDAL
    {
        private readonly ZustDbContext _context;
        public FriendRequestDAL(ZustDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(FriendRequest friendRequest)
        {
            await _context.FriendRequests.AddAsync(friendRequest);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(FriendRequest friendRequest)
        {
            _context.FriendRequests.Remove(friendRequest);
            await _context.SaveChangesAsync();
        }

        public async Task<List<FriendRequest>> GetAllAsync()
        {
            var friendRequests = await _context.FriendRequests.ToListAsync();
            return friendRequests;
        }

        public async Task<FriendRequest> GetByIdAsync(int id)
        {
            var friendRequest = await _context.FriendRequests.FirstOrDefaultAsync(x => x.Id == id);
            return friendRequest;
        }

        public async Task UpdateAsync(FriendRequest friendRequest)
        {
            _context.FriendRequests.Update(friendRequest);
            await _context.SaveChangesAsync();
        }
    }
}
