namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class DodsThing : ExternalThing
    {
        public DodsThing(INode node) : base(node) { }

        public ICollection<string> DodsId => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.DodsId));
    }
}
