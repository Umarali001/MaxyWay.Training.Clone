using FileBaseContext.Abstractions.Models.Entity;

namespace Backend.Project.Domain.Common;

public interface IEntity : IFileSetEntity<Guid>
{
}
