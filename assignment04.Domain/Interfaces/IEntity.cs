﻿using System;

// An Entity is responsible for identity.
namespace assignment04.Domain.Interfaces
{
    // Use if single identity type is used across ALL entities.
    public interface IEntity
    {
        Guid Id { get; }
    }
}