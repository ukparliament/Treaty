namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class UkgapThing : ExternalThing
    {
        public UkgapThing(INode node) : base(node) { }

        public ICollection<string> UkgapId => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.UkgapId));
    }
}
