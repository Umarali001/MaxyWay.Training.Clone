using FileBaseContext.Abstractions.Models.Entity;

namespace Backend.Project.Domain.Common;

public abstract class Entity : IEntity
{
    public Guid Id { get; set; }
}