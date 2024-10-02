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
    public class MessageDAL : IMessageDAL
    {
        private readonly ZustDbContext _context;
        public MessageDAL(ZustDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Message message)
        {
            await _context.Messages.AddAsync(message);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Message message)
        {
            _context.Messages.Remove(message);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Message>> GetAllAsync()
        {
            var messages = await _context.Messages.ToListAsync();
            return messages;
        }

        public async Task<Message> GetByIdAsync(int id)
        {
            var message = await _context.Messages.FirstOrDefaultAsync(x => x.Id == id);
            return message;
        }

        public async Task UpdateAsync(Message message)
        {
            _context.Messages.Update(message);
            await _context.SaveChangesAsync();
        }
    }
}
