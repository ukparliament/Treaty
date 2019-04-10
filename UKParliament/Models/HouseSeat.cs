namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class HouseSeat : UKParliamentDynamicNode
    {
        public HouseSeat(INode node) : base(node) { }

        public House HouseSeatHasHouse => ((IEnumerable<House>)new DynamicObjectCollection<House>(this, Property(UKParliamentOntology.HouseSeatHasHouse.Uri))).SingleOrDefault();

        public ConstituencyGroup HouseSeatHasConstituencyGroup => ((IEnumerable<ConstituencyGroup>)new DynamicObjectCollection<ConstituencyGroup>(this, Property(UKParliamentOntology.HouseSeatHasConstituencyGroup.Uri))).SingleOrDefault();

        public HouseSeatType HouseSeatHasHouseSeatType => ((IEnumerable<HouseSeatType>)new DynamicObjectCollection<HouseSeatType>(this, Property(UKParliamentOntology.HouseSeatHasHouseSeatType.Uri))).SingleOrDefault();

        public ICollection<SeatIncumbency> HouseSeatHasSeatIncumbency => new DynamicObjectCollection<SeatIncumbency>(this, Property(UKParliamentOntology.HouseSeatHasSeatIncumbency.Uri));

        public string HouseSeatName => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.HouseSeatName.Uri))).SingleOrDefault();
    }
}
