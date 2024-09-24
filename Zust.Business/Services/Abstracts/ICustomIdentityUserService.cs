using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zust.Business.Services.Concretes;
using Zust.Entities.Entities;

namespace Zust.Business.Services.Abstracts
{
    public interface ICustomIdentityUserService
    {
        Task<List<CustomIdentityUser>> GetAllAsync();
        Task<CustomIdentityUser> GetByIdAsync(string id);
        Task AddAsync(CustomIdentityUser customIdentityUserService);
        Task UpdateAsync(CustomIdentityUser customIdentityUserService);
        Task DeleteAsync(CustomIdentityUser customIdentityUserService);

    }
}
