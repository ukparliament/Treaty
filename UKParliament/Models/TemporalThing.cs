namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class TemporalThing : UKParliamentDynamicNode
    {
        public TemporalThing(INode node) : base(node) { }

        public ICollection<DateTimeOffset> Date => new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.Date));

        public ICollection<DateTimeOffset> StartDate => new DynamicObjectCollection<DateTimeOffset>(this, Property(UKParliamentOntology.StartDate));
    }
}
