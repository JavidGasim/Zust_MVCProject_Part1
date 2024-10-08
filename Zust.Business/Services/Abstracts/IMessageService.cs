﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zust.Entities.Entities;

namespace Zust.Business.Services.Abstracts
{
    public interface IMessageService
    {
        Task<List<Message>> GetAllAsync();
        Task<Message> GetByIdAsync(int id);
        Task AddAsync(Message message);
        Task UpdateAsync(Message message);
        Task DeleteAsync(Message message);
    }
}
