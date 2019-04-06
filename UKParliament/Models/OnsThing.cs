namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class OnsThing : ExternalThing
    {
        public OnsThing(INode node) : base(node) { }

        public ICollection<string> OnsCode => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.OnsCode));
    }
}
