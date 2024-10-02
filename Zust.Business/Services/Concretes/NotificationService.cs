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
    public class NotificationService : INotificationService
    {
        private readonly INotificationDAL _notificationDAL;
        public NotificationService(INotificationDAL notificationDAL)
        {
            _notificationDAL = notificationDAL;
        }

        public async Task AddAsync(Notification notification)
        {
            await _notificationDAL.AddAsync(notification);
        }

        public async Task DeleteAsync(Notification notification)
        {
            await _notificationDAL.DeleteAsync(notification);
        }

        public async Task<List<Notification>> GetAllAsync()
        {
            return await _notificationDAL.GetAllAsync();
        }

        public async Task<Notification> GetByIdAsync(int id)
        {
            return await _notificationDAL.GetByIdAsync(id);
        }

        public async Task UpdateAsync(Notification notification)
        {
            await _notificationDAL.UpdateAsync(notification);
        }
    }
}
