using FileBaseContext.Abstractions.Models.FileSet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IDataContext : IAsyncDisposable
{

    ValueTask SaveChangesAsync();
}
