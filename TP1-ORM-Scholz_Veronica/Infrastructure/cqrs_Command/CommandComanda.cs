using Application.Interfaces;
using Domain.Entities;
using Domain.Models;
using Infrastructure.Persistence;

namespace Infrastructure.cqrs_Command
{
    public class CommandComanda : ICommandComanda
    {
        private readonly AppDbContext _appDbContext;

        public CommandComanda(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task InsertarComanda(ComandaDto comandaDto)
        {
            _appDbContext.Add(comandaDto);
            await _appDbContext.SaveChangesAsync();
        }
    }
}
