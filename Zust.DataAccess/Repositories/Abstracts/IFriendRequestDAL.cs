using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zust.Entities.Entities;

namespace Zust.DataAccess.Repositories.Abstracts
{
    public interface IFriendRequestDAL
    {
        Task<List<FriendRequest>> GetAllAsync();
        Task<FriendRequest> GetByIdAsync(int id);
        Task AddAsync(FriendRequest friendRequest);
        Task UpdateAsync(FriendRequest friendRequest);
        Task DeleteAsync(FriendRequest friendRequest);
    }
}
