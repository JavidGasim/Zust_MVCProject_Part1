﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zust.Business.Services.Abstracts;
using Zust.DataAccess.Repositories.Abstracts;
using Zust.Entities.Entities;

namespace Zust.Business.Services.Concretes
{
    public class MessageService : IMessageService
    {
        private readonly IMessageDAL _messageDAL;

        public MessageService(IMessageDAL messageDAL)
        {
            _messageDAL = messageDAL;
        }

        public async Task AddAsync(Message message)
        {
            await _messageDAL.AddAsync(message);
        }

        public async Task DeleteAsync(Message message)
        {
            await _messageDAL.DeleteAsync(message);
        }

        public async Task<List<Message>> GetAllAsync()
        {
            return await _messageDAL.GetAllAsync();
        }

        public async Task<Message> GetByIdAsync(int id)
        {
            return await _messageDAL.GetByIdAsync(id);
        }

        public async Task UpdateAsync(Message message)
        {
            await _messageDAL.UpdateAsync(message);
        }
    }
}
