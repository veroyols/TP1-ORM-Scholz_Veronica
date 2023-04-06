﻿using Application.Interfaces;
using Application.Models;
using Domain.Entities;

namespace Application.UseCase
{
    public class ServiceComandaMercaderia : IServiceComandaMercaderia
    {
        private readonly ICommandComandaMercaderia _command;

        public ServiceComandaMercaderia(ICommandComandaMercaderia command)
        {
            _command = command;
        }
        public async Task InsertarMercaderias(ComandaMercaderiaDto comandaMercaderiaDto)
        {
            var list = comandaMercaderiaDto.mercaderiaSeleccionada;
            foreach (var item in list)
            {
                for (int i = 0; i < item.Value.Cantidad; i++ )
                {
                    ComandaMercaderia comandaMercaderia = new ()
                    {
                        ComandaId = comandaMercaderiaDto.ComandaId,
                        MercaderiaId = item.Key,
                    };
                    await _command.InsertarComandaMercaderia(comandaMercaderia);
                    //o crear una lista e insertarlos juntos
                }
            }
        }
    }
}
