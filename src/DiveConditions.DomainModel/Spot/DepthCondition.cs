using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiveConditions.DomainModel.Spot
{
    public class DepthCondition
    {
        public int Depth { get; set; }
        public VisibilityRating Visibility { get; set; }
        public FlowRating Flow { get; set; }
        public FaunaRating Fauna { get; set; }
    }
}
