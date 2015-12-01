using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiveConditions.DomainModel
{
    public interface IAggregateRoot
    {
        Guid Id { get; }
    }
}
