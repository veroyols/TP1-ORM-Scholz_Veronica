using Application.Interfaces;
using Domain.Models;
using Infrastructure.Persistence;

namespace Infrastructure.cqrs_Command
{
    public class CommandComandaMercaderia : ICommandComandaMercaderia
    {
        private readonly AppDbContext _appDbContext;

        public CommandComandaMercaderia(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task InsertarComandaMercaderia(ComandaDto comandaDto)
        {
            _appDbContext.Add(comandaDto);
            await _appDbContext.SaveChangesAsync();
        }
    }
}
