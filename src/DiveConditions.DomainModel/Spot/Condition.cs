using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiveConditions.DomainModel.Spot
{
    public class Condition
    {
        public DateTime Date { get; set; }
        public List<DepthCondition> Depths { get; set; }
    }
}
