namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class HouseSeatType : UKParliamentDynamicNode
    {
        public HouseSeatType(INode node) : base(node) { }

        public ICollection<HouseSeat> HouseSeatTypeHasHouseSeat => new DynamicObjectCollection<HouseSeat>(this, Property(UKParliamentOntology.HouseSeatTypeHasHouseSeat));

        public string HouseSeatTypeName => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.HouseSeatTypeName))).SingleOrDefault();

        public string HouseSeatTypeDescription => ((IEnumerable<string>)new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.HouseSeatTypeDescription))).SingleOrDefault();
    }
}
