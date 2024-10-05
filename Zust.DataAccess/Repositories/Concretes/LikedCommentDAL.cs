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
    public class LikedCommentDAL : ILikedCommentDAL
    {
        private readonly ZustDbContext _context;
        public LikedCommentDAL(ZustDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(LikedComment value)
        {
            await _context.LikedComments.AddAsync(value);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(LikedComment value)
        {
            _context.LikedComments.Remove(value);
            await _context.SaveChangesAsync();
        }

        public async Task<List<LikedComment>> GetAllAsync()
        {
            var likedComments = await _context.LikedComments.Include(nameof(LikedComment.User)).Include(nameof(LikedComment.Comment)).ToListAsync();
            return likedComments;
        }

        public async Task<LikedComment> GetByIdAsync(int id)
        {
            var likedComment = await _context.LikedComments.Include(nameof(LikedComment.User)).Include(nameof(LikedComment.Comment)).FirstOrDefaultAsync(x => x.Id == id);
            return likedComment;
        }

        public async Task UpdateAsync(LikedComment value)
        {
            _context.LikedComments.Update(value);
            await _context.SaveChangesAsync();
        }
    }
}
