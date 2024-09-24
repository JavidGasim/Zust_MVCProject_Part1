using Azure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zust.Business.Services.Abstracts;
using Zust.DataAccess.Repositories.Abstracts;
using Zust.Entities.Entities;
//using Zust.Business.Services.Abstracts

namespace Zust.Business.Services.Concretes
{
    public class CustomIdentityUserService : ICustomIdentityUserService
    {
        private readonly ICustomIdentityUserDAL? _userDal;

        public CustomIdentityUserService(ICustomIdentityUserDAL? userDal)
        {
            _userDal = userDal;
        }

        public async Task AddAsync(CustomIdentityUser user)
        {
            await _userDal.AddAsync(user);
        }

        public async Task DeleteAsync(CustomIdentityUser user)
        {
            await _userDal.DeleteAsync(user);
        }

        public async Task<List<CustomIdentityUser>> GetAllAsync()
        {
            return await _userDal.GetAllAsync();
        }

        public async Task<CustomIdentityUser> GetByIdAsync(string id)
        {
            return await _userDal.GetByIdAsync(id);
        }

        public async Task UpdateAsync(CustomIdentityUser user)
        {
            await _userDal.UpdateAsync(user);
        }
    }
}
