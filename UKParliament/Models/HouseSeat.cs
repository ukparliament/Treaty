namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class HouseSeat : UKParliamentDynamicNode
    {
        public HouseSeat(INode node) : base(node) { }

        public ICollection<House> HouseSeatHasHouse => new DynamicObjectCollection<House>(this, Property(UKParliamentOntology.HouseSeatHasHouse));

        public ICollection<ConstituencyGroup> HouseSeatHasConstituencyGroup => new DynamicObjectCollection<ConstituencyGroup>(this, Property(UKParliamentOntology.HouseSeatHasConstituencyGroup));

        public ICollection<HouseSeatType> HouseSeatHasHouseSeatType => new DynamicObjectCollection<HouseSeatType>(this, Property(UKParliamentOntology.HouseSeatHasHouseSeatType));

        public ICollection<SeatIncumbency> HouseSeatHasSeatIncumbency => new DynamicObjectCollection<SeatIncumbency>(this, Property(UKParliamentOntology.HouseSeatHasSeatIncumbency));

        public ICollection<string> HouseSeatName => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.HouseSeatName));
    }
}
