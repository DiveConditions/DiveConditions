using DiveConditions.Infrastructure.EventSourcing;

namespace DiveConditions.DomainModel.Spot
{
    internal class DiveConditionUpdated : VersionedEvent
    {
        public Visibility Visibility { get; set; }
    }
}