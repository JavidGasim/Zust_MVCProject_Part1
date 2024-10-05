﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zust.Entities.Entities;

namespace Zust.Business.Services.Abstracts
{
    public interface ILikedCommentService
    {
        Task<List<LikedComment>> GetAllAsync();
        Task<LikedComment> GetByIdAsync(int id);
        Task AddAsync(LikedComment value);
        Task UpdateAsync(LikedComment value);
        Task DeleteAsync(LikedComment value);
    }
}
