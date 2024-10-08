﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zust.Entities.Entities;

namespace Zust.Business.Services.Abstracts
{
    public interface IFriendRequestService
    {
        Task<List<FriendRequest>> GetAllAsync();
        Task<FriendRequest> GetByIdAsync(int id);
        Task AddAsync(FriendRequest friendRequest);
        Task UpdateAsync(FriendRequest friendRequest);
        Task DeleteAsync(FriendRequest friendRequest);
    }
}
