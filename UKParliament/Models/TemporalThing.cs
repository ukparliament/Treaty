namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class TemporalThing : UKParliamentDynamicNode
    {
        public TemporalThing(INode node) : base(node) { }

        public ICollection<DateTimeOffset> Date => new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.Date));

        public DateTimeOffset StartDate => ((IEnumerable<DateTimeOffset>)new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.StartDate))).SingleOrDefault();
    }
}
