namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class PastThing : TemporalThing
    {
        public PastThing(INode node) : base(node) { }

        public ICollection<DateTimeOffset> EndDate => new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.EndDate));
    }
}
