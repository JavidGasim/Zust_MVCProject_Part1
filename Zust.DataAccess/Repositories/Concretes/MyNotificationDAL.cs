﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zust.DataAccess.Data;
using Zust.DataAccess.Repositories.Abstracts;
using Zust.Entities.Entities;

namespace Zust.DataAccess.Repositories.Concretes
{
    public class MyNotificationDAL : IMyNotificationDAL
    {
        private readonly ZustDbContext _context;
        public MyNotificationDAL(ZustDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(MyNotification notification)
        {
            await _context.MyNotifications.AddAsync(notification);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(MyNotification notification)
        {
            _context.MyNotifications.Remove(notification);
            await _context.SaveChangesAsync();
        }

        public async Task<List<MyNotification>> GetAllAsync()
        {
            var notifications = await _context.MyNotifications.ToListAsync();
            return notifications;
        }

        public async Task<MyNotification> GetByIdAsync(int id)
        {
            var notification = await _context.MyNotifications.FirstOrDefaultAsync(x => x.Id == id);
            return notification;
        }

        public async Task UpdateAsync(MyNotification notification)
        {
            _context.MyNotifications.Update(notification);
            await _context.SaveChangesAsync();
        }
    }
}
