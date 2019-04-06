namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class ExternalThing : UKParliamentDynamicNode
    {
        public ExternalThing(INode node) : base(node) { }

        public ICollection<string> ExternalIdentifier => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.ExternalIdentifier));
    }
}
