﻿using System;

namespace Fornecedores.Bussines.Models
{
    public abstract class Entity
    {
        protected Entity()
        {
            Id = new Guid();
        }
        public Guid Id { get; set; }
    }
}