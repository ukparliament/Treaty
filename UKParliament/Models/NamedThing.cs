namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class NamedThing : UKParliamentDynamicNode
    {
        public NamedThing(INode node) : base(node) { }

        public ICollection<string> Name => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.Name));
    }
}
