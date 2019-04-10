namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class SeatIncumbency : Incumbency
    {
        public SeatIncumbency(INode node) : base(node) { }

        public HouseSeat SeatIncumbencyHasHouseSeat => ((IEnumerable<HouseSeat>)new DynamicObjectCollection<HouseSeat>(this, Property(UKParliamentOntology.SeatIncumbencyHasHouseSeat.Uri))).SingleOrDefault();

        public ICollection<ParliamentPeriod> SeatIncumbencyHasParliamentPeriod => new DynamicObjectCollection<ParliamentPeriod>(this, Property(UKParliamentOntology.SeatIncumbencyHasParliamentPeriod.Uri));
    }
}
