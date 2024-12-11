﻿namespace GamingStore.MVC.Models;

public abstract class AuditableEntity:BaseEntity
{
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
}