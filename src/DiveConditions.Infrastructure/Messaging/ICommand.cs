using System;

namespace DiveConditions.Infrastructure.Messaging
{
    public interface ICommand
    {
        /// <summary>
        /// Gets the command identifier.
        /// </summary>
        Guid Id { get; }
    }
}
