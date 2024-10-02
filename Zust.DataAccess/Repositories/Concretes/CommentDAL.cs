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
    public class CommentDAL : ICommentDAL
    {
        private readonly ZustDbContext _context;
        public CommentDAL(ZustDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Comment comment)
        {
            await _context.Comments.AddAsync(comment);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Comment comment)
        {
            _context.Comments.Remove(comment);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Comment>> GetAllAsync()
        {
            var chats = await _context.Comments.Include(nameof(Comment.Sender)).Include(nameof(Comment.Post)).ToListAsync();
            return chats;
        }

        public async Task<Comment> GetByIdAsync(int id)
        {
            var chat = await _context.Comments.Include(nameof(Comment.Sender)).Include(nameof(Comment.Post)).FirstOrDefaultAsync(x => x.Id == id);
            return chat;
        }

        public async Task UpdateAsync(Comment comment)
        {
            _context.Comments.Update(comment);
            await _context.SaveChangesAsync();
        }
    }
}
