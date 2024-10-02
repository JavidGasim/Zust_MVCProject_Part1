using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zust.Business.Services.Abstracts;
using Zust.DataAccess.Repositories.Abstracts;
using Zust.Entities.Entities;

namespace Zust.Business.Services.Concretes
{
    public class CommentService : ICommentService
    {
        private readonly ICommentDAL _commentDAL;
        public CommentService(ICommentDAL commentDAL)
        {
            _commentDAL = commentDAL;
        }

        public async Task AddAsync(Comment comment)
        {
            await _commentDAL.AddAsync(comment);
        }

        public async Task DeleteAsync(Comment comment)
        {
            await _commentDAL.DeleteAsync(comment);
        }

        public async Task<List<Comment>> GetAllAsync()
        {
            return await _commentDAL.GetAllAsync();
        }

        public Task<Comment> GetByIdAsync(int id)
        {
            return _commentDAL.GetByIdAsync(id);
        }

        public async Task UpdateAsync(Comment comment)
        {
            await _commentDAL.UpdateAsync(comment);
        }
    }
}
