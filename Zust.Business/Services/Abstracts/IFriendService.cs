﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zust.Entities.Entities;

namespace Zust.Business.Services.Abstracts
{
    public interface IFriendService
    {
        Task<List<Friend>> GetAllAsync();
        Task<Friend> GetByIdAsync(int id);
        Task AddAsync(Friend friend);
        Task UpdateAsync(Friend friend);
        Task DeleteAsync(Friend friend);
    }
}
