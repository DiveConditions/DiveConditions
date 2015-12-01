using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using DiveConditions.Infrastructure.EventSourcing;

namespace DiveConditions.DomainModel.Spot
{

    public class Spot : EventSourced, IAggregateRoot
    {
        public Spot(Guid id)
            : base(id)
        {
            Handles<DiveConditionUpdated>(OnSpotUpdated);
        }

        public Spot(Guid id, IEnumerable<IVersionedEvent> history) : this(id)
        {
            LoadFrom(history);
        }

        public void ReportDiveCondition(Visibility visibility)
        {
            Update(new DiveConditionUpdated { Visibility = visibility });
        }

        private void OnSpotUpdated(DiveConditionUpdated e)
        {
            //this.seats = e.Seats.ToList();
        }
    }
}
