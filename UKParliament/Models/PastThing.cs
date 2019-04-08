namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class PastThing : TemporalThing
    {
        public PastThing(INode node) : base(node) { }

        public DateTimeOffset EndDate => ((IEnumerable<DateTimeOffset>)new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.EndDate))).SingleOrDefault();
    }
}
