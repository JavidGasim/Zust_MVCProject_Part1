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
    public class ChatService : IChatService
    {
        private readonly IChatDAL _chatDAL;

        public ChatService(IChatDAL chatDAL)
        {
            _chatDAL = chatDAL;
        }

        public async Task AddAsync(Chat chat)
        {
            await _chatDAL.AddAsync(chat);
        }

        public async Task DeleteAsync(Chat chat)
        {
            await _chatDAL.DeleteAsync(chat);
        }

        public async Task<List<Chat>> GetAllAsync()
        {
            return await _chatDAL.GetAllAsync();
        }

        public async Task<Chat> GetByIdAsync(int id)
        {
            return await _chatDAL.GetByIdAsync(id);
        }

        public async Task UpdateAsync(Chat chat)
        {
            await _chatDAL.UpdateAsync(chat);
        }
    }
}
