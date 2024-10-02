using Microsoft.EntityFrameworkCore;
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
    public class ChatDAL : IChatDAL
    {
        private readonly ZustDbContext _context;
        public ChatDAL(ZustDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Chat chat)
        {
            await _context.Chats.AddAsync(chat);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Chat chat)
        {
            _context.Chats.Remove(chat);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Chat>> GetAllAsync()
        {
            var chats = await _context.Chats.Include(nameof(Chat.Messages)).Include(nameof(Chat.Receiver)).ToListAsync();
            return chats;
        }

        public async Task<Chat> GetByIdAsync(int id)
        {
            var chat = await _context.Chats.FirstOrDefaultAsync(x => x.Id == id);
            return chat;
        }

        public async Task UpdateAsync(Chat chat)
        {
            _context.Chats.Update(chat);
            await _context.SaveChangesAsync();
        }

    }
}
