namespace DiveConditions.Infrastructure.Messaging.Handling
{
    public interface IEventHandlerRegistry
    {
        void Register(IEventHandler handler);
    }
}
