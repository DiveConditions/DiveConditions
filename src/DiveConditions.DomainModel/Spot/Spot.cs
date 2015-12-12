using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DiveConditions.DomainModel.Spot
{

    public class Spot
    {
        public string Name { get; set; }
        public string WaterName { get; set; }
        public string CoutryName { get; set; }
        public Spottype Spottype { get; set; }
        public List<Condition> Conditions { get; set; }
    }


    [Flags]
    public enum Spottype
    {
        Sea,
        Lake,
        River,
        Ice,
        Cave,
        Wreck,
    }
}
