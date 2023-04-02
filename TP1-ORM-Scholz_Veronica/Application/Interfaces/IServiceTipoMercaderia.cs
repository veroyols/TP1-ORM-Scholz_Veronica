﻿using Domain.Entities;

namespace Application.Interfaces
{
    public interface IServiceTipoMercaderia
    {
        public List<TipoMercaderia> GetAllTiposMercaderia();
        public int GetCantidadDeTipos(int tipoMercaderiaId);

    }
}
