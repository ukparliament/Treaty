namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class SeatIncumbency : Incumbency
    {
        public SeatIncumbency(INode node) : base(node) { }

        public ICollection<HouseSeat> SeatIncumbencyHasHouseSeat => new DynamicObjectCollection<HouseSeat>(this, Property(UKParliamentOntology.SeatIncumbencyHasHouseSeat));

        public ICollection<ParliamentPeriod> SeatIncumbencyHasParliamentPeriod => new DynamicObjectCollection<ParliamentPeriod>(this, Property(UKParliamentOntology.SeatIncumbencyHasParliamentPeriod));
    }
}
