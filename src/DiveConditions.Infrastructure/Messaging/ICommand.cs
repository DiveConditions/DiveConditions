using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiveConditions.Infrastructure.Command
{
    public interface ICommand
    {
        /// <summary>
        /// Gets the command identifier.
        /// </summary>
        Guid Id { get; }
    }
}
