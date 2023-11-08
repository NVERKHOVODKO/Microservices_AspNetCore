﻿namespace Entities;

public class BaseEntity : IEntity
{
    public DateTime DateCreated { get; set; } = DateTime.Now;
    public DateTime? DateUpdated { get; set; }
    public Guid Id { get; set; }
}