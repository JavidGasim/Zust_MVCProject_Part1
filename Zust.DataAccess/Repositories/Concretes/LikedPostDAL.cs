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
    public class LikedPostDAL : ILikedPostDAL
    {
        private readonly ZustDbContext _context;
        public LikedPostDAL(ZustDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(LikedPost value)
        {
            await _context.LikedPosts.AddAsync(value);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(LikedPost value)
        {
            _context.LikedPosts.Remove(value);
            await _context.SaveChangesAsync();
        }

        public async Task<List<LikedPost>> GetAllAsync()
        {
            var likedPosts = await _context.LikedPosts.Include(nameof(LikedPost.User)).Include(nameof(LikedPost.Post)).ToListAsync();
            return likedPosts;
        }

        public async Task<LikedPost> GetByIdAsync(int id)
        {
            var likedPosts = await _context.LikedPosts.Include(nameof(LikedPost.User)).Include(nameof(LikedPost.Post)).FirstOrDefaultAsync(x => x.Id == id);
            return likedPosts;
        }

        public async Task UpdateAsync(LikedPost value)
        {
            _context.LikedPosts.Update(value);
            await _context.SaveChangesAsync();
        }
    }
}
