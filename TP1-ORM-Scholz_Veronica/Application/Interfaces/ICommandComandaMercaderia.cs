﻿using Domain.Entities;

namespace Application.Interfaces
{
    public interface ICommandComandaMercaderia
    {
        public Task InsertarComandaMercaderia(ComandaMercaderia comandaMercaderia);
    }
}
