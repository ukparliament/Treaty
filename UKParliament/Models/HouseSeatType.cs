namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class HouseSeatType : UKParliamentDynamicNode
    {
        public HouseSeatType(INode node) : base(node) { }

        public ICollection<HouseSeat> HouseSeatTypeHasHouseSeat => new DynamicObjectCollection<HouseSeat>(this, Property(UKParliamentOntology.HouseSeatTypeHasHouseSeat));

        public ICollection<string> HouseSeatTypeName => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.HouseSeatTypeName));

        public ICollection<string> HouseSeatTypeDescription => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.HouseSeatTypeDescription));
    }
}
