namespace DiveConditions.Infrastructure.EventSourcing
{
    using System;

    public class VersionedEvent : IVersionedEvent
    {
        public int Version { get; set; }

        public Guid SourceId { get; set; }
    }
}