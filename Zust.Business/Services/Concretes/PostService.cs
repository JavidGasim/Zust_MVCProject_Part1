﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zust.Business.Services.Abstracts;
using Zust.DataAccess.Repositories.Abstracts;
using Zust.Entities.Entities;

namespace Zust.Business.Services.Concretes
{
    public class PostService : IPostService
    {
        private readonly IPostDAL _postDAL;
        public PostService(IPostDAL postDAL)
        {
            _postDAL = postDAL;
        }
        public async Task AddAsync(Post post)
        {
            await _postDAL.AddAsync(post);
        }

        public async Task DeleteAsync(Post post)
        {
            await _postDAL.DeleteAsync(post);
        }

        public async Task<List<Post>> GetAllAsync()
        {
            return await _postDAL.GetAllAsync();
        }

        public async Task<Post> GetByIdAsync(int id)
        {
            return await _postDAL.GetByIdAsync(id);
        }

        public async Task UpdateAsync(Post post)
        {
            await _postDAL.UpdateAsync(post);
        }
    }
}
