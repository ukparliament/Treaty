namespace UKParliament
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class PimsThing : ExternalThing
    {
        public PimsThing(INode node) : base(node) { }

        public ICollection<string> PimsId => new DynamicObjectCollection<string>(this, Property(UKParliamentOntology.PimsId));
    }
}
