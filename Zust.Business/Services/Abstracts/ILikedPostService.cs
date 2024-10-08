﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zust.Entities.Entities;

namespace Zust.Business.Services.Abstracts
{
    public interface ILikedPostService
    {
        Task<List<LikedPost>> GetAllAsync();
        Task<LikedPost> GetByIdAsync(int id);
        Task AddAsync(LikedPost value);
        Task UpdateAsync(LikedPost value);
        Task DeleteAsync(LikedPost value);
    }
}
