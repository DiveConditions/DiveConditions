using System.Collections.Generic;

namespace DiveConditions.Infrastructure.Messaging
{
    public interface ICommandBus
    {
        void Send(Envelope<ICommand> command);
        void Send(IEnumerable<Envelope<ICommand>> commands);
    }
}
