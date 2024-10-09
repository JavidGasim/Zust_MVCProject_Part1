using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zust.Entities.Entities;

namespace Zust.DataAccess.Repositories.Abstracts
{
    public interface IMyNotificationDAL
    {
        Task<List<MyNotification>> GetAllAsync();
        Task<MyNotification> GetByIdAsync(int id);
        Task AddAsync(MyNotification notification);
        Task UpdateAsync(MyNotification notification);
        Task DeleteAsync(MyNotification notification);

    }
}
